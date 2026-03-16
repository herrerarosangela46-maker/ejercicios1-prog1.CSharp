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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double ValorA, ValorB, ValorC;

            bool parsedA = double.TryParse(txt_ValorA.Text, out ValorA);
            bool parsedB = double.TryParse(txt_ValorB.Text, out ValorB);
            bool parsedC = double.TryParse(txt_ValorC.Text, out ValorC);

            if (parsedA && parsedB && parsedC)
            {
                if (ValorA > ValorB && ValorA > ValorC)
                {
                    MessageBox.Show("El valor A es el mayor");

                }

                else if (ValorB > ValorC && ValorB > ValorA)
                {
                    MessageBox.Show("El valor B es el mayor");
                }
                else if (ValorC > ValorB && ValorC > ValorA)
                {
                    MessageBox.Show("El valor C es el mayor");
                }
                else
                {
                    MessageBox.Show("Los valores son iguales");
                }
            }

            else
            {
                MessageBox.Show("Ingresar valores validos, por favor");
            }
        }

        private void btn_Hover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
    }
}
