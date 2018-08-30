using ModelosDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosDominio.Interfaces.Repositorios
{
    public interface IAlbumRepositorio
    {
        void Criar(Album album);
        void Excluir(Guid idAlbum);

        Album GetAlbum(Guid idAlbum);
        ICollection<Album> GetAlbuns(Guid idPerfil);
        ICollection<Foto> GetFotos(Guid idAlbum);

        void AdicionarFotos(Guid idAlbum, List<Guid> idFotos); // USAR ICollection<> ou List<> ??????????????????
        void ExcluirFotos(Guid idAlbum, List<Guid> idFotos); // USAR ICollection<> ou List<> ??????????????????

        void MudarNome(Guid idAlbum, string novoNome);
        void MudarDescricao(Guid idAlbum, string novaDescricao);
    }
}
