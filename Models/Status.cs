using desafio_07.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.SqlClient;


namespace desafio_07.Models
{
    public class Status : IDao
    {
        public bool status { get; set; }

        public bool Salvar()
        {
            try
            {

                using (var connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=9630;Database=postgres"))
                {

                    connection.Open();
                    NpgsqlCommand command = connection.CreateCommand();

                    command.CommandText = "INSERT INTO status (status) values (@status)";
                    command.Parameters.AddWithValue("@status", this.status);

                    command.ExecuteNonQuery();

                    connection.Close();
                    return true;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um Erro ao acessar o banco");
                return false;
            }
        }
    }
}
