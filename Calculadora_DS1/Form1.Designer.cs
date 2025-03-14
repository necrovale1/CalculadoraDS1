namespace Calculadora_DS1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.lblTextoResultado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picGato = new System.Windows.Forms.PictureBox();
            this.lblView = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mstpCalcRadio = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslDateHour = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picGato)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomar.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.ForeColor = System.Drawing.Color.Tomato;
            this.btnSomar.Location = new System.Drawing.Point(616, 135);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(48, 40);
            this.btnSomar.TabIndex = 0;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtrair.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.ForeColor = System.Drawing.Color.Tomato;
            this.btnSubtrair.Location = new System.Drawing.Point(616, 195);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(48, 40);
            this.btnSubtrair.TabIndex = 1;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.ForeColor = System.Drawing.Color.Tomato;
            this.btnMultiplicar.Location = new System.Drawing.Point(616, 258);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(48, 40);
            this.btnMultiplicar.TabIndex = 2;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.Color.Tomato;
            this.btnDividir.Location = new System.Drawing.Point(616, 320);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(48, 40);
            this.btnDividir.TabIndex = 3;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.Tomato;
            this.btnIgual.Location = new System.Drawing.Point(550, 320);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(48, 40);
            this.btnIgual.TabIndex = 4;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Tomato;
            this.btn9.Location = new System.Drawing.Point(550, 135);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 40);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Tomato;
            this.btn8.Location = new System.Drawing.Point(483, 135);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 40);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Tomato;
            this.btn7.Location = new System.Drawing.Point(416, 135);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 40);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Tomato;
            this.btn4.Location = new System.Drawing.Point(416, 195);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 40);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Tomato;
            this.btn5.Location = new System.Drawing.Point(483, 195);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 40);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Tomato;
            this.btn6.Location = new System.Drawing.Point(550, 195);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 40);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Tomato;
            this.btn1.Location = new System.Drawing.Point(416, 258);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 40);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Tomato;
            this.btn2.Location = new System.Drawing.Point(483, 258);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 40);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Tomato;
            this.btn3.Location = new System.Drawing.Point(550, 258);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 40);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Tomato;
            this.btn0.Location = new System.Drawing.Point(416, 320);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(116, 40);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // lblTextoResultado
            // 
            this.lblTextoResultado.AutoSize = true;
            this.lblTextoResultado.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoResultado.Location = new System.Drawing.Point(120, 106);
            this.lblTextoResultado.Name = "lblTextoResultado";
            this.lblTextoResultado.Size = new System.Drawing.Size(154, 35);
            this.lblTextoResultado.TabIndex = 15;
            this.lblTextoResultado.Text = "Resultado:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.White;
            this.lblResultado.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(106, 163);
            this.lblResultado.MaximumSize = new System.Drawing.Size(200, 40);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 35);
            this.lblResultado.TabIndex = 17;
            this.lblResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picGato
            // 
            this.picGato.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picGato.BackgroundImage = global::Calculadora_DS1.Properties.Resources.gato;
            this.picGato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picGato.ErrorImage = null;
            this.picGato.InitialImage = null;
            this.picGato.Location = new System.Drawing.Point(112, 205);
            this.picGato.Margin = new System.Windows.Forms.Padding(0);
            this.picGato.Name = "picGato";
            this.picGato.Size = new System.Drawing.Size(162, 165);
            this.picGato.TabIndex = 18;
            this.picGato.TabStop = false;
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.BackColor = System.Drawing.Color.MistyRose;
            this.lblView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.ForeColor = System.Drawing.Color.Tomato;
            this.lblView.Location = new System.Drawing.Point(92, 151);
            this.lblView.MinimumSize = new System.Drawing.Size(200, 2);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(200, 34);
            this.lblView.TabIndex = 19;
            this.lblView.Text = "l";
            this.lblView.Click += new System.EventHandler(this.Form1_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.menuStrip1.Font = new System.Drawing.Font("RomanD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.mstpCalcRadio});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simToolStripMenuItem,
            this.nãoToolStripMenuItem,
            this.tspSair});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(87, 34);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // simToolStripMenuItem
            // 
            this.simToolStripMenuItem.Name = "simToolStripMenuItem";
            this.simToolStripMenuItem.Size = new System.Drawing.Size(159, 38);
            this.simToolStripMenuItem.Text = "Sim";
            // 
            // nãoToolStripMenuItem
            // 
            this.nãoToolStripMenuItem.Name = "nãoToolStripMenuItem";
            this.nãoToolStripMenuItem.Size = new System.Drawing.Size(159, 38);
            this.nãoToolStripMenuItem.Text = "Não";
            // 
            // tspSair
            // 
            this.tspSair.Name = "tspSair";
            this.tspSair.Size = new System.Drawing.Size(159, 38);
            this.tspSair.Text = "Sair";
            this.tspSair.Click += new System.EventHandler(this.tspSair_Click);
            // 
            // mstpCalcRadio
            // 
            this.mstpCalcRadio.Name = "mstpCalcRadio";
            this.mstpCalcRadio.Size = new System.Drawing.Size(161, 34);
            this.mstpCalcRadio.Text = "Calc. Radio";
            this.mstpCalcRadio.Click += new System.EventHandler(this.mstpCalcRadio_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Bisque;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Calculadora_DS1.Properties.Resources.gato;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.PeachPuff;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslHora,
            this.tslDateHour});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslHora
            // 
            this.tslHora.BackColor = System.Drawing.Color.PeachPuff;
            this.tslHora.Name = "tslHora";
            this.tslHora.Size = new System.Drawing.Size(60, 25);
            this.tslHora.Text = "Hora :";
            // 
            // tslDateHour
            // 
            this.tslDateHour.BackColor = System.Drawing.Color.PeachPuff;
            this.tslDateHour.Name = "tslDateHour";
            this.tslDateHour.Size = new System.Drawing.Size(21, 25);
            this.tslDateHour.Text = "a";
            // 
            // tmr1
            // 
            this.tmr1.Enabled = true;
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("RomanD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Tomato;
            this.btnClear.Location = new System.Drawing.Point(687, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(46, 100);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.picGato);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTextoResultado);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGato)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Label lblTextoResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picGato;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstpCalcRadio;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem tspSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.ToolStripStatusLabel tslHora;
        private System.Windows.Forms.ToolStripStatusLabel tslDateHour;
        private System.Windows.Forms.Button btnClear;
    }
}

