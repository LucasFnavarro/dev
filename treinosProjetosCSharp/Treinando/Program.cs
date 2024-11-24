using System;

namespace Treinando
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite a opção que desejar");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Editar arquivo");
            Console.WriteLine("0 - Para sair");

            short opcaoMenu = short.Parse(Console.ReadLine());

            switch (opcaoMenu)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {

        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite o seu texto ou (ESC para sair)");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=--=-=--=-=-=-");
            var text = Console.ReadLine();

            do
            {
                text += Console.ReadLine();
                text += System.Environment.NewLine;

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("EEm qual caminho deseja salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.WriteLine(text);
            }

            Console.WriteLine($"O arquivo {path} foi salvo com sucesso");
            Menu();

        }


    }
}