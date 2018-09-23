using HomeGardenWebApp.API;
using HomeGardenWebApp.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HomeGardenWebApp.Controllers
{
    public class InicioController : Controller
    {
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model); // SE O FORMULÁRIO ESTIVER ERRADO RECARREGA A PÁGINA

            // ############## REDIRECIONAR AQUI PARA A API ##############

            //var result = await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout: false);
            //switch (result)
            //{
            //    case SignInStatus.Success:
            //        return RedirectToLocal(returnUrl);
            //    case SignInStatus.LockedOut:
            //        return View("Lockout");
            //    case SignInStatus.RequiresVerification:
            //        return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
            //    case SignInStatus.Failure:
            //    default:
            //        ModelState.AddModelError("", "Invalid login attempt.");
            //        return View(model);
            //}
            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(APIRegistro.GetBaseURI());
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var conteudoFormulario = new FormUrlEncodedContent(new[]
            {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", model.Email),
                    new KeyValuePair<string, string>("password", model.Senha),
                });

                HttpResponseMessage resposta = await cliente.PostAsync("Token", conteudoFormulario);

                var respostaJson = await resposta.Content.ReadAsStringAsync();
                var jObject = JObject.Parse(respostaJson);

                Session["token"] = jObject.GetValue("access_token").ToString();
            }

            // ############## SE TUDO ESTIVER CERTO DIRECIONA PARA O CONTEÚDO ##############
            return RedirectToAction("Index", "Conteudo");
        }

        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Registro(RegistroViewModel modelo)
        {
            if (!ModelState.IsValid)
                return View(modelo); // SE O FORMULÁRIO ESTIVER ERRADO RECARREGA A PÁGINA

            var cliente = new HttpClient();
            
            cliente.BaseAddress = new Uri(APIRegistro.GetBaseURI());
            cliente.DefaultRequestHeaders.Accept.Clear();
            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var httpResponse = await cliente.PostAsJsonAsync("api/Account/Register", modelo);
            var retorno = httpResponse.Content;
        
            if (retorno.ToString() == "ERRO")
                return View(modelo);

            return RedirectToAction("Index", "Conteudo");
        }
    }
}