using desafio_07.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Npgsql;


namespace desafio_07
{
    class Program
    {


        static void Main(string[] args)
        {

            var aluno = new Aluno();
            var curso = new Curso();
            var status = new Status();

            Console.WriteLine("\nDigite o nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("\nDigite a idade do Aluno: ");
            aluno.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite a nota do Aluno: ");
            aluno.Nota = Decimal.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("\nDigite o Nome do Curso");
            curso.Nome = Console.ReadLine();
            if (aluno.Nota >= 60)
            {
                status.status = true;
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            aluno.Salvar();
            curso.Salvar();
            status.Salvar();
            Console.WriteLine("Cadastro feito com sucesso!");


        }


    }
}