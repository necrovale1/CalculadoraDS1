using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_DS1
{
    public partial class CalcSimples : Form
    {
        private double r = 0;
        private double a = 0;
        private double b = 0;
        public CalcSimples()
        {
            InitializeComponent();
        }
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CalcSimples_Load(object sender, EventArgs e)
        {
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txb1.Text);
            b = Convert.ToDouble(txb2.Text);

            r = a - b;

            btnResultado.Text = r.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txb1.Text);
            b = Convert.ToDouble(txb2.Text);

            r = a / b;

            btnResultado.Text = r.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnResultado.Text = "?";
            txb1.Text = "";
            txb2.Text = "";
            a = 0;
            b = 0;
            r = 0;
        }


        private void btnSomar_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txb1.Text);
            b = Convert.ToDouble(txb2.Text);

            r = a + b;

            btnResultado.Text = r.ToString();

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txb1.Text);
            b = Convert.ToDouble(txb2.Text);

            r = a * b;

            btnResultado.Text = r.ToString();

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
        }

        private void tspCalcRadio_Click(object sender, EventArgs e)
        {
            this.Hide();
            calcradio calcradio = new calcradio();
            calcradio.ShowDialog();
        }

        private void tspCalcPlus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
