using HomeGardenWebApp.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace HomeGardenWebApp.API
{
    public static class APIRegistro
    {
        public static string GetBaseURI()
        {
            if (Properties.Settings.Default.EmProducao)
                return Properties.Settings.Default.BaseURIProducao;

            return Properties.Settings.Default.BaseURITeste;
        }

        public static string Registro(RegistroViewModel modelo)
        {
            return null;
        }

        public static async Task<string> PostRequest(string uri, string conteudo)
        {
            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(GetBaseURI());
                cliente.DefaultRequestHeaders.Clear();
                var httpResponse = await cliente.PostAsJsonAsync(uri, conteudo);

                return httpResponse.Content.ToString();
            }
        }

        public static async Task<string> GetToken(string email, string senha)
        {
            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(GetBaseURI());
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var conteudoFormulario = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", email),
                    new KeyValuePair<string, string>("password", senha),
                });

                HttpResponseMessage resposta = await cliente.PostAsync("/Token", conteudoFormulario);

                var respostaJson = await resposta.Content.ReadAsStringAsync();
                var jObject = JObject.Parse(respostaJson);

                return jObject.GetValue("access_token").ToString();
            }
        }

        private static async Task<string> GetRequest(string token, string pathRequisicao)
        {
            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(GetBaseURI());
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                cliente.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                HttpResponseMessage retorno = await cliente.GetAsync(pathRequisicao);
                var retornoString = await retorno.Content.ReadAsStringAsync();
                return retornoString;
            }
        }
    }
}