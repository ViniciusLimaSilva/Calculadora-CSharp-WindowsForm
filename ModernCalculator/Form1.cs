using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCalculator
{
    public partial class Calculator : Form
    {

        string operador;
        double a = 0;
        bool validar = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbValorDigitado_Click(object sender, EventArgs e)
        {

        }

        private void btnNumerador_click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValorDigitado.Text = txtValorDigitado.Text + bt.Text;
        }

        private void btnLimpar_click(object sender, EventArgs e)
        {
            txtValorDigitado.Text = "";
            label3.Text = "";
            a = 0;
            validar = false;
        }

        private void btnSomar_click(object sender, EventArgs e)
        {
           

            if(validar == true)
            {
                a = a + Convert.ToDouble(txtValorDigitado.Text);
                
                label3.Text = Convert.ToString(a) + "+";
                txtValorDigitado.Text = "";
                operador = "+";
            }
            else
            {
                label3.Text = txtValorDigitado.Text + btnSoma.Text;
                a = Convert.ToDouble(txtValorDigitado.Text);
                txtValorDigitado.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btnMult_click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToDouble(txtValorDigitado.Text);
                label3.Text = Convert.ToString(a) + "x";
                txtValorDigitado.Text = "";
                operador = "x";
            }
            else
            {
                label3.Text = txtValorDigitado.Text + btnMult.Text;
                a = Convert.ToDouble(txtValorDigitado.Text);
                txtValorDigitado.Text = "";
                operador = "x";
                validar = true;
            }

        }

        private void btnDiv_click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToDouble(txtValorDigitado.Text);
                label3.Text = Convert.ToString(a) + "/";
                txtValorDigitado.Text = "";
                operador = "/";
            }
            else
            {
                label3.Text = txtValorDigitado.Text + btnDiv.Text;
                a = Convert.ToDouble(txtValorDigitado.Text);
                txtValorDigitado.Text = "";
                operador = "/";
                validar = true;
            }

        }

        private void btnSub_click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToDouble(txtValorDigitado.Text);
                label3.Text = Convert.ToString(a) + "-";
                txtValorDigitado.Text = "";
                operador = "-";
            }
            else
            {
                label3.Text = txtValorDigitado.Text + btnSub.Text;
                a = Convert.ToDouble(txtValorDigitado.Text);
                txtValorDigitado.Text = "";
                operador = "-";
                validar = true;
            }

        }

        private void btnResult_click(object sender, EventArgs e)
        {
            if(operador == "+")
            {
                label3.Text = label3.Text + txtValorDigitado.Text + "=";
                txtValorDigitado.Text = Convert.ToString(a + Convert.ToSingle(txtValorDigitado.Text));
            }
            else if (operador == "-")
            {
                label3.Text = label3.Text + txtValorDigitado.Text + "=";
                txtValorDigitado.Text = Convert.ToString(a - Convert.ToSingle(txtValorDigitado.Text));
            }
            else if (operador == "x")
            {
                label3.Text = label3.Text + txtValorDigitado.Text + "=";
                txtValorDigitado.Text = Convert.ToString(a * Convert.ToSingle(txtValorDigitado.Text));
            }
            else if (operador == "/")
            {
                label3.Text = label3.Text + txtValorDigitado.Text + "=";
                txtValorDigitado.Text = Convert.ToString(a / Convert.ToSingle(txtValorDigitado.Text));
            }

            label3.Text = "";
            
        }

        private void txtValorDigitado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            txtValorDigitado.Text = txtValorDigitado.Text + ",";

        }

        private void btnRaiz_click(object sender, EventArgs e)
        {

        }

        private void btnRD_click(object sender, EventArgs e)
        {

        }

        private void btnSen_click(object sender, EventArgs e)
        {

        }
    }
}
