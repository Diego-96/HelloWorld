using System;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayDeEnteros = new int[3];

            arrayDeEnteros[0] = 0;
            arrayDeEnteros[1] = 100;
            arrayDeEnteros[2] = 2;

            Console.WriteLine(arrayDeEnteros[1]);



            string[] arrayString = new string[6];

            arrayString[0] = "Sergio";
            arrayString[1] = "Diego";
            arrayString[2] = "Angie";
            arrayString[3] = "Daniela";
            arrayString[4] = "Katerin";
            arrayString[5] = "Alejandra";

            int longitudDelArray = arrayString.Length;

            
            for (int i = 0; i < longitudDelArray; i++)
            {

                if(arrayString[i] == "Angie" || arrayString[i] == "Diego")
                {
                    Console.WriteLine(arrayString[i]);
                }
            }   

            int[] array = new int[1];  
            string[] array2 = new string[1]; 

            string nombre = "Diego";
            string apellido = "Puentes";
            string nombreCompleto = nombre + " " +  apellido;
            string nombreCompletoDos = $"\n{nombre} {apellido}";
            Console.Write(nombreCompleto + nombreCompletoDos);

            /*
                Diego Puentes
                Diego Puentes
            */
            
            /*int numeroUno = 4;
            int numeroDos = 6;
            int resultado = 0;

            if(numeroUno > numeroDos)
            {
                resultado = 1;

            }
            else if (numeroUno > numeroDos && numeroUno > 0)
            {
                
            }
            else
            {
                resultado = 0;
            }
            */


            
        }
    }

    

    
}

