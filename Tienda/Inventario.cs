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
        public string VerificarBodega()
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
            
            Producto[] productos = new Producto[8];
            productos[0] = camisa;
            productos[1] = pantalon;
            productos[2] = gorra;
            productos[3] = zapatillas;
            productos[4] = chaqueta;

            return "camisa";
           
        }

        public class Producto
        {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public bool Verificado { get; set; }
        }

        
    }
    

     
}