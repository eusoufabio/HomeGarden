using ModelosDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Interfaces.Repositorios
{
    public interface IFotoRepositorio
    {
        void Adicionar(Foto foto);
        void Excluir(Guid idFoto);

        Foto GetFoto(Guid idFoto);

        void VincularAlbum(Guid idAlbum);
    }
}
