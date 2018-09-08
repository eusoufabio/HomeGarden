using ModelosDominio.Entidades;
using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Repositorios
{
    public class AmizadeRepositorio : IAmizadeRepositorio
    {
        public void AceitarAmizade(Guid idAmizade)
        {
            throw new NotImplementedException();
        }

        public void DesfazerAmizade(Guid idAmizade)
        {
            throw new NotImplementedException();
        }

        public Amizade GetAmizade(Guid idAmizade)
        {
            throw new NotImplementedException();
        }

        public ICollection<Amizade> GetAmizades(Guid idPerfil)
        {
            throw new NotImplementedException();
        }

        public void SolicitarAmizade(Guid idPerfil, Guid idPerfilAmigo)
        {
            throw new NotImplementedException();
        }
    }
}
