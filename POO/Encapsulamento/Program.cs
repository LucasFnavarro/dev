using System;

/*
    Encapsulamento -> Um objeto se refere sempre a algo do mundo real, seja ele físico ou abstrato.
   
    => Um objeto contém Propriedades, Métodos e Eventos.
    => As classes são os moldes para criar nossos objetos.
    => Struct também é uma estrutura de dados, só que ele armazena o endereço em sí e as classes
    armazena apenas o endereço.
*/

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                => Encapsulamento é um dos primeiros conceitos da POO
                => Quanto menor os pedaços melhor
                => O processo de pegar informações de pagamento, ações que o pagamento pode realizar,
                   eventos que o pagamento pode ter e trazer para dentro de uma Classe é o coceito de Encapsulamento.
                => Ele encapsula tudo dentro de uma classe, agrupa tudo o que faz sentido estar junto.
            */



            /*
                => Abstração é o segundo conceito de POO
                => Serve para abstrair as funções, exemplo:
                            ----> Quando você leva o carro para arrumar, o mecanico lhe da uma abstração do serviço feito,
                            ele não fala o que foi feito quando abriu o motor o que trocou detalhe por detalhe, é o ato de esconder detalhes.
                
            */

            var pagamento = new Pagamento();
            Console.WriteLine(pagamento.Pagar());
        }
    }

    public class Pagamento
    {
        public DateTime Vencimento;

        public string Pagar()
        {
            return ConsultarSaldoDoCartao("14321432");
        }

        // Abstração
        // Classes fora não pode acessar esse método
        // Ele está abstraído para a Class Pagamento
        // Quanto menos detalhe expor, melhor é!
        // Facilita caso tenha alguma mudança, não vamos precisar mudar em várias class
        private string ConsultarSaldoDoCartao(string numero) 
        { 
            return "Saldo consultado com sucesso!";
        }
    }
}
