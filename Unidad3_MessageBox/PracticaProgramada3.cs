namespace Unidad3_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarDia_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDia.Text, out int numero))
            {
                MessageBox.Show("Por favor ingrese un número válido del 1 al 7.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            if (numero >= 1 && numero <= 7)
            {
                MessageBox.Show($"El día es: {dias[numero - 1]}", "Día de la semana", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El número ingresado no está entre 1 y 7.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarDia_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtDia.Text, out int dia))
            {
                string nombreDia;
                switch (dia)
                {
                    case 1: nombreDia = "Lunes"; break;
                    case 2: nombreDia = "Martes"; break;
                    case 3: nombreDia = "Miércoles"; break;
                    case 4: nombreDia = "Jueves"; break;
                    case 5: nombreDia = "Viernes"; break;
                    case 6: nombreDia = "Sábado"; break;
                    case 7: nombreDia = "Domingo"; break;
                    default:
                        MessageBox.Show("El número ingresado no está entre 1 y 7.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
                MessageBox.Show($"El día es {nombreDia}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}