using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite o primeiro numero:");
            //decimal num1 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Qual operação deseja fazer:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão\n");

            decimal operacao = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero:");
            decimal num1 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o segundo numero:");
            decimal num2 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            decimal resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = num1 + num2;
                        break;
                    }
                case 2:
                    {
                        resultado = num1 - num2;
                        break;
                    }
                case 3:
                    {
                        resultado = num1 * num2;
                        break;
                    }
                case 4:
                    {
                        resultado = num1 / num2;
                        break;
                    }
                default:
                    Console.WriteLine("Numero inválido, digite outro numero.");
                    break;
            }
            Console.WriteLine("O resultado da operação com os numeros {0} e o {1} é {2}: ", num1, num2, resultado);

            Console.ReadLine();
        }
    }
}
