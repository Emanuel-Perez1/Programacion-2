using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Unidad2_CShard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumero1.Text, out int n1) || !int.TryParse(txtNumero2.Text, out int n2))
            {
                MessageBox.Show("Ingresa solo números");
                return;
            }

            if (n1 == n2) MessageBox.Show("Son iguales");
            else if (n1 > n2) MessageBox.Show($"{n1} es mayor que {n2}");
            else MessageBox.Show($"{n2} es mayor que {n1}");

        }

        private void listBoxColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxColores.SelectedItem == null) return;

            switch (listBoxColores.SelectedItem.ToString())
            {
                case "Rojo": this.BackColor = System.Drawing.Color.Red; break;
                case "Verde": this.BackColor = System.Drawing.Color.Green; break;
                case "Azul": this.BackColor = System.Drawing.Color.Blue; break;
                case "Amarillo": this.BackColor = System.Drawing.Color.Yellow; break;
                case "Negro": this.BackColor = System.Drawing.Color.Black; break;
                case "Blanco": this.BackColor = System.Drawing.Color.White; break;
            }
        }
    }
}