using HomeGardenWebMVC_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HomeGardenWebMVC_API.AcessoAPI
{
    public class APIHomeGarden
    {
        private HttpClient _clienteAPI;

        public APIHomeGarden(string urlAPI)
        {
            // PREPARA A CONEXÃO COM A API
            _clienteAPI = new HttpClient();
            _clienteAPI.BaseAddress = new Uri(urlAPI);
            _clienteAPI.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }

        public string GetIdIdentity(string action, string email)
        {
            return _clienteAPI.GetAsync(action + email).Result.Content.ReadAsStringAsync().ToString();
        }

        public HttpResponseMessage Registrar(string action, RegisterViewModel perfil)
        {
            // SE CONECTA COM UMA ACTION
            Task<HttpResponseMessage> retorno;
            retorno = _clienteAPI.PostAsJsonAsync(action, perfil);

            //var request = _clienteAPI.GetAsync(action);

            //Task<string> requestContent = request.Result.Content.ReadAsStringAsync();
            //string serializedProfiles = requestContent.Result;

            //IEnumerable<Perfil> perfis = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Perfil>>(serializedProfiles);

            return  retorno.Result;// perfis.ToString();
        }

        public IEnumerable<Perfil> GetPerfis()
        {
            // SE CONECTA COM UMA ACTION
            var request = _clienteAPI.GetAsync("api/");

            Task<string> requestContent = request.Result.Content.ReadAsStringAsync();
            string serializedProfiles = requestContent.Result;

            IEnumerable<Perfil> perfis = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Perfil>>(serializedProfiles);

            return perfis;
        }
    }
}