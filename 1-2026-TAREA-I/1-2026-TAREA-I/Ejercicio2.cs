using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_2026_TAREA_I
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double Valor;

            if (double.TryParse(txtValor.Text, out Valor))

                if (Valor > 0)
                {
                    MessageBox.Show("El número es mayor a 0");

                }

            if (Valor < 0)
            {
                MessageBox.Show("El número es menor a 0");
            }
            if (Valor == 0)
            {
                MessageBox.Show("El número es igual a 0");
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Hover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
    }
}
