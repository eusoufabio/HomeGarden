using ModelosDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Interfaces.Repositorios
{
    public interface IMensagemRepositorio
    {
        void Enviar(Mensagem mensagem);
        void Excluir(Guid idMensagem);

        Mensagem GetMensagem(Guid idMensagem);
        ICollection<Mensagem> GetMensagens(Guid idPerfil);
    }
}
