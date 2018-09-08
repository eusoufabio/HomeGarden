using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Entidades
{
    public class Amizade
    {
        public Guid Id { get; set; }
        public Guid IdPerfil { get; set; }
        public Guid IdPerfilAmigo { get; set; }
        public bool Confirmada { get; set; }
        public DateTime DataHoraSolicitacao { get; set; }
        public DateTime DataHoraConfirmacao { get; set; }
    }
}
