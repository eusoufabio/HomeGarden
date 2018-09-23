using AcessoDados.Repositorios;
using ModelosDominio.Entidades;
using Newtonsoft.Json.Linq;
using ServicosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeGardenWebAPI.Controllers
{
    public class PerfilController : ApiController
    {


        [HttpGet]
        public Perfil Detalhes(Guid id)
        {
            var servicoPerfil = new ServicosDePerfis(new PerfilRepositorio());
            return servicoPerfil.GetPerfil(id);
        }

        [HttpGet]
        public string IdConta(string emaill)
        {
            var servicosIdentity = new ServicosIdentity(new IdentityRepositorio());
            return servicosIdentity.GetId(emaill);
        }

        [HttpPost]
        public HttpResponseMessage IdPorEmail([FromBody] string email)
        {
            var servicoPerfil = new ServicosDePerfis(new PerfilRepositorio());
            var resposta = new HttpResponseMessage(HttpStatusCode.OK);
            resposta.Content = new StringContent(servicoPerfil.GetId(email).ToString(), System.Text.Encoding.UTF8, "application/json");
            return resposta;

            //return servicoPerfil.GetId(email);
        }

        // GET: api/Perfil/5
        public ModelosDominio.Entidades.Perfil Get(Guid idPerfil)
        {
            var servicosPerfil = new ServicosDePerfis(new PerfilRepositorio());
            return servicosPerfil.GetPerfil(idPerfil);
        }

        //// POST: api/Perfil
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT: api/Perfil/5
        public void Put(Guid id, [FromBody]string value)
        {
        }

        // DELETE: api/Perfil/5
        public void Delete(Guid id)
        {
        }
    }
}