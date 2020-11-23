using System.Collections.Generic;

namespace Tienda
{

    public class Inventario
    {
        public int categoria { get; set; }
        public int catidadUnidades { get; set; }

        public void AgregarProducto(Producto producto)
        {
            var baseDatos = new List<Producto>();
            baseDatos.Add(producto);
        }

        public Producto[] ListarProductos()
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

            Producto[] productos = new Producto[5];
            productos[0] = camisa;
            productos[1] = pantalon;
            productos[2] = gorra;
            productos[3] = zapatillas;
            productos[4] = chaqueta;

            return productos;
        }

        public Producto VerificarBodega(string codigoProductoABuscar)
        {
            Producto[] productos = ListarProductos();

            for (int i = 0; i < productos.Length; i++)
            {
                string codigoProducto = ObtenerCodigoDeProducto(productos[i].Nombre, i);

                if (codigoProducto == codigoProductoABuscar)
                {
                    // encontramos el producto
                    if (productos[i].Verificado == true)
                    {
                        // producto verificado
                        return productos[i];
                    }
                }
            }

            return null;
        }

        public string ObtenerCodigoDeProducto(string nombreProducto, int consecutivo)
        {
            consecutivo++;
            string codigoProducto = nombreProducto.Substring(0, 1) + (consecutivo).ToString();
            return codigoProducto;
        }

        public class Producto
        {
            public string Nombre { get; set; }
            public int Precio { get; set; }
            public bool Verificado { get; set; }
        }


    }



}