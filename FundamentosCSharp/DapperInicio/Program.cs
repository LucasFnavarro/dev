using System;
using Dapper;
using FundamentosCSharp.Models;
using Microsoft.Data.SqlClient;

namespace FundamentosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString =
                "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true";

            var category = new Category
            {
                Id = Guid.NewGuid(),
                Title = "Livro de Fundamentos do CSharp",
                Url = "csharp",
                Summary = "Livro técnico",
                Order = 2,
                Description = "Microservices e Fundamentos de Arquitetura C#",
                Featuread = false
            };

            var insertCategory =
                @"INSERT INTO [Category] VALUES (@Id, @Title, @Url, @Summary, @Order, @Description, @Featuread)";

            using (var connection = new SqlConnection(connectionString))
            {
                var createNewCategory = connection.Execute(insertCategory, new
                {
                    category.Id,
                    category.Title,
                    category.Url,
                    category.Summary,
                    category.Order,
                    category.Description,
                    category.Featuread
                });

                Console.WriteLine($"{createNewCategory} - Linhas afetadas.");

                var categories = connection.Query<Category>("SELECT [Id], [Title], [Description] FROM [Category]");

                foreach (var item in categories)
                {
                    Console.WriteLine($"ID: {item.Id} - Title: {item.Title} - Descrição: {item.Description}");
                }
            }
        }
    }
}