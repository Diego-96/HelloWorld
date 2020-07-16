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
            
            Producto[] productos = new Producto[5];
            productos[0] = new Producto { Nombre = "Camisa", Precio = 100000 };
        }
    }

    class Producto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
    }
}

