using System;

namespace Tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Tabla de multiplicar del {0}", i);
               
				for (int j = 1; j <= 10; j++)
				{
					Console.WriteLine("{0} * {1} = {2}", i, j, (i * j));
				}   
            }
           
        }
    }
}
