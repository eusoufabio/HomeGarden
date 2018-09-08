using ModelosDominio.Entidades;
using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Repositorios
{
    public class FotoRepositorio : IFotoRepositorio
    {
        public void Adicionar(Foto foto)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid idFoto)
        {
            throw new NotImplementedException();
        }

        public Foto GetFoto(Guid idFoto)
        {
            throw new NotImplementedException();
        }

        public void VincularAlbum(Guid idAlbum)
        {
            throw new NotImplementedException();
        }
    }
}
