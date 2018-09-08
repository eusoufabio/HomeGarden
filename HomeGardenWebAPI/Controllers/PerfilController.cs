using AcessoDados.Repositorios;
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

        public string GetIdIdentity(string email)
        {
            var servicosIdentity = new ServicosDoIdentity(new IdentityRepositorio());

            return servicosIdentity.GetId(email);
            //return "Foi";
        }

        // GET: api/Perfil
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Perfil/5
        public string Get(int id)
        {
            return "value, não é esse";
        }

        // POST: api/Perfil
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Perfil/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Perfil/5
        public void Delete(int id)
        {
        }
    }
}
