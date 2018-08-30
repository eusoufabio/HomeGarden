using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Entidades
{
    public class Comentario
    {
        public Guid Id { get; set; }
        public Guid IdPerfil { get; set; }
        public Guid IdRecurso { get; set; }
        public string Conteudo { get; set; }
        public string Imagem { get; set; }
        public DateTime DataHora { get; set; }
    }
}
