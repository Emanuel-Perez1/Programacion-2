using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Unidad5_Capas.DAL;

namespace Unidad5_Capas.BLL
{
    internal class ProductoService
    {
        // Lista simulada de productos
        private List<Producto> productos;
        public ProductoService()
        {
            productos = new List<Producto>()
        {
                new Producto { Nombre = "Laptop", Precio = 1200 },
                new Producto { Nombre = "Mouse", Precio = 25 },
                new Producto { Nombre = "Teclado", Precio = 75 },
                new Producto { Nombre = "Monitor" , Precio = 300 },

        };
        }
        // Metodo para obtener prodcutos
        public List<Producto> ObtenerProductos()
        {
            return productos;
        }
    }
}
