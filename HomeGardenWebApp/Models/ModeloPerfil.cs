using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeGardenWebApp.Models
{
    public class ModeloPerfil
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public string Telefone { get; set; }
        public string FotoPerfil { get; set; }
        public string FotoCapa { get; set; }
        //public virtual ICollection<Album> Albums { get; set; }
        //public virtual ICollection<Foto> Fotos { get; set; }
        public virtual ICollection<ModeloPerfil> Amigos { get; set; }
        //public virtual ICollection<Postagem> Postagens { get; set; }
        //public virtual ICollection<Conversa> Conversas { get; set; }
    }
}