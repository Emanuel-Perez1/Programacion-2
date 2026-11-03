using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad5_Capas.BLL;
using Unidad5_Capas.DAL;
namespace Unidad5_Capas.UIL
{
    public partial class Form1 : Form
    {
        private ProductoService productoService;
        List<Producto> productos = new List<Producto>();
        public Form1()
        {
            InitializeComponent();
            productoService = new ProductoService();
        }
        private void btnCargar_Click (object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productoService.ObtenerProductos();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = "";
           // lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH: mm: ss");
           dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
           dataGridView1.DataSource = productos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar producto
            productos.Add(new Producto
            {
                Nombre = txtNombre.Text,
                Precio = decimal.Parse(txtPrecio.Text)
            });
            //Refrescar DataGridView
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = productos;

            //Actualizar fecha y hora
            lblFecha.Text = "Ultimo registro " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
