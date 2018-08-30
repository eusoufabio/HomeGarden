using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Entidades
{
    public class Mensagem
    {
        public Guid Id { get; set; }
        public Guid IdRemetente { get; set; }
        public Guid IdDestinatario { get; set; }
        public string Conteudo { get; set; }
        public string URLArquivo { get; set; }
        public DateTime DataHora { get; set; }
        public bool Lida { get; set; }
        public DateTime DataHoraLeitura { get; set; }
    }
}
