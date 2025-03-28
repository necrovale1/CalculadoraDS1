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
            this.KeyPreview = true; // Permite capturar teclas no formulário
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }

        private double currentResult = 0;  // Resultado acumulado da operação
        private string operation;
        private string input;
        List<double> values = new List<double>();  // Lista para armazenar os valores
        private double r = 0;
        private bool isNewOperation = true;
        private bool keyIsPressed = false;

        //keys
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyIsPressed)
            {
                switch (e.KeyCode)
                {
                    
                    case Keys.D0:
                        btn0.PerformClick();
                        btn0.BackColor = Color.Gray;
                        break;
                    case Keys.D1:
                        btn1.PerformClick();
                        btn1.BackColor = Color.Gray;
                        break;
                    case Keys.D2:
                        btn2.PerformClick();
                        btn2.BackColor = Color.Gray;
                        break;
                    case Keys.D3:
                        btn3.PerformClick();
                        btn3.BackColor = Color.Gray;
                        break;
                    case Keys.D4:
                        btn4.PerformClick();
                        btn4.BackColor = Color.Gray;
                        break;
                    case Keys.D5:
                        btn5.PerformClick();
                        btn5.BackColor = Color.Gray;
                        break;
                    case Keys.D6:
                        btn6.PerformClick();
                        btn6.BackColor = Color.Gray;
                        break;
                    case Keys.D7:
                        btn7.PerformClick();
                        btn7.BackColor = Color.Gray;
                        break;
                    case Keys.D8:
                        btn8.PerformClick();
                        btn8.BackColor = Color.Gray;
                        break;
                    case Keys.D9:
                        btn9.PerformClick();
                        btn9.BackColor = Color.Gray;
                        break;
                    case Keys.Oemplus when !e.Shift:
                        btnIgual.PerformClick();
                        btnIgual.BackColor = Color.Gray;
                        break;
                    case Keys.Oemplus:
                        btnSomar.PerformClick();
                        btnSomar.BackColor = Color.Gray;
                        break;
                    case Keys.OemMinus:
                        btnSubtrair.PerformClick();
                        btnSubtrair.BackColor = Color.Gray;
                        break;
                    case Keys.Add:
                        btnSomar.PerformClick();
                        btnSomar.BackColor = Color.Gray;
                        break;
                    case Keys.Subtract:
                        btnDividir.PerformClick();
                        btnDividir.BackColor = Color.Gray;
                        break;
                    case Keys.Multiply:
                        btnMultiplicar.PerformClick();
                        btnMultiplicar.BackColor = Color.Gray;
                        break;
                    case Keys.Divide:
                        btnDividir.PerformClick();
                        btnDividir.BackColor = Color.Gray;
                        break;
                    case Keys.C:
                        btnClear.PerformClick();
                        btnClear.BackColor = Color.Gray;
                        break;
                    case Keys.P:
                        btnPotencia.PerformClick();
                        btnPotencia.BackColor = Color.Gray;
                        break;
                    case Keys.Oemcomma:
                        btnVirgula.PerformClick();
                        btnVirgula.BackColor = Color.Gray;
                        break;
                    case Keys.Delete:
                        btnClear.PerformClick();
                        btnClear.BackColor = Color.Gray;
                        break;
                    case Keys.Back:
                        btnClear.BackColor = Color.Gray;
                        btnClear.PerformClick();
                        break;
                    case Keys.Enter:
                        btnIgual.PerformClick();
                        btnIgual.BackColor = Color.Gray;
                        break;
                    case Keys.NumPad0:
                        btn0.PerformClick();
                        btn0.BackColor = Color.Gray;
                        break;
                    case Keys.NumPad1:
                        btn1.PerformClick();
                        btn1.BackColor = Color.Gray;
                        break;
                    case Keys.NumPad2:
                        btn2.PerformClick();
                        btn2.BackColor = Color.Gray;
                        break;
                    case Keys.NumPad3:
                        btn3.PerformClick();
                        btn3.BackColor = Color.Gray;
                        break;
                    case Keys.NumPad4:
                        btn4.PerformClick();
                        btn4.BackColor = Color.Gray;
                        break;
                    case Keys.NumPad5:
                        btn5.PerformClick();
                        btn5.BackColor = Color.Gray;
                        break;
                    case Keys.NumPad6:
                        btn6.PerformClick();
                        btn6.BackColor = Color.Gray;
                        break;
                    case Keys.NumPad7:
                        btn7.PerformClick();
                        btn7.BackColor = Color.Gray;
                        break;
                    case Keys.NumPad8:
                        btn8.PerformClick();
                        btn8.BackColor = Color.Gray;
                        break;
                    case Keys.NumPad9:
                        btn9.PerformClick();
                        btn9.BackColor = Color.Gray;
                        break;              

                }
                keyIsPressed = true;

            }
                        
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           {
                switch (e.KeyCode)
                {
                    case Keys.D0:
                        btn0.PerformClick();
                        btn0.BackColor = Color.White;
                        break;
                    case Keys.D1:
                        btn1.PerformClick();
                        btn1.BackColor = Color.White;
                        break;
                    case Keys.D2:
                        btn2.PerformClick();
                        btn2.BackColor = Color.White;
                        break;
                    case Keys.D3:
                        btn3.PerformClick();
                        btn3.BackColor = Color.White;
                        break;
                    case Keys.D4:
                        btn4.PerformClick();
                        btn4.BackColor = Color.White;
                        break;
                    case Keys.D5:
                        btn5.PerformClick();
                        btn5.BackColor = Color.White;
                        break;
                    case Keys.D6:
                        btn6.PerformClick();
                        btn6.BackColor = Color.White;
                        break;
                    case Keys.D7:
                        btn7.PerformClick();
                        btn7.BackColor = Color.White;
                        break;
                    case Keys.D8:
                        btn8.PerformClick();
                        btn8.BackColor = Color.White;
                        break;
                    case Keys.D9:
                        btn9.PerformClick();
                        btn9.BackColor = Color.White;
                        break;
                    case Keys.Oemplus when !e.Shift:
                        btnIgual.PerformClick();
                        btnIgual.BackColor = Color.White;
                        break;
                    case Keys.Oemplus:
                        btnSomar.PerformClick();
                        btnSomar.BackColor = Color.White;
                        break;
                    case Keys.OemMinus:
                        btnSubtrair.PerformClick();
                        btnSubtrair.BackColor = Color.White;
                        break;
                    case Keys.Add:
                        btnSomar.PerformClick();
                        btnSomar.BackColor = Color.White;
                        break;
                    case Keys.Subtract:
                        btnDividir.PerformClick();
                        btnDividir.BackColor = Color.White;
                        break;
                    case Keys.Multiply:
                        btnMultiplicar.PerformClick();
                        btnMultiplicar.BackColor = Color.White;
                        break;
                    case Keys.Divide:
                        btnDividir.PerformClick();
                        btnDividir.BackColor = Color.White;
                        break;
                    case Keys.C:
                        btnClear.PerformClick();
                        btnClear.BackColor = Color.White;
                        break;
                    case Keys.P:
                        btnPotencia.PerformClick();
                        btnPotencia.BackColor = Color.White;
                        break;
                    case Keys.Oemcomma:
                        btnVirgula.PerformClick();
                        btnVirgula.BackColor = Color.White;
                        break;
                    case Keys.Delete:
                        btnClear.PerformClick();
                        btnClear.BackColor = Color.White;
                        break;
                    case Keys.Back:
                        btnClear.PerformClick();
                        btnClear.BackColor = Color.White;
                        break;
                    case Keys.Enter:
                        btnIgual.PerformClick();
                        btnIgual.BackColor = Color.White;
                        break;
                    case Keys.NumPad0:
                        btn0.PerformClick();
                        btn0.BackColor = Color.White;
                        break;
                    case Keys.NumPad1:
                        btn1.PerformClick();
                        btn1.BackColor = Color.White;
                        break;
                    case Keys.NumPad2:
                        btn2.PerformClick();
                        btn2.BackColor = Color.White;
                        break;
                    case Keys.NumPad3:
                        btn3.PerformClick();
                        btn3.BackColor = Color.White;
                        break;
                    case Keys.NumPad4:
                        btn4.PerformClick();
                        btn4.BackColor = Color.White;
                        break;
                    case Keys.NumPad5:
                        btn5.PerformClick();
                        btn5.BackColor = Color.White;
                        break;
                    case Keys.NumPad6:
                        btn6.PerformClick();
                        btn6.BackColor = Color.White;
                        break;
                    case Keys.NumPad7:
                        btn7.PerformClick();
                        btn7.BackColor = Color.White;
                        break;
                    case Keys.NumPad8:
                        btn8.PerformClick();
                        btn8.BackColor = Color.White;
                        break;
                    case Keys.NumPad9:
                        btn9.PerformClick();
                        btn9.BackColor = Color.White;
                        break;

                }
                keyIsPressed = false;
            }
        }
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
                    case "p":
                        currentResult = Math.Pow(currentNumber,2);
                        lblView.Text = currentResult.ToString();
                        break;
                }
            }
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

        private void mstpCalcRadio_Click(object sender, EventArgs e)
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

        private void simToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calcSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcSimples calcSimplesForm = new CalcSimples();
            calcSimplesForm.ShowDialog();
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!input.Contains(","))
            {
                input += ",";
                lblView.Text = input;
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                operation = "p";
                isNewOperation = false;
                ApplyOperation();
                                  input = "";
            }
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.PaleTurquoise;
            toolStrip1.BackColor = Color.SkyBlue;
            menuStrip1.BackColor = Color.SkyBlue;
            statusStrip1.BackColor = Color.PaleTurquoise;

        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightGreen;
            toolStrip1.BackColor = Color.MediumSeaGreen;
            menuStrip1.BackColor = Color.MediumSeaGreen;
            statusStrip1.BackColor = Color.LightGreen;

        }

        private void laranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.PeachPuff;
            toolStrip1.BackColor = Color.LightSalmon;
            menuStrip1.BackColor = Color.LightSalmon;
            statusStrip1.BackColor = Color.PeachPuff;
        }
    }
}