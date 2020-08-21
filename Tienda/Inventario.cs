using System;
using System.Collections.Generic;

namespace Tienda
{

    public class Inventario
    {
        public int categoria { get; set; }
        public int catidadUnidades { get; set; }

        public void AgregarProducto(Producto productos)
        {
            var baseDatos = new List<Producto>();
            baseDatos.Add(productos);
        }
        public string Bodega(string Nombre)
        {
            Producto camisa = new Producto();
            camisa.Nombre = "Camisa";
            camisa.Precio = 100000;
            camisa.Verificado = true;

            Producto pantalon = new Producto();
            pantalon.Nombre = "Pantalón";
            pantalon.Precio = 90000;
            pantalon.Verificado = true;

            Producto gorra = new Producto();
            gorra.Nombre = "Gorra";
            gorra.Precio = 50000;
            gorra.Verificado = true;

            Producto zapatillas = new Producto();
            zapatillas.Nombre = "Zapatillas";
            zapatillas.Precio = 250800;
            zapatillas.Verificado = true;

            Producto chaqueta = new Producto();
            chaqueta.Nombre = "Chaqueta";
            chaqueta.Precio = 300000;
            chaqueta.Verificado = true;

            Producto botas = new Producto();
            botas.Nombre = "Botas";
            botas.Precio = 150000;
            botas.Verificado = false;

            Producto bufanda = new Producto();
            bufanda.Nombre = "Bufanda";
            bufanda.Precio = 50000;
            bufanda.Verificado = false;

            Producto gafas = new Producto();
            gafas.Nombre = "Gafas";
            gafas.Precio = 65000;
            gafas.Verificado = false;
            
            Producto[] productos = new Producto[8];
            productos[0] = camisa;
            productos[1] = pantalon;
            productos[2] = gorra;
            productos[3] = zapatillas;
            productos[4] = chaqueta;
            productos[5] = botas;
            productos[6] = bufanda;
            productos[7] = gafas;

            return Nombre;
        }

        public class Producto
        {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public bool Verificado { get; set; }
        }

        public bool ProductoVerificado(bool Verificado)
        {
            bool productoVerificado = true;

            if(productoVerificado == true)
            {
                productoVerificado = true;
                Console.WriteLine("Este producto se encuentra verificado");
            }

            else
            {
                Console.WriteLine("Este producto no se encuentra verificado");
            }

            return productoVerificado;
        }
    }
    

     
}