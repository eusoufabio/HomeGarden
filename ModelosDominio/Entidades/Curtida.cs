using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Entidades
{
    public class Curtida
    {
        public Guid Id { get; set; }
        public Guid IdPerfil { get; set; }
        public Guid IdRecurso { get; set; }
        public DateTime DataHora { get; set; }
    }
}
