using ModelosDominio.Entidades;
using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Repositorios
{
    public class PostagemRepositorio : IPostagemRepositorio
    {
        public void Excluir(Guid idPostagem)
        {
            throw new NotImplementedException();
        }

        public Postagem GetPostagem(Guid idPostagem)
        {
            throw new NotImplementedException();
        }

        public ICollection<Postagem> GetPostagens()
        {
            throw new NotImplementedException();
        }

        public ICollection<Postagem> GetPostagens(Guid idPerfil)
        {
            throw new NotImplementedException();
        }

        public void Publicar(Postagem postagem)
        {
            throw new NotImplementedException();
        }
    }
}
