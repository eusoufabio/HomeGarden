using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeGardenWebMVC_API.Models
{
    public class Perfil
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public string Telefone { get; set; }
        public string FotoPerfil { get; set; }
        public string FotoCapa { get; set; }
    }
}
