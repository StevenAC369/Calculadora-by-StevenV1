using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidad;
using Datos;
namespace Vista
{
    public partial class CalculadoraForm : Form
    {
        public CalculadoraForm()
        {
            InitializeComponent();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string numeros = operacione.Text;
            operacione.Text = numeros.Remove(numeros.Length - 1);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            resultado.ReadOnly = false;
            operacione.Text = "";
        }

        private void btn_residuo_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + "%";
        }

        private void bttn_dividir_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + "/";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + "2";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + "9";
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + "*";
        }

        private void btn_sumar_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + "+";
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + "-";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            operacione.Text = operacione.Text + ".";
        }
        public void AgregarDatos(string operacion)
        {
            char[] delimitadores = { '+', '-', '*', '/', '%' };
            List<double> numeros = new List<double>();
            numeros = operacion.Split(delimitadores).Select(double.Parse).ToList();

        }
        public void GuardaHistorial(string operacion, double resultado)
        {
            ListaBoxHistorial.Items.Add(operacion + " = " + resultado);
        }

        private void btn_igual_resultado_Click(object sender, EventArgs e)
        {
            if (operacione.Text == "")
            {
                MessageBox.Show("Ingrese una operación para calcular el resultado.");
                return;
            }
            resultado.ReadOnly = false;
            Coleccion coleccion = new Coleccion();
            coleccion.calcular_resultado(operacione.Text);
            Operadores operadores = new Operadores();
            resultado.Text = operadores.calcular(coleccion).ToString();
            GuardaHistorial(operacione.Text, operadores.calcular(coleccion));
            resultado.ReadOnly = true;
        }
    }
}
