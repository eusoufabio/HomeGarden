using ModelosDominio.Entidades;
using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Repositorios
{
    public class RepositorioMensagem : IMensagemRepositorio
    {
        public void Enviar(Mensagem mensagem)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid idMensagem)
        {
            throw new NotImplementedException();
        }

        public Mensagem GetMensagem(Guid idMensagem)
        {
            throw new NotImplementedException();
        }

        public ICollection<Mensagem> GetMensagens(Guid idPerfil)
        {
            throw new NotImplementedException();
        }
    }
}
