using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicosDominio
{
    public class ServicosDeAlbuns
    {
        private IAlbumRepositorio _albumRepositorio;

        public ServicosDeAlbuns(IAlbumRepositorio albumRepositorio)
        {
            _albumRepositorio = albumRepositorio;
        }
    }
}
