using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Entidades
{
    public class Album
    {
        public Guid Id { get; set; }
        public Guid IdPerfil { get; set; }
        public string NomeAlbum { get; set; }
        public string DescricaoAlbum { get; set; }
        public ICollection<Foto> Fotos { get; set; }
    }
}
