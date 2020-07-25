using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[2];
            array[0] = 2;
            array[1] = 6;
            
            var obj = new Logica();

            int resultadoSuma = obj.SumarArrays(array);


            Console.WriteLine(resultadoSuma);
        }
    }
}
