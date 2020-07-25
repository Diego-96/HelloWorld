using System;

namespace Registro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la cantidad de números:");
            int cantidadNumeros = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[cantidadNumeros];

            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine("Digite un número");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int numeroMayor = numeros[0];
            int numeroMenor = numeroMayor;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                if (numeroMayor > numeros[i])
                {
                    numeroMenor = numeros[i];
                }
                else
                {
                    numeroMayor = numeros[i];
                }
            }

            MostrarResultado(numeroMayor, numeroMenor);
        }

        static void MostrarResultado(int numeroMayor, int numeroMenor)
        {
            Console.WriteLine($"El número mayor es: {numeroMayor}");
            Console.WriteLine($"El número menor es: {numeroMenor}");
        }
    }
}
