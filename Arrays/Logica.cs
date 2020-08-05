using System;

namespace Arrays
{
    public class Logica
    {
        public int SumarArrays(int[] array)
        { 
            int suma = 0;
            int resultado = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Digite el valor: ");
                suma = Convert.ToInt32(Console.ReadLine());

                int numero = array[i];
                suma = numero + resultado; 
                resultado = numero;
            }
            
            return suma;
        }
    }
}