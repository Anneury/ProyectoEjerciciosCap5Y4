using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEjercicios
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Multiplicar(int num)
        {
            int tot = 0;
            for(int i=1;i<=10;i++)
            {
                tot *= i;
                textTabla.AppendText(i+"x"+num+"="+tot+"\t");
            }
        }
        public void Limpiar()
        {
            textNumero.Text = string.Empty;
            textTabla.Text = string.Empty;
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            Multiplicar(Convert.ToInt32(textNumero.Text));
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void textTabla_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
