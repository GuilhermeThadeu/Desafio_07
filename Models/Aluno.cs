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

    public class Aluno : IDao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal Nota { get; set; }


        public bool Salvar()
        {
            try
            {

                using (var connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=9630;Database=postgres"))
                {

                    connection.Open();
                    NpgsqlCommand command = connection.CreateCommand();

                    command.CommandText = "INSERT INTO alunos (nome,idade,nota) values (@nome,@idade,@nota)";
                    command.Parameters.AddWithValue("@nome", this.Nome);
                    command.Parameters.AddWithValue("@idade", this.Idade);
                    command.Parameters.AddWithValue("@nota", this.Nota);

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
