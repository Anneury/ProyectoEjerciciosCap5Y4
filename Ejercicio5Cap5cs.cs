using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEjercicios
{
    public partial class Ejercicio5Cap5cs : Form
    {
        public Ejercicio5Cap5cs()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            textNumero.Text = string.Empty;
            textNumeroConver.Text = string.Empty;
        }
        public void Convertir()
        {
            int value = Convert.ToInt32(textNumero.Text);
            if (value == 0) textNumeroConver.Text = "CERO";
            else if (value == 1) textNumeroConver.Text = "UNO";
            else if (value == 2) textNumeroConver.Text = "DOS";
            else if (value == 3) textNumeroConver.Text = "TRES";
            else if (value == 4) textNumeroConver.Text = "CUATRO";
            else if (value == 5) textNumeroConver.Text = "CINCO";
            else if (value == 6) textNumeroConver.Text = "SEIS";
            else if (value == 7) textNumeroConver.Text = "SIETE";
            else if (value == 8) textNumeroConver.Text = "OCHO";
            else if (value == 9) textNumeroConver.Text = "NUEVE";
            else if (value == 10) textNumeroConver.Text = "DIEZ";
            else if (value == 11) textNumeroConver.Text = "ONCE";
            else if (value == 12) textNumeroConver.Text = "DOCE";
            else if (value == 13) textNumeroConver.Text = "TRECE";
            else if (value == 14) textNumeroConver.Text = "CATORCE";
            else if (value == 15) textNumeroConver.Text = "QUINCE";
           
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            Convertir();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
