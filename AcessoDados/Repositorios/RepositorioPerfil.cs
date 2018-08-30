using ModelosDominio.Entidades;
using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Repositorios
{
    public class RepositorioPerfil : IPerfilRepositorio
    {
        public void Alterar(Perfil perfil)
        {
            throw new NotImplementedException();
        }

        public void Criar(Perfil perfil)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid idPerfil)
        {
            throw new NotImplementedException();
        }

        public Perfil GetPerfil(Guid idPerfil)
        {
            throw new NotImplementedException();
        }

        public ICollection<Perfil> GetPerfis(string nome = "")
        {
            throw new NotImplementedException();
        }
    }
}
