using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la longitud del array: ");
            int  longitudArray;
            longitudArray = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[longitudArray];
        
            
            var obj = new Logica();

            int resultadoSuma = obj.SumarArrays(array);


            Console.WriteLine(resultadoSuma);
        }
    }
}
