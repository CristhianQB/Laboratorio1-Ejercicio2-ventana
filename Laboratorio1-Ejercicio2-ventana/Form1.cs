using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio1_Ejercicio2_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mnts = int.Parse(txtb.Text);
            if (mnts % 60 == 0)
            {
                int horas = mnts / 60;
                lbl3.Text = horas + " horas";
            }
            else
            {
                int minutos = mnts % 60;
                int horas = mnts / 60;
                lbl3.Text = horas + " horas y " + minutos + " minutos";
            }
        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
