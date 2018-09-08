using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicosDominio
{
    public class ServicosDePostagens
    {
        private IPostagemRepositorio _postagemRepositorio;

        public ServicosDePostagens(IPostagemRepositorio postagemRepositorio)
        {
            _postagemRepositorio = postagemRepositorio;
        }
    }
}
