using ModelosDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Interfaces.Repositorios
{
    public interface IComentarioRepositorio
    {
        void Comentar(Comentario comentario);
        void Excluir(Guid idComentario);

        Comentario GetComentario(Guid idComentario);
        ICollection<Comentario> GetComentarios(Guid idRecurso);

        void EditarComentario(Guid idComentario, string novoConteudo);
    }
}
