using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicosDominio
{
    public class ServicosDeMensagens
    {
        private IMensagemRepositorio _mensagemRepositorio;

        public ServicosDeMensagens(IMensagemRepositorio mensagemRepositorio)
        {
            _mensagemRepositorio = mensagemRepositorio;
        }
    }
}
