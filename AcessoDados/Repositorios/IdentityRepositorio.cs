using ModelosDominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Repositorios
{
    public class IdentityRepositorio : IIdentityRepositorio
    {
        public string GetId(string email)
        {
            if (email == null)
                return "";

            SqlConnection sqlConnection;
            //sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fabio\Documents\Final\HomeGarden\HomeGardenWebAPI\App_Data\aspnet-HomeGardenWebAPI-20180901050731.mdf;Integrated Security=True;Connect Timeout=30");
            sqlConnection = new SqlConnection(AcessoDados.Properties.Settings.Default.StringConexaoIdentity);
            sqlConnection.Open();

            SqlCommand sqlCommand;

            string comando = @"SELECT * FROM AspNetUsers WHERE Email = @email";

            sqlCommand = new SqlCommand(comando, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@email", email);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            string retorno = "";

            while (reader.Read())
                retorno = reader["Id"].ToString();

            sqlConnection.Close();

            return retorno;
        }
    }
}
