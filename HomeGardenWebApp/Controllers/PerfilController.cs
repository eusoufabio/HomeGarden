using HomeGardenWebApp.API;
using HomeGardenWebApp.Models;
using ModelosDominio.Entidades;
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
    public class PerfilController : Controller
    {
        // GET: Perfil/Details/5

        [HttpGet]
        [Route(Name = "Detalhes")]
        public async Task<ActionResult> Detalhes(string idPerfil)
        {
            var cliente = new HttpClient();

            cliente.BaseAddress = new Uri(APIRegistro.GetBaseURI());
            cliente.DefaultRequestHeaders.Accept.Clear();
            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // ############
            idPerfil = "6c2bf86d-eb35-4ce6-94ad-319177b3a40c";
            // ############

            //var httpResponse = await cliente.PostAsJsonAsync("api/Perfil/Detalhes", idPerfil);
            var httpResponse = await cliente.GetAsync("api/Perfil/Detalhes?id=" + idPerfil);

            if (httpResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var retorno = httpResponse.Content.ReadAsAsync<Perfil>();
                var perfil = new ModeloPerfil()
                {
                    Nome = retorno.Result.Nome,
                    Email = retorno.Result.Email,
                    FotoCapa = retorno.Result.FotoCapa,
                    FotoPerfil = retorno.Result.FotoPerfil,
                    Nascimento = retorno.Result.Nascimento,
                    Sobrenome = retorno.Result.Sobrenome,
                    Telefone = retorno.Result.Telefone
                };

                return View(perfil);
            }

            return RedirectToAction("Index", "Conteudo");
        }

        // GET: Perfil/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: Perfil/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Perfil/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View();
        }

        // POST: Perfil/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
