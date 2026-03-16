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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int Numero;

            if (int.TryParse(txtNumero.Text, out Numero))

                if (Numero % 2 == 0)
                {
                    MessageBox.Show("El número es par");

                }

                else
                {
                    MessageBox.Show("El número es impar");
                }

            else
            {
                MessageBox.Show("Ingrese un número válido");
            }

        }

        private void Ejercicio7_Load(object sender, EventArgs e)
        {

        }

        private void btn_Hover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
    }
}
