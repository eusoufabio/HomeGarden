using ModelosDominio.Entidades;
using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Repositorios
{
    public class ComentarioRepositorio : IComentarioRepositorio
    {
        public void Comentar(Comentario comentario)
        {
            throw new NotImplementedException();
        }

        public void EditarComentario(Guid idComentario, string novoConteudo)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid idComentario)
        {
            throw new NotImplementedException();
        }

        public Comentario GetComentario(Guid idComentario)
        {
            throw new NotImplementedException();
        }

        public ICollection<Comentario> GetComentarios(Guid idRecurso)
        {
            throw new NotImplementedException();
        }
    }
}
