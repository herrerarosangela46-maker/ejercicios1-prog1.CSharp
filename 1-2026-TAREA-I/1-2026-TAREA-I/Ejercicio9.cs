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
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void btn_Ver_Click(object sender, EventArgs e)
        {

            switch (txtCiudad.Text)

            {
                case "1":
                    MessageBox.Show($"La ciudad elegida es Distrito Nacional"); break;

                case "2":
                    MessageBox.Show($"La ciudad elegida es El Seibo"); break;

                case "3":
                    MessageBox.Show($"La ciudad elegida es Santiago"); break;

                case "4":
                    MessageBox.Show($"La ciudad elegida es San Juan de la Maguana"); break;

                case "5":
                    MessageBox.Show($"La ciudad elegida es La Romana"); break;

                case "6":
                    MessageBox.Show($"La ciudad elegida es Barahona"); break;

                case "7":
                    MessageBox.Show($"La ciudad elegida es Montecristi"); break;

                case "8":
                    MessageBox.Show($"La ciudad elegida es Maria Trinidad Sanchez"); break;

                case "9":
                    MessageBox.Show($"La ciudad elegida es Santa Barbara de Samana"); break;

                case "10":
                    MessageBox.Show($"La ciudad elegida es Pedernales"); break;

                default: MessageBox.Show($"Digite un número del 1 al 10, por favor"); break;

            }



        }

        private void Ejercicio9_Load(object sender, EventArgs e)
        {

        }

        private void btn_Hover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
    }
}
