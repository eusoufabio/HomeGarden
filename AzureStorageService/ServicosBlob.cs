using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureStorageService
{
    public class ServicosBlob
    {
        private CloudStorageAccount _contaArmazenamentoAzure;

        public ServicosBlob()
        {
            _contaArmazenamentoAzure = CloudStorageAccount.Parse(AzureStorageService.Properties.Settings.Default.StringConexaoBlob);
        }

        /// Retorna o endereço da imagem
        /// </summary>
        /// <param name="container"></param>
        /// <param name="fileName"></param>
        /// <param name="inputStream"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<string> PostarArquivo(string container, string fileName, System.IO.Stream fileStream, string contentType)
        {
            //Classe que faz acesso ao Azure Storage Blob
            CloudBlobClient ClienteBlob = _contaArmazenamentoAzure.CreateCloudBlobClient();

            //Classe que faz referência a um Container
            CloudBlobContainer ContainerBlob = ClienteBlob.GetContainerReference(container);

            //Cria um container novo se não existe
            await ContainerBlob.CreateIfNotExistsAsync();

            //Altera a configuração do container para permitir o acesso anônimo
            //await ContainerBlob.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });

            //Referência a uma imagem
            CloudBlockBlob CloudBlockBlob = ContainerBlob.GetBlockBlobReference(fileName);
            CloudBlockBlob.Properties.ContentType = contentType;

            //Upload não assíncrono
            await CloudBlockBlob.UploadFromStreamAsync(fileStream);

            //Blob URL
            return CloudBlockBlob.Uri.ToString();
        }
    }
}