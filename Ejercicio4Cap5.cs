using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEjercicios
{
    public partial class Ejercicio4Cap5 : Form
    {
        public Ejercicio4Cap5()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            textFactorial.Text = string.Empty;
            textNumero.Text = string.Empty;
        }
        public void verificar(int n)
        {
            if (n < 0)
            {
                MessageBox.Show("\nError: No existe el factorial de un número negativo...\n","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Limpiar();
                return;
            }
        }
        public void Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            textFactorial.AppendText("\nEl Factorial de " + n + " es: " + fact);
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            verificar(Convert.ToInt32(textNumero.Text));
            Factorial(Convert.ToInt32(textNumero.Text));
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
