namespace Unidad3_MessageBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDia = new TextBox();
            btnMostrarDia = new Button();
            SuspendLayout();
            // 
            // txtDia
            // 
            txtDia.Location = new Point(363, 48);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 0;
            txtDia.TextChanged += txtDia_TextChanged;
            // 
            // btnMostrarDia
            // 
            btnMostrarDia.Location = new Point(349, 96);
            btnMostrarDia.Name = "btnMostrarDia";
            btnMostrarDia.Size = new Size(114, 38);
            btnMostrarDia.TabIndex = 1;
            btnMostrarDia.Text = "Mostrar Dia";
            btnMostrarDia.UseVisualStyleBackColor = true;
            btnMostrarDia.Click += btnMostrarDia_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrarDia);
            Controls.Add(txtDia);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDia;
        private Button btnMostrarDia;
    }
}
