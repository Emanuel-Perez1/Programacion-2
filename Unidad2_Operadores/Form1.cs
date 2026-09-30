using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad2_Operadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtEdad.text,out int edad))
            {
                if (edad >= 18)
                {
                    MessageBox.Show("Eres mayor de edad.");
                }
                else
                {
                    MessageBox.Show("Eres menor de edad.");
                }
            }
            else
            { MessageBox.Show("Por favor, ingrese un numero valido.");
            

         