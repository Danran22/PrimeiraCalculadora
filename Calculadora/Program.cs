using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu primeiro numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a expresão que vai ser usada (+, -, *, /, %): ");
            string exp = Console.ReadLine();

            Console.WriteLine("Digite seu primeiro numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            string adi = "+";
            string sub = "-";
            string mult = "*";
            string div = "/";
            string porc = "%";
            int result;

            if (exp == adi)
            {
                result = num1 + num2;
                Console.WriteLine($"O resultado é {result}");
            }
            else if (exp == sub) 
            {
                result = num1 - num2;
                Console.WriteLine($"O resultado é {result}");
            }
            else if (exp == mult)
            {
                result = num1 * num2;
                Console.WriteLine($"O resultado é {result}");
            }
            else if (exp == div)
            {
                result = num1 / num2;
                Console.WriteLine($"O resultado é {result}");
            }
            else if (exp == porc)
            {
                result = (num1 * num2) / 100;
                Console.WriteLine($"O resultado é {result}");
            }
            else
            {
                Console.WriteLine("Algo deu errado pvf tente novamnete");
            }
            Console.ReadLine();
        }
    }
}
