using System;

            /*
                Tipo de Referência
                -> Só armazena o endereço dos dados (não armazena os dados em sí, só uma referência na memória heap).

                Tipos de valores -> ficam na memória stack muito mais rápidos de ser acessado,
                mas se precisar copiar o valor precisa copiar o valor como um todo
            */

namespace ClasseEObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Name = "Lucas";
        }
    }
   
    class Customer {
        public string Name;
    }
}