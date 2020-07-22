using System;

namespace Tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resultado;

            Console.WriteLine("Digite el número: ");
            numero =  Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                Console.WriteLine(numero + " * " + i + " = " + resultado);

            }
        }
    }
}
