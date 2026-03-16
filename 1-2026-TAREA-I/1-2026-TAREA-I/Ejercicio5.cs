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
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Base, Altura, Multiplicacion, Division;

            Base  = Convert.ToDouble(txtBase.Text);
            Altura = Convert.ToDouble(txtAltura.Text);

            Multiplicacion  = Base *  Altura;

            Division = Multiplicacion / 2;

            txtResultado.Text = Division.ToString();
        }

        private void btn_Hover(object sender, EventArgs e)
        {
           Cursor = Cursors.Hand;
        }
    }
}
