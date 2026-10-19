using System;
using System.Windows.Forms;

namespace Unidad4.POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hayError = false;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre no puede estar vacío");
                hayError = true;
            }

            double precioTemp;
            if (!double.TryParse(txtPrecio.Text, out precioTemp) || precioTemp <= 0)
            {
                errorProvider1.SetError(txtPrecio, "Debe ser un número mayor que 0");
                hayError = true;
            }

            if (hayError) return;

            Producto miProducto = new Producto();
            miProducto.Nombre = txtNombre.Text;
            miProducto.Precio = precioTemp;

            MessageBox.Show(miProducto.MostrarInfo(), "Producto Guardado");
        }
    }
}