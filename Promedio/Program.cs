using System;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la primera nota:");
            decimal notaUno = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite la segunda nota:");
            decimal notaDos = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite la tercera nota:");
            decimal notaTres = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite la cuarta nota:");
            decimal notaCuatro = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite la quinta nota:");
            decimal notaCinco = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Su nota final es: ");
            decimal resultadoSuma = notaUno + notaDos + notaTres + notaCuatro + notaCinco;
            decimal resultadoDivision = resultadoSuma / 5;
            Console.WriteLine(resultadoDivision);

            if(resultadoDivision == 5)
            {
                Console.WriteLine("Excelente");
            }

            else if(resultadoDivision > 2.9m && resultadoDivision < 5)
            {
                Console.WriteLine("Aprobé");
            }

            else
            {
                Console.WriteLine("Reprobe");
            }
        }
    }
}
