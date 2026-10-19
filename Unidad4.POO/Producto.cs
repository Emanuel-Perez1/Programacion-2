namespace Unidad4.POO
{
    public class Producto
    {
        private string nombre = "";
        private double precio;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { if (value > 0) precio = value; }
        }

        public string MostrarInfo()
        {
            return $"Producto: {Nombre}\nPrecio: ${Precio}";
        }
    }
}