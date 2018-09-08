using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicosDominio
{
    public class ServicosDeCurtidas
    {
        private ICurtidaRepositorio _curtidaRepositorio;

        public ServicosDeCurtidas(ICurtidaRepositorio curtidaRepositorio)
        {
            _curtidaRepositorio = curtidaRepositorio;
        }
    }
}
