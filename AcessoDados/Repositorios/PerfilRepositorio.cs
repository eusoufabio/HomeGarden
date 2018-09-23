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
        private readonly string _stringConexaoDados = AcessoDados.Properties.Settings.Default.StringConexaoDados;

        public SqlConnection AbrirConexao(string stringConexao = "")
        {
            if (stringConexao == "")
                stringConexao = _stringConexaoDados;

            var conexao = new SqlConnection(stringConexao);
            conexao.Open();

            return conexao;
        }

        public void Editar(Perfil perfil)
        {
            var sqlConnection = AbrirConexao();

            string comando = "UPDATE TB_Perfil SET Nome = @Nome, ";
            comando += "Sobrenome = @Sobrenome, ";
            comando += "Nascimento = @Nascimento, ";
            comando += "Telefone = @Telefone, ";
            comando += "FotoPerfil = @FotoPerfil, ";
            comando += "FotoCapa = @FotoCapa ";
            comando += "WHERE Id = @Id";

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

        public void Criar(Perfil perfil)
        {
            var sqlConnection = AbrirConexao();
            try
            {

                string comando = "INSERT INTO TB_Perfil (IdConta, Id, Nome, Email) VALUES (@idConta, @id, @Nome, @email)";

                SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@idConta", perfil.IdConta.ToString());
                sqlCommand.Parameters.AddWithValue("@id", perfil.Id.ToString());
                sqlCommand.Parameters.AddWithValue("@Nome", perfil.Nome.ToString());
                sqlCommand.Parameters.AddWithValue("@email", perfil.Email.ToString());

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void Atualizar(Perfil perfil)
        {
            var sqlConnection = AbrirConexao();

            string comando = "UPDATE TB_Perfil SET Nome = @Nome, Sobrenome = @Sobrenome, Nascimento = @Nascimento, Telefone = @Telefone, FotoPerfil = @FotoPerfil, FotoCapa = @FotoCapa WHERE Id = @Id";
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
            var sqlConnection = AbrirConexao();

            string comando = "SELECT * FROM TB_Perfil WHERE Id = @Id";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Id", idPerfil);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            Perfil perfil = new Perfil();

            while (reader.Read())
            {
                perfil.IdConta = reader["IdConta"].ToString();
                perfil.Id = Guid.Parse(reader["Id"].ToString());
                perfil.Nome = reader["Nome"].ToString();
                perfil.Sobrenome = reader["Sobrenome"].ToString();
                perfil.Email = reader["Email"].ToString();
                //if (reader["Nascimento"] != null)
                //    perfil.Nascimento = DateTime.Parse(reader["Nascimento"].ToString());
                perfil.Telefone = reader["Telefone"].ToString();
                perfil.FotoPerfil = reader["FotoPerfil"].ToString();
                perfil.FotoCapa = reader["FotoCapa"].ToString();
            }

            sqlConnection.Close();

            return perfil;
        }

        public ICollection<Perfil> GetPerfis(string nome = "")
        {
            var sqlConnection = AbrirConexao();

            string comando = "SELECT * FROM TB_Perfil WHERE CONCAT(Nome, ' ', Sobrenome) Like '%@Nome%'";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Nome", nome);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            ICollection<Perfil> perfis = null;

            while (reader.Read())
            {
                Perfil perfil = new Perfil();
                perfil.IdConta = reader["IdConta"].ToString();
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

        public Guid GetId(string email)
        {
            var sqlConnection = AbrirConexao();

            string comando = "SELECT * FROM TB_Perfil WHERE Email = @Email";
            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Email", email);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            Guid retorno = Guid.Empty;

            if (reader.HasRows)
            {
                reader.Read();
                retorno = new Guid(reader["Id"].ToString());
            }

            sqlConnection.Close();

            return retorno;
        }
    }
}
