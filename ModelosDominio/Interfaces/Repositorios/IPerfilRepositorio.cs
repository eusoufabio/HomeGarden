using ModelosDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Interfaces.Repositorios
{
    public interface IPerfilRepositorio
    {
        void Criar(Perfil perfil);
        void Excluir(Guid idPerfil);
        void Alterar(Perfil perfil);

        Perfil GetPerfil(Guid idPerfil);
        ICollection<Perfil> GetPerfis(string nome = "");
    }
}
