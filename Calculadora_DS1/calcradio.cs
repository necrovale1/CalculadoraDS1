using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_DS1
{

    public partial class calcradio : Form
    {
        private double r = 0;
        private double a = 0;
        private double b = 0;
        private string c = "";

        public calcradio()
        {
            InitializeComponent();

        }

        private void calcradio_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdbSomar_CheckedChanged(object sender, EventArgs e)
        {
            c = "+";
        }

        private void rdbSubtrair_CheckedChanged(object sender, EventArgs e)
        {
            c = "-";
        }

        private void rdbMultiplicar_CheckedChanged(object sender, EventArgs e)
        {
            c = "*";
        }

        private void rdbDividir_CheckedChanged(object sender, EventArgs e)
        {
            c = "/";
        }

        private void rdbPotencia_CheckedChanged(object sender, EventArgs e)
        {
            c = "p";
        }
        private void txb1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            bool isValidA = double.TryParse(txb1.Text, out a);
            bool isValidB = double.TryParse(txb2.Text, out b);

            if (!isValidA || !isValidB)
            {
                MessageBox.Show("Valores Inválidos");
            }


            switch (c)
            {
                case "+":
                    r = a + b; break;

                case "-":
                    r = a - b; break;

                case "*":
                    r = a * b; break;

                case "/":
                    r = a / b; break;

                case "p":
                    r = Math.Pow(a, b); break;

                default:
                    break;
            }

            btnResultado.Text = r.ToString("F2");
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txb1.Text = "";
            txb2.Text = "";

            a = 0;
            b = 0;
            c = "";
            r = 0;

            rdbPotencia.Checked = false;
            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDividir.Checked = false;
            btnResultado.Text = "?";
          
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void lblLine_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void mstpCalcRadio_Click(object sender, EventArgs e)
        {
            this.Hide();
            calcradio calcradio = new calcradio();
            calcradio.ShowDialog();
        }

        private void tspCalcSimples_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcSimples calcSimples = new CalcSimples();    
            calcSimples.ShowDialog();
        }
    }
}
        