using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicosDominio
{
    public class ServicosDeFotos
    {
        private IFotoRepositorio _fotoRepositorio;

        public ServicosDeFotos(IFotoRepositorio fotoRepositorio)
        {
            _fotoRepositorio = fotoRepositorio;
        }
    }
}
