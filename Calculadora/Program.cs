﻿using System;
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

            expre();
            string exp = Console.ReadLine();

            Console.WriteLine("Digite seu segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

                if (exp == "/" && num2 == 0)
                {
                Console.WriteLine("Não é possivel dividir por 0");
                }

                float result = 0;

                    switch (exp) 
                    {
                        case "+":
                        result = num1 + num2;
                        Console.WriteLine($"O Resultado é {result}");
                        break;
                        case "-":
                        result = num1 - num2;
                        Console.WriteLine($"O Resultado é {result}");
                        break;
                        case "*":
                        result = num1 * num2;
                        Console.WriteLine($"O Resultado é {result}");
                        break;
                        case "/":
                        result = (float) num1 / num2;
                        Console.WriteLine($"O Resultado é {result}");
                        break;
                        case "%":
                        result = (num1 * num2) / 100;
                        Console.WriteLine($"O Resultado é {result}");
                        break;
                     }
        }
        static void expre()
        {
            Console.WriteLine
            (@"Digite a expresão que vai ser usada 
            adição (+)
            Subitração (-)
            Multiplicação (*)
            Divisão (/)
            Porcetagem (%)");
        }
    }
}
