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

        private double currentResult = 0;  // Resultado acumulado da operação
        private string operation;
        private string input;
        List<double> values = new List<double>();  // Lista para armazenar os valores
        private double r = 0;
        private bool isNewOperation = true;


        //operações
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                ApplyOperation();  // Aplica a operação anterior se existir
                operation = "/";
                lblView.Text = operation;
                input = "";
                isNewOperation = false;
            }
        }


        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                ApplyOperation();  // Aplica a operação anterior se existir
                operation = "-";
                lblView.Text = operation;
                input = "";
                isNewOperation = false;
            }
        }


        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                ApplyOperation();  // Aplica a operação anterior se existir
                operation = "+";
                lblView.Text = operation;
                input = "";
                isNewOperation = false;
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                ApplyOperation();  // Aplica a operação anterior se existir
                operation = "*";
                lblView.Text = operation;
                input = "";
                isNewOperation = false;
            }
        }


        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                ApplyOperation();  // Aplica a operação no último número
            }

            lblView.Text = currentResult.ToString();  // Exibe o resultado
            operation = "";  // Reseta a operação
            input = "";  // Limpa o campo de entrada
            isNewOperation = true;  // A partir daqui, pode-se iniciar uma nova operação
        }

        // Método para aplicar a operação no último número inserido
        private void ApplyOperation()
        {
            double currentNumber = double.Parse(input);

            if (isNewOperation)
            {
                currentResult = currentNumber; // Primeiro número
            }
            else
            {
                switch (operation)
                {
                    case "+":
                        currentResult += currentNumber;
                        break;
                    case "-":
                        currentResult -= currentNumber;
                        break;
                    case "*":
                        currentResult *= currentNumber;
                        break;
                    case "/":
                        if (currentNumber != 0)
                        {
                            currentResult /= currentNumber;
                        }
                        else
                        {
                            lblView.Text = "Erro: Divisão por zero!";
                            currentResult = 0;
                        }
                        break;
                }
            }

            input = "";  // Limpa o campo de entrada para o próximo número
        }
    
        //botões
        private void btn0_Click(object sender, EventArgs e)
        {
           input += "0";
           lblView.Text = input;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            input += "1";
            lblView.Text = input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            input += "2";
            lblView.Text = input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input += "3";
            lblView.Text = input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            input += "4";
            lblView.Text = input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input += "5";
            lblView.Text = input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input += "6";
            lblView.Text = input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input += "7";
            lblView.Text = input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input += "8";
            lblView.Text = input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input += "9";
            lblView.Text = input;
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

        private void button1_Click(object sender, EventArgs e) // C - clear
        {
            input = "";
            lblView.Text = "";
            operation = "";
            currentResult = 0;
            isNewOperation = true;
        }
    }
}
