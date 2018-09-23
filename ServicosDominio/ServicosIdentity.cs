using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicosDominio
{
    public class ServicosIdentity
    {
        private IIdentityRepositorio _identityRepositorio;

        public ServicosIdentity(IIdentityRepositorio identityRepositorio)
        {
            _identityRepositorio = identityRepositorio;
        }

        public string GetId(string email)
        {
            return _identityRepositorio.GetId(email);
        }

    }
}
