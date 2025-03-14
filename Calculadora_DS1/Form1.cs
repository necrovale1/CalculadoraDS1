using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_DS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblView.Text = "";
        }

        private int click = 0;
        private string operation;
        private string input;

        double a = 0;
        double b = 0;
        double r = 0;


        //operações
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            a = double.Parse(input);
            operation = "/";
            lblView.Text = operation;
            input = "";
    
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            a = double.Parse(input);
            operation = "-";
            lblView.Text = operation;
            input = "";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            a = double.Parse(input);
            operation = "+";
            lblView.Text = operation;
            input = "";
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            a = double.Parse(input);
            operation = "*";
            lblView.Text = operation;
            input = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
           lblView.Text = "";

            switch (operation)
            {
                case "+":
                    b = double.Parse(input);
                    r = a + b;
                    lblView.Text = r.ToString();
                    break;

                case "-":
                    b = double.Parse(input);
                    r = a - b;
                    lblView.Text = r.ToString();
                    break;

                case "/":
                    b = double.Parse(input);
                    r = a / b;
                    lblView.Text = r.ToString();
                    break;

                case "*":
                    b = double.Parse(input);
                    r = a * b;
                    lblView.Text = r.ToString();
                    break;
            }
                input = "";
        }
        //botões
        private void btn0_Click(object sender, EventArgs e)
        {
           input = input + "0";
           lblView.Text = input.ToString();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            input = input + "1";
            lblView.Text = input.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            input = input + "2";
            lblView.Text = input.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input = input + "3";
            lblView.Text = input.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            input = input + "4";
            lblView.Text = input.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input = input + "5";
            lblView.Text = input.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input = input + "6";
            lblView.Text = input.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input = input + "7";
            lblView.Text = input.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input = input + "8";
            lblView.Text = input.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input = input + "9";
            lblView.Text = input.ToString();
        }

        //resultado
        private void label1_Click(object sender, EventArgs e)
        {
        }
        public void tbxResultado_TextChanged(object sender, EventArgs e)
        {
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void tspSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                e.Cancel = true;
            }                                      
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            tslDateHour.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void mstpCalcRadio_Click(object sender, EventArgs e )
        {
            this.Hide();
            calcradio calcRadioForm = new calcradio();
            calcRadioForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input = "";
            lblView.Text = "";
            operation = "";
            
        }
    }
}
