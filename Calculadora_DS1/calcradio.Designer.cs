namespace Calculadora_DS1
{
    partial class calcradio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tspCalcPlus = new System.Windows.Forms.ToolStripMenuItem();
            this.tspCalcSimples = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbSomar
            // 
            this.rdbSomar.AutoSize = true;
            this.rdbSomar.Checked = true;
            this.rdbSomar.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbSomar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSomar.Location = new System.Drawing.Point(21, 90);
            this.rdbSomar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbSomar.Name = "rdbSomar";
            this.rdbSomar.Size = new System.Drawing.Size(78, 24);
            this.rdbSomar.TabIndex = 0;
            this.rdbSomar.TabStop = true;
            this.rdbSomar.Text = "Somar";
            this.rdbSomar.UseVisualStyleBackColor = true;
            this.rdbSomar.CheckedChanged += new System.EventHandler(this.rdbSomar_CheckedChanged);
            // 
            // rdbSubtrair
            // 
            this.rdbSubtrair.AutoSize = true;
            this.rdbSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSubtrair.Location = new System.Drawing.Point(21, 120);
            this.rdbSubtrair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbSubtrair.Name = "rdbSubtrair";
            this.rdbSubtrair.Size = new System.Drawing.Size(90, 24);
            this.rdbSubtrair.TabIndex = 1;
            this.rdbSubtrair.Text = "Subtrair";
            this.rdbSubtrair.UseVisualStyleBackColor = true;
            this.rdbSubtrair.CheckedChanged += new System.EventHandler(this.rdbSubtrair_CheckedChanged);
            // 
            // rdbMultiplicar
            // 
            this.rdbMultiplicar.AutoSize = true;
            this.rdbMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMultiplicar.Location = new System.Drawing.Point(21, 149);
            this.rdbMultiplicar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbMultiplicar.Name = "rdbMultiplicar";
            this.rdbMultiplicar.Size = new System.Drawing.Size(107, 24);
            this.rdbMultiplicar.TabIndex = 2;
            this.rdbMultiplicar.Text = "Multiplicar";
            this.rdbMultiplicar.UseVisualStyleBackColor = true;
            this.rdbMultiplicar.CheckedChanged += new System.EventHandler(this.rdbMultiplicar_CheckedChanged);
            // 
            // rdbDividir
            // 
            this.rdbDividir.AutoSize = true;
            this.rdbDividir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDividir.Location = new System.Drawing.Point(23, 178);
            this.rdbDividir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDividir.Name = "rdbDividir";
            this.rdbDividir.Size = new System.Drawing.Size(75, 24);
            this.rdbDividir.TabIndex = 3;
            this.rdbDividir.Text = "Dividir";
            this.rdbDividir.UseVisualStyleBackColor = true;
            this.rdbDividir.CheckedChanged += new System.EventHandler(this.rdbDividir_CheckedChanged);
            // 
            // rdbPotencia
            // 
            this.rdbPotencia.AutoSize = true;
            this.rdbPotencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPotencia.Location = new System.Drawing.Point(23, 207);
            this.rdbPotencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbPotencia.Name = "rdbPotencia";
            this.rdbPotencia.Size = new System.Drawing.Size(125, 24);
            this.rdbPotencia.TabIndex = 4;
            this.rdbPotencia.Text = "Potenciação";
            this.rdbPotencia.UseVisualStyleBackColor = true;
            this.rdbPotencia.CheckedChanged += new System.EventHandler(this.rdbPotencia_CheckedChanged);
            // 
            // lblOperacoes
            // 
            this.lblOperacoes.AutoSize = true;
            this.lblOperacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacoes.Location = new System.Drawing.Point(18, 47);
            this.lblOperacoes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperacoes.Name = "lblOperacoes";
            this.lblOperacoes.Size = new System.Drawing.Size(127, 26);
            this.lblOperacoes.TabIndex = 5;
            this.lblOperacoes.Text = "Operações";
            this.lblOperacoes.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(361, 149);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(89, 26);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.Location = new System.Drawing.Point(241, 207);
            this.btnLimpa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(171, 26);
            this.btnLimpa.TabIndex = 7;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = false;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackColor = System.Drawing.Color.PeachPuff;
            this.btnVolta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolta.Location = new System.Drawing.Point(361, 57);
            this.btnVolta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(89, 62);
            this.btnVolta.TabIndex = 8;
            this.btnVolta.Text = "Voltar";
            this.btnVolta.UseVisualStyleBackColor = false;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // txb1
            // 
            this.txb1.BackColor = System.Drawing.Color.PeachPuff;
            this.txb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb1.Location = new System.Drawing.Point(201, 58);
            this.txb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(113, 24);
            this.txb1.TabIndex = 9;
            this.txb1.TextChanged += new System.EventHandler(this.txb1_TextChanged);
            // 
            // txb2
            // 
            this.txb2.BackColor = System.Drawing.Color.PeachPuff;
            this.txb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb2.Location = new System.Drawing.Point(201, 93);
            this.txb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(113, 24);
            this.txb2.TabIndex = 10;
            this.txb2.TextChanged += new System.EventHandler(this.txb2_TextChanged);
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(187, 121);
            this.lblLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(142, 26);
            this.lblLine.TabIndex = 11;
            this.lblLine.Text = "__________";
            this.lblLine.Click += new System.EventHandler(this.lblLine_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.PeachPuff;
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(213, 159);
            this.btnResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(93, 25);
            this.btnResultado.TabIndex = 12;
            this.btnResultado.Text = "?";
            this.btnResultado.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspCalcPlus,
            this.tspCalcSimples});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menu";
            // 
            // tspCalcPlus
            // 
            this.tspCalcPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspCalcPlus.Name = "tspCalcPlus";
            this.tspCalcPlus.Size = new System.Drawing.Size(92, 22);
            this.tspCalcPlus.Text = "Calc. Plus";
            this.tspCalcPlus.Click += new System.EventHandler(this.tspCalcPlus_Click);
            // 
            // tspCalcSimples
            // 
            this.tspCalcSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspCalcSimples.Name = "tspCalcSimples";
            this.tspCalcSimples.Size = new System.Drawing.Size(117, 22);
            this.tspCalcSimples.Text = "Calc. Simples";
            this.tspCalcSimples.Click += new System.EventHandler(this.tspCalcSimples_Click);
            // 
            // calcradio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(497, 342);
            this.Controls.Add(this.menuStrip1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "calcradio";
            this.Text = "calcradio";
            this.Load += new System.EventHandler(this.calcradio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tspCalcPlus;
        private System.Windows.Forms.ToolStripMenuItem tspCalcSimples;
    }
}