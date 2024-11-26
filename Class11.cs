using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class EscolhadeBebida2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha sua bebida:");
            Console.WriteLine("1- Café");
            Console.WriteLine("2- Chá ");
            Console.WriteLine("3- Suco ");
            Console.WriteLine("4- Refrigerante");
            Console.WriteLine("Digite o numero do que deseja pedir:");
            int pedido = Convert.ToInt16(Console.ReadLine());
            switch (pedido)
            {
                case 1:
                    Console.WriteLine("Digite o tipo de café:");
                    Console.WriteLine("1 - Expresso (R$ 3,00)");
                    Console.WriteLine("2 - Latte (R$ 8,00)");
                    Console.WriteLine("3 - Cappuccino (R$ 7,00)");
                    int cafe = Convert.ToInt16(Console.ReadLine()); 
                    switch (cafe)
                    {
                        case 1
                    }
                    
                    break;
                case 2:
                    Console.WriteLine("Seu pedido é um Chá Verde no valor de 3,00 R$");
                    break;
                case 3:
                    Console.WriteLine("Seu pedido é um Suco Natural no valor de 8,00 R$");
                    break;
                case 4:
                    Console.WriteLine("Seu pedido é um Refrigerante de Limão no valor de 5,00 R$");
                    break;

            }
        }
    }
}

