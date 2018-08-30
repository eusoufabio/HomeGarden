using ModelosDominio.Entidades;
using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Repositorios
{
    public class RepositorioAlbum : IAlbumRepositorio
    {
        public void AdicionarFotos(Guid idAlbum, List<Guid> idFotos)
        {
            throw new NotImplementedException();
        }

        public void Criar(Album album)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid idAlbum)
        {
            throw new NotImplementedException();
        }

        public void ExcluirFotos(Guid idAlbum, List<Guid> idFotos)
        {
            throw new NotImplementedException();
        }

        public Album GetAlbum(Guid idAlbum)
        {
            throw new NotImplementedException();
        }

        public ICollection<Album> GetAlbuns(Guid idPerfil)
        {
            throw new NotImplementedException();
        }

        public ICollection<Foto> GetFotos(Guid idAlbum)
        {
            throw new NotImplementedException();
        }

        public void MudarDescricao(Guid idAlbum, string novaDescricao)
        {
            throw new NotImplementedException();
        }

        public void MudarNome(Guid idAlbum, string novoNome)
        {
            throw new NotImplementedException();
        }
    }
}
