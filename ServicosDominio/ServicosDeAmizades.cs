using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicosDominio
{
    public class ServicosDeAmizades
    {
        private IAmizadeRepositorio _amizadeRepositorio;

        public ServicosDeAmizades(IAmizadeRepositorio amizadeRepositorio)
        {
            _amizadeRepositorio = amizadeRepositorio;
        }

    }
}
