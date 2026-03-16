using System.Drawing;

namespace _1_2026_TAREA_I
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double ValorA, ValorB, Division;



            ValorA  = Convert.ToDouble(txtValorA.Text);
            ValorB = Convert.ToDouble(txtValorB.Text);

            if (ValorB == 0)
            {
                MessageBox.Show("Digite un valor que no sea cero, por favor");
            }

            else
            {
                Division = ValorA / ValorB;

                txtResultado.Text =  Division.ToString();
            }
        }

        private void result_hover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
    }
}
