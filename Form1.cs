using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEjercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Capitulo4_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio = new Ejercicio1();
            ejercicio.Show();
        }

        private void Ejercicio2_Click(object sender, EventArgs e)
        {
            Ejercicio2 ejercicio = new Ejercicio2();
            ejercicio.Show();
        }

        private void Ejercicio4_Click(object sender, EventArgs e)
        {
            Ejercicio4Cap5 ejercicio = new Ejercicio4Cap5();
            ejercicio.Show();
        }

        private void Ejercicio5_Click(object sender, EventArgs e)
        {
            Ejercicio5Cap5cs ejercicio = new Ejercicio5Cap5cs();
            ejercicio.Show();
        }
    }
}
