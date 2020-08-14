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
        public string Bodega()
        {
            Producto camisa = new Producto();
            camisa.Nombre = "Camisa";
            camisa.Precio = 100000;
            camisa.Verificado = true;

            Producto[] productos = new Producto[3];
            productos[0] = camisa;

            return "Camisa";
        }

    }
    public class Producto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public bool Verificado { get; set; }
    }
}