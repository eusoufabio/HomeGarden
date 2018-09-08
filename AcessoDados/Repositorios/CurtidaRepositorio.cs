using ModelosDominio.Entidades;
using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Repositorios
{
    public class CurtidaRepositorio : ICurtidaRepositorio
    {
        public void Curtir(Curtida curtida)
        {
            throw new NotImplementedException();
        }

        public void Descurtir(Guid idCurtida)
        {
            throw new NotImplementedException();
        }

        public Curtida GetCurtida(Guid idCurtida)
        {
            throw new NotImplementedException();
        }

        public ICollection<Curtida> GetCurtidas(Guid idRecurso)
        {
            throw new NotImplementedException();
        }
    }
}
