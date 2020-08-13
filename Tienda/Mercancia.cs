using System;

namespace Tienda
{
        public class Mercancia
        {
                Producto[] productos = new Producto[5];
                productos[0] = new Producto { Nombre = "Camisa", Precio = 100000};
        }

        class Producto
        {
            public string Nombre { get; set; }
            public int Precio { get; set; }
            public bool Verificado { get; set; }
        }

        class Inventario
        {
            public int Categoria { get; set;}
            public int CantidadDeUnidades { get; set; }

            public void AgregarProducto( Producto productos)
            {
                var baseDeDatos = new List<Producto>();
                baseDeDatos.Add(productos);
            }
        }
}