namespace Calculadora_DS1
{
    partial class calcradio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbSomar = new System.Windows.Forms.RadioButton();
            this.rdbSubtrair = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rdbDividir = new System.Windows.Forms.RadioButton();
            this.rdbPotencia = new System.Windows.Forms.RadioButton();
            this.lblOperacoes = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbSomar
            // 
            this.rdbSomar.AutoSize = true;
            this.rdbSomar.Location = new System.Drawing.Point(54, 68);
            this.rdbSomar.Name = "rdbSomar";
            this.rdbSomar.Size = new System.Drawing.Size(81, 24);
            this.rdbSomar.TabIndex = 0;
            this.rdbSomar.TabStop = true;
            this.rdbSomar.Text = "Somar";
            this.rdbSomar.UseVisualStyleBackColor = true;
            this.rdbSomar.CheckedChanged += new System.EventHandler(this.rdbSomar_CheckedChanged);
            // 
            // rdbSubtrair
            // 
            this.rdbSubtrair.AutoSize = true;
            this.rdbSubtrair.Location = new System.Drawing.Point(54, 98);
            this.rdbSubtrair.Name = "rdbSubtrair";
            this.rdbSubtrair.Size = new System.Drawing.Size(90, 24);
            this.rdbSubtrair.TabIndex = 1;
            this.rdbSubtrair.TabStop = true;
            this.rdbSubtrair.Text = "Subtrair";
            this.rdbSubtrair.UseVisualStyleBackColor = true;
            this.rdbSubtrair.CheckedChanged += new System.EventHandler(this.rdbSubtrair_CheckedChanged);
            // 
            // rdbMultiplicar
            // 
            this.rdbMultiplicar.AutoSize = true;
            this.rdbMultiplicar.Location = new System.Drawing.Point(54, 128);
            this.rdbMultiplicar.Name = "rdbMultiplicar";
            this.rdbMultiplicar.Size = new System.Drawing.Size(104, 24);
            this.rdbMultiplicar.TabIndex = 2;
            this.rdbMultiplicar.TabStop = true;
            this.rdbMultiplicar.Text = "Multiplicar";
            this.rdbMultiplicar.UseVisualStyleBackColor = true;
            this.rdbMultiplicar.CheckedChanged += new System.EventHandler(this.rdbMultiplicar_CheckedChanged);
            // 
            // rdbDividir
            // 
            this.rdbDividir.AutoSize = true;
            this.rdbDividir.Location = new System.Drawing.Point(54, 158);
            this.rdbDividir.Name = "rdbDividir";
            this.rdbDividir.Size = new System.Drawing.Size(76, 24);
            this.rdbDividir.TabIndex = 3;
            this.rdbDividir.TabStop = true;
            this.rdbDividir.Text = "Dividir";
            this.rdbDividir.UseVisualStyleBackColor = true;
            this.rdbDividir.CheckedChanged += new System.EventHandler(this.rdbDividir_CheckedChanged);
            // 
            // rdbPotencia
            // 
            this.rdbPotencia.AutoSize = true;
            this.rdbPotencia.Location = new System.Drawing.Point(54, 188);
            this.rdbPotencia.Name = "rdbPotencia";
            this.rdbPotencia.Size = new System.Drawing.Size(122, 24);
            this.rdbPotencia.TabIndex = 4;
            this.rdbPotencia.TabStop = true;
            this.rdbPotencia.Text = "Potenciação";
            this.rdbPotencia.UseVisualStyleBackColor = true;
            this.rdbPotencia.CheckedChanged += new System.EventHandler(this.rdbPotencia_CheckedChanged);
            // 
            // lblOperacoes
            // 
            this.lblOperacoes.AutoSize = true;
            this.lblOperacoes.Location = new System.Drawing.Point(69, 27);
            this.lblOperacoes.Name = "lblOperacoes";
            this.lblOperacoes.Size = new System.Drawing.Size(87, 20);
            this.lblOperacoes.TabIndex = 5;
            this.lblOperacoes.Text = "Operações";
            this.lblOperacoes.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(36, 244);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(94, 40);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(136, 244);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(94, 40);
            this.btnLimpa.TabIndex = 7;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.Location = new System.Drawing.Point(405, 244);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(94, 40);
            this.btnVolta.TabIndex = 8;
            this.btnVolta.Text = "Voltar";
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(280, 66);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(169, 26);
            this.txb1.TabIndex = 9;
            this.txb1.TextChanged += new System.EventHandler(this.txb1_TextChanged);
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(280, 98);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(169, 26);
            this.txb2.TabIndex = 10;
            this.txb2.TextChanged += new System.EventHandler(this.txb2_TextChanged);
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(276, 132);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(180, 20);
            this.lblLine.TabIndex = 11;
            this.lblLine.Text = "___________________";
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(293, 174);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(139, 38);
            this.btnResultado.TabIndex = 12;
            this.btnResultado.Text = "?";
            this.btnResultado.UseVisualStyleBackColor = true;
            // 
            // calcradio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(531, 296);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblOperacoes);
            this.Controls.Add(this.rdbPotencia);
            this.Controls.Add(this.rdbDividir);
            this.Controls.Add(this.rdbMultiplicar);
            this.Controls.Add(this.rdbSubtrair);
            this.Controls.Add(this.rdbSomar);
            this.Name = "calcradio";
            this.Text = "calcradio";
            this.Load += new System.EventHandler(this.calcradio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbSomar;
        private System.Windows.Forms.RadioButton rdbSubtrair;
        private System.Windows.Forms.RadioButton rdbMultiplicar;
        private System.Windows.Forms.RadioButton rdbDividir;
        private System.Windows.Forms.RadioButton rdbPotencia;
        private System.Windows.Forms.Label lblOperacoes;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Button btnResultado;
    }
}