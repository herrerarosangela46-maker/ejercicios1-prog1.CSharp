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
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void btn_Convertir_Click(object sender, EventArgs e)
        {
            double valor;

           if (!double.TryParse(txt_valor.Text, out valor))
           
       
            {
                MessageBox.Show("Ingrese un número válido");
            }

           if (btn_Fahrenheit.Checked)
            {
                double Fahrenheit = (valor * 9 / 5) + 32;
                    txt_Resultado.Text = Fahrenheit.ToString("F2");
            }
            else if (btn_Celsius.Checked)
            {
                double Celsius = (valor - 32) * 5 / 9;
                txt_Resultado.Text = Celsius.ToString("F2");
            }



        }
    }
}
