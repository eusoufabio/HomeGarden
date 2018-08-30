using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Entidades
{
    public class Postagem
    {
        public Guid Id { get; set; }
        public Guid IdPerfil { get; set; }
        public string Mensagem { get; set; }
        public string Imagem { get; set; }
        public DateTime DataHora { get; set; }
    }
}
