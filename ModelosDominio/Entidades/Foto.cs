using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Entidades
{
    public class Foto
    {
        public Guid Id { get; set; }
        public Guid IdPerfil { get; set; }
        public ICollection<Guid> IdAlbuns { get; set; }
        public string URLFoto { get; set; }
        public DateTime DataHora { get; set; }
    }
}
