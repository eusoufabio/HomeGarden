using ModelosDominio.Entidades;
using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicosDominio
{
    public class ServicosDePerfis
    {
        private IPerfilRepositorio _perfilRepositorio;

        public ServicosDePerfis(IPerfilRepositorio perfilRepositorio)
        {
            _perfilRepositorio = perfilRepositorio;
        }

        public void CriarPerfil(Perfil perfil)
        {
            _perfilRepositorio.Criar(perfil);
        }

        public void EditarPerfil(Perfil perfil)
        {
            _perfilRepositorio.Editar(perfil);
        }

        public void ExcluirPerfil(Guid id)
        {
            _perfilRepositorio.Excluir(id);
        }

        public Perfil GetPerfil(Guid idPerfil)
        {
            return _perfilRepositorio.GetPerfil(idPerfil);
        }

        public ICollection<Perfil> GetPerfis(string nome)
        {
            return _perfilRepositorio.GetPerfis(nome);
        }

        public Guid GetId(string email)
        {
            return _perfilRepositorio.GetId(email);
        }
    }
}
