using System;

namespace Tienda
{

    public class Mercancia
    {
        string[] productos = new string[5] {"Camisa", "Pantalon", "Medias", "Chaqueta", "Guantes"};

        Inventario i = new Inventario();
        int i;

        Productos c = new Productos();
        c.Nombre = "Camisa";
        i.AgregarProducto(c);
    }

    class Productos
    {
        public string Nombre { get; set;}
        public int Precio { get; set; }
        public bool Verificado { get; set; }
    }

    class Inventario
    {
        public int categoria { get; set; }
        public int catidadUnidades { get; set; }

        public void AgregarProducto(Productos productos)
        {
            var baseDatos = new List<Productos>();
            baseDatos.Add(productos);
        }
    }

}