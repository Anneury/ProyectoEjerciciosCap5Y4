using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEjercicios
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            textExponente.Text = string.Empty;
            textNumerador.Text = string.Empty;
            textResultado.Text = string.Empty;
        }
        public void Potencia()
        {
            double num = Convert.ToDouble(textNumerador.Text), exp = Convert.ToDouble(textExponente.Text);
            double resultado = 0;

            resultado = Math.Pow(num, exp);
            textResultado.Text = Convert.ToString(resultado);
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            Potencia();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
