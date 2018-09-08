using ModelosDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Interfaces.Repositorios
{
    public interface IAmizadeRepositorio
    {
        void SolicitarAmizade(Guid idPerfil, Guid idPerfilAmigo);
        void DesfazerAmizade(Guid idAmizade);

        Amizade GetAmizade(Guid idAmizade);
        ICollection<Amizade> GetAmizades(Guid idPerfil);

        void AceitarAmizade(Guid idAmizade);
    }
}
