using ModelosDominio.Entidades;
using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Repositorios
{
    public class PerfilRepositorio : IPerfilRepositorio
    {
        public void Alterar(Perfil perfil)
        {
            return;
        }

        public void Criar(Perfil perfil)
        {
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(AcessoDados.Properties.Settings.Default.StringConexaoIdentity);
            sqlConnection.Open();

            string comando = "INSERT INTO tb_Perfil (IdIdentity, Id, Email) VALUES (@idIdentity, @id, @email)";
            
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@idIdentity", perfil.IdIdentity);
            sqlCommand.Parameters.AddWithValue("@id", perfil.Id);
            sqlCommand.Parameters.AddWithValue("@email", perfil.Email);

            sqlCommand.ExecuteNonQuery();
        }

        public void Atualizar(Perfil perfil)
        {
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(Properties.Settings.Default.StringConexaoIdentity);
            sqlConnection.Open();

            string comando = "UPDATE tb_Perfil SET Nome = @Nome, Sobrenome = @Sobrenome, Nascimento = @Nascimento, Telefone = @Telefone, FotoPerfil = @FotoPerfil, FotoCapa = @FotoCapa WHERE Id = @Id";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Id", perfil.Id);
            sqlCommand.Parameters.AddWithValue("@Nome", perfil.Nome);
            sqlCommand.Parameters.AddWithValue("@Sobrenome", perfil.Sobrenome);
            sqlCommand.Parameters.AddWithValue("@Nascimento", perfil.Nascimento);
            sqlCommand.Parameters.AddWithValue("@Telefone", perfil.Telefone);
            sqlCommand.Parameters.AddWithValue("@FotoPerfil", perfil.FotoPerfil);
            sqlCommand.Parameters.AddWithValue("@FotoCapa", perfil.FotoCapa);

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void Excluir(Guid idPerfil)
        {
            throw new NotImplementedException();
        }

        public Perfil GetPerfil(Guid idPerfil)
        {
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(Properties.Settings.Default.StringConexaoIdentity);
            sqlConnection.Open();

            string comando = "SELECT * FROM tb_Perfil WHERE Id = @Id";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Id", idPerfil);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            Perfil perfil = new Perfil();

            while (reader.Read())
            {
                perfil.IdIdentity = reader["IdIdentity"].ToString();
                perfil.Id = (Guid) reader["Id"];
                perfil.Nome = reader["Nome"].ToString();
                perfil.Sobrenome = reader["Sobrenome"].ToString();
                perfil.Email = reader["Email"].ToString();
                perfil.Nascimento = (DateTime) reader["Nascimento"];
                perfil.Telefone = reader["Telefone"].ToString();
                perfil.FotoPerfil = reader["FotoPerfil"].ToString();
                perfil.FotoCapa = reader["FotoCapa"].ToString();
            }

            sqlConnection.Close();

            return perfil;
        }

        public ICollection<Perfil> GetPerfis(string nome = "")
        {
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(Properties.Settings.Default.StringConexaoIdentity);
            sqlConnection.Open();

            string comando = "SELECT * FROM tb_Perfil WHERE CONCAT(Nome, ' ', Sobrenome) Like '%@Nome%'";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Nome", nome);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            ICollection<Perfil> perfis = null;

            while (reader.Read())
            {
                Perfil perfil = new Perfil();
                perfil.IdIdentity = reader["IdIdentity"].ToString();
                perfil.Id = (Guid)reader["Id"];
                perfil.Nome = reader["Nome"].ToString();
                perfil.Sobrenome = reader["Sobrenome"].ToString();
                perfil.Email = reader["Email"].ToString();
                perfil.Nascimento = (DateTime)reader["Nascimento"];
                perfil.Telefone = reader["Telefone"].ToString();
                perfil.FotoPerfil = reader["FotoPerfil"].ToString();
                perfil.FotoCapa = reader["FotoCapa"].ToString();

                perfis.Add(perfil);
            }

            sqlConnection.Close();

            return perfis;
        }
    }
}
