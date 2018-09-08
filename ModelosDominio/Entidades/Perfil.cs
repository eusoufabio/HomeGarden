using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Entidades
{
    public class Perfil
    {
        public string IdIdentity { get; set; }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public string Telefone { get; set; }
        public string FotoPerfil { get; set; }
        public string FotoCapa { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Foto> Fotos { get; set; }
        public virtual ICollection<Perfil> Amigos { get; set; }
        public virtual ICollection<Postagem> Postagens { get; set; }
        public virtual ICollection<Conversa> Conversas { get; set; }
    }
}