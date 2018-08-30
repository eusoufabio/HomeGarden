using ModelosDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Interfaces.Repositorios
{
    public interface ICurtidaRepositorio
    {
        void Curtir(Curtida curtida);
        void Descurtir(Guid idCurtida);

        Curtida GetCurtida(Guid idCurtida);
        ICollection<Curtida> GetCurtidas(Guid idRecurso);
    }
}
