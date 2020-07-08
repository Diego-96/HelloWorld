using System;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int notaUno = Convert.ToInt32(Console.ReadLine());
            int notaDos = Convert.ToInt32(Console.ReadLine());
            int notaTres = Convert.ToInt32(Console.ReadLine());
            int notaCuatro = Convert.ToInt32(Console.ReadLine());
            int notaCinco = Convert.ToInt32(Console.ReadLine());

            int resultadoSuma = notaUno + notaDos + notaTres + notaCuatro + notaCinco;
            int resultadoDivision = resultadoSuma / 5;

            if(resultadoDivision == 5)
            {
                Console.WriteLine("Excelente");
            }

            else if(resultadoDivision > 2.9 && resultadoDivision < 5)
            {
                Console.WriteLine("Aprobe");
            }

            else
            {
                Console.WriteLine("Reprobe");
            }
        }
    }
}
