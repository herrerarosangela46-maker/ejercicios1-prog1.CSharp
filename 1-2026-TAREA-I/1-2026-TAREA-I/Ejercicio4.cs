using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _1_2026_TAREA_I
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Valor = Convert.ToDouble(txtValor.Text);

            if (Valor < 0)
            {
                MessageBox.Show("Digite un numero positivo, por favor");
            }
            else
            {
                Math.Sqrt(Valor);

                txtResultado.Text =  Math.Sqrt(Valor).ToString();
            }

        }

        private void btn_Hover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
    }
}
