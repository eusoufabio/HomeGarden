using ModelosDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Interfaces.Repositorios
{
    public interface IPostagemRepositorio
    {
        void Publicar(Postagem postagem);
        void Excluir(Guid idPostagem);

        Postagem GetPostagem(Guid idPostagem);
        ICollection<Postagem> GetPostagens();
        ICollection<Postagem> GetPostagens(Guid idPerfil);
    }
}
