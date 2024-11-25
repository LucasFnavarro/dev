using Dapper;
using IniciandoComDapper.Models;
using Microsoft.Data.SqlClient;

namespace IniciandoComDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CONNECTION_STRING = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true";
            using var connection = new SqlConnection(CONNECTION_STRING);
            // CreateCategory(connection);
            // CreateManyCategory(connection);
            // UpdateCategory(connection);
            // GetCategory(connection);
            // ExecuteScalar(connection);
            // ListCategories(connection);
            // ExecuteProcedure(connection);
            // DeleteStudent(connection, "e5cfd760-163a-41a7-acb7-72d22bf8bfee");
            // ReadView(connection);
        }

        // Mapeamento de objetos fortemente tipados, 
        // o que é uma prática recomendada para garantir maior clareza e segurança no código. 
        static void ListCategories(SqlConnection connection)
        {
            var categorias = connection.Query<Category>("SELECT [Id], [Title], [Summary] FROM [Category]");
            foreach (var categoria in categorias)
            {
                Console.WriteLine($"Id: {categoria.Id} - Nome: {categoria.Title} - Sumário: {categoria.Summary}");
            }
        }

        static void GetCategoryViaId(SqlConnection connection)
        {
            try
            {
                var getIdSql = @"SELECT [Id], [Title], [Summary] FROM [Category] WHERE [Id]=@id";
                var parametro = new { Id = "09ce0b7b-cfca-497b-92c0-3290ad9d5142" };
                var getCategory = connection.QueryFirstOrDefault<Category>(getIdSql, parametro);

                if (getCategory != null)
                {
                    Console.WriteLine($"Categoria encontrada: ID = {getCategory.Id} - TITULO: {getCategory.Title} - SUMÁRIO: {getCategory.Summary}");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Não encontramos nenhuma categoria com este ID..." + error.Message);
            }
        }

        static void CreateCategory(SqlConnection connection)
        {
            // Inserindo nova categoria no BD.
            var category = new Category
            {
                Id = Guid.NewGuid(),
                Title = "AWS Amazon",
                Url = "deploynanuvem",
                Summary = "Aprendendo Git GitHub e deploy na nuvem",
                Order = 1,
                Description = "AWS curso DevOps",
                Featuread = true
            };

            // Nunca concatenar strings nas query; $"{category.Id}";
            var sqlInsert = @"INSERT INTO [Category] VALUES (@Id, @Title, @Url, @Summary, @Order, @Description, @Featuread)";

            // connection.Execute(sql);
            var insert = connection.Execute(sqlInsert, new
            {
                category.Id,
                category.Title,
                category.Url,
                category.Summary,
                category.Order,
                category.Description,
                category.Featuread
            });

            Console.WriteLine($"{insert} Linha Inserida!");
        }

        //### erro ao tentar add multiplas categorias.
        static void CreateManyCategory(SqlConnection connection)
        {
            // Inserindo nova categoria no BD.
            var category = new Category
            {
                Id = Guid.NewGuid(),
                Title = "Salvando 2 categoria de uma vez",
                Url = "2categorias",
                Summary = "Duas categorias de uma vez",
                Order = 1,
                Description = "New two categories",
                Featuread = false
            };

            var category2 = new Category
            {
                Id = Guid.NewGuid(),
                Title = "Categoria Nova",
                Url = "categorianova",
                Summary = "Nova Categoria Dupla",
                Order = 7,
                Description = "Categoria 2",
                Featuread = true
            };

            // Nunca concatenar strings nas query; $"{category.Id}";
            var sqlInsert = @"INSERT INTO [Category] VALUES (@Id, @Title, @Url, @Summary, @Order, @Description, @Featuread)";

            // connection.Execute(sql);
            var insert = connection.Execute(sqlInsert, new[]{
            new
            {
                category.Id,
                category.Title,
                category.Url,
                category.Summary,
                category.Order,
                category.Description,
                category.Featuread
            },

            new
            {
                category.Id,
                category.Title,
                category.Url,
                category.Summary,
                category.Order,
                category.Description,
                category.Featuread
            }
            });

            Console.WriteLine($"{insert} Linha Inserida!");
        }

        static void UpdateCategory(SqlConnection connection)
        {
            var sqlUpdate = @"UPDATE [Category] SET [Title]=@title, [Url]=@url, [Summary]=@summary WHERE [Id]=@id";

            var updateCategoria = connection.Execute(sqlUpdate, new
            {
                id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4"),
                title = "Frontend 2024",
                summary = "C# é muito top",
                url = "c#-ébomdemais"
            });

            Console.WriteLine($"{updateCategoria} registros atualizados");
        }

        static void ExecuteProcedure(SqlConnection connection)
        {
            var procedure = "[spDeleteStudent]";
            var pars = new { StudentId = "0c8b845c-66aa-4fdc-8a83-30eeea0d9a48" };

            var rows = connection.Execute(procedure, pars, commandType: System.Data.CommandType.StoredProcedure);
            Console.WriteLine($"{rows} linhas afetadas.");
        }

        static void DeleteStudent(SqlConnection connection, string studentId)
        {
            var sql = "DELETE FROM Student WHERE Id = @StudentId";
            connection.Execute(sql, new { StudentId = studentId });
        }

        static void ExecuteScalar(SqlConnection connection)
        {
             var category = new Category
            {
                Title = "Aprendendo Scalar",
                Url = "dapper",
                Summary = "Execute Scalar com Dapper SQLServer",
                Order = 1,
                Description = "dapper",
                Featuread = true
            };

            // Nunca concatenar strings nas query; $"{category.Id}";
            var sqlInsert = @"INSERT INTO [Category] OUTPUT inserted.[Id]
             VALUES (NEWID(), @Title, @Url, @Summary, @Order, @Description, @Featuread)
             SELECT SCOPE_IDENTITY()";

            // connection.Execute(sql);
            var id = connection.ExecuteScalar<Guid>(sqlInsert, new
            {
                category.Title,
                category.Url,
                category.Summary,
                category.Order,
                category.Description,
                category.Featuread
            });

            Console.WriteLine($"A categoria inserida foi: {id}");
        }
    
        static void ReadView(SqlConnection connection)
        {
            var sql = "SELECT * FROM [vwCourses]";

            var courses = connection.Query(sql);

            foreach(var item in courses)
            {
                Console.WriteLine($"Id: {item.Id} - {item.Title}");
            }
        }
    
    }
}