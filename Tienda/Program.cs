using System;
using System.Collections.Generic;
using static Tienda.Inventario;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            MostarProductos();

            List<string> codigosDeProductos = new List<string>();
            string[] arrai = new string[5];

            bool verResumenDeCompra = false;

            while (!verResumenDeCompra)
            {
                Console.WriteLine("SELECCIONE EL PRODUCTO A AGREGAR AL CARRITO O PULSE ENTER PARA VER RESUMEN DE COMPRA: ");

                string codigoAAgregar = Console.ReadLine();

                if (codigoAAgregar == "")
                {
                    verResumenDeCompra = true;
                }
                else
                {
                    codigosDeProductos.Add(codigoAAgregar);
                }
            }

            Inventario inventario = new Inventario();

            for (int i = 0; i < codigosDeProductos.Count; i++)
            {
                Producto productoEncontrado = inventario.VerificarBodega(codigosDeProductos[i]);

                Console.WriteLine("\n" + productoEncontrado?.Precio);
            }


        }

        static void MostarProductos()
        {
            Inventario inventario = new Inventario();

            Producto[] productos = inventario.ListarProductos();

            for (int i = 0; i < productos.Length; i++)
            {
                string codigoProducto = inventario.ObtenerCodigoDeProducto(productos[i].Nombre, i);

                Console.WriteLine(codigoProducto + ". " + productos[i].Nombre);
            }

        }





        static int Sumar()
        {
            int[] numeros = new int[] { 5, 2, 1 };

            int resultado = numeros[0];

            for (int i = 1; i < numeros.Length; i = i + 1)
            {
                resultado = resultado + numeros[i];
            }

            return resultado;
        }

    }
}
