using System;

namespace Tienda
{
    public class Mercancia
    {
        string[] productos = new string[5] {"Camisa", "Pantalon", "Medias", "Chaqueta", "Guantes"};
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
    }

}