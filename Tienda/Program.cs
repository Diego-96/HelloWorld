using System;
using static Tienda.Inventario;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();

            Producto productoVerificado = inventario.VerificarBodega("Camisa");

            int? precio = productoVerificado?.Precio;

            Console.WriteLine(precio);
        }
    }
}
