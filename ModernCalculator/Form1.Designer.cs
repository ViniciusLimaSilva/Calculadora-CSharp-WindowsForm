﻿
using System.Windows.Forms;

namespace ModernCalculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnPI = new System.Windows.Forms.Button();
            this.btn_hex = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSen = new System.Windows.Forms.Button();
            this.btnlog10 = new System.Windows.Forms.Button();
            this.btnRD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnVirg = new System.Windows.Forms.Button();
            this.tblLateral = new System.Windows.Forms.TableLayoutPanel();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.txtValorDigitado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.Fechar = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblLateral.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnOct, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnBin, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnPI, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_hex, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSub, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDiv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRaiz, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMult, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSen, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnlog10, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRD, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnE, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnVirg, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 122);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 339);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnOct
            // 
            this.btnOct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOct.FlatAppearance.BorderSize = 0;
            this.btnOct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOct.Font = new System.Drawing.Font("Open Sans", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnOct.Location = new System.Drawing.Point(55, 271);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(46, 65);
            this.btnOct.TabIndex = 26;
            this.btnOct.Text = "Oct";
            this.btnOct.UseVisualStyleBackColor = true;
            this.btnOct.Click += new System.EventHandler(this.btnOct_click);
            // 
            // btnBin
            // 
            this.btnBin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBin.FlatAppearance.BorderSize = 0;
            this.btnBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBin.Font = new System.Drawing.Font("Open Sans", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnBin.Location = new System.Drawing.Point(107, 271);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(46, 65);
            this.btnBin.TabIndex = 25;
            this.btnBin.Text = "Bin";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_click);
            // 
            // btnPI
            // 
            this.btnPI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPI.FlatAppearance.BorderSize = 0;
            this.btnPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPI.Font = new System.Drawing.Font("Open Sans", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnPI.Location = new System.Drawing.Point(211, 271);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(50, 65);
            this.btnPI.TabIndex = 24;
            this.btnPI.Text = "π";
            this.btnPI.UseVisualStyleBackColor = true;
            this.btnPI.Click += new System.EventHandler(this.btnPI_cick);
            // 
            // btn_hex
            // 
            this.btn_hex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_hex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hex.FlatAppearance.BorderSize = 0;
            this.btn_hex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hex.Font = new System.Drawing.Font("Open Sans", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_hex.Location = new System.Drawing.Point(159, 271);
            this.btn_hex.Name = "btn_hex";
            this.btn_hex.Size = new System.Drawing.Size(46, 65);
            this.btn_hex.TabIndex = 23;
            this.btn_hex.Text = "Hex";
            this.btn_hex.UseVisualStyleBackColor = true;
            this.btn_hex.Click += new System.EventHandler(this.btn_hex_click);
            // 
            // btnSub
            // 
            this.btnSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(3, 3);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(46, 61);
            this.btnSub.TabIndex = 0;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_click);
            // 
            // btn4
            // 
            this.btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(3, 137);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(46, 61);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumerador_click);
            // 
            // btn5
            // 
            this.btn5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(55, 137);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(46, 61);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumerador_click);
            // 
            // btn6
            // 
            this.btn6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(107, 137);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(46, 61);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumerador_click);
            // 
            // btn7
            // 
            this.btn7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(3, 70);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(46, 61);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumerador_click);
            // 
            // btn8
            // 
            this.btn8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(55, 70);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(46, 61);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumerador_click);
            // 
            // btn9
            // 
            this.btn9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(107, 70);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(46, 61);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumerador_click);
            // 
            // btnDiv
            // 
            this.btnDiv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(55, 3);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(46, 61);
            this.btnDiv.TabIndex = 13;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaiz.FlatAppearance.BorderSize = 0;
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaiz.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(159, 3);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(46, 61);
            this.btnRaiz.TabIndex = 14;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_click);
            // 
            // btnMult
            // 
            this.btnMult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(107, 3);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(46, 61);
            this.btnMult.TabIndex = 14;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans", 9.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(211, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 61);
            this.button2.TabIndex = 21;
            this.button2.Text = "Tan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_tang_Click);
            // 
            // btnDel
            // 
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Open Sans", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnDel.Location = new System.Drawing.Point(211, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(46, 61);
            this.btnDel.TabIndex = 22;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.Del_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(55, 204);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(46, 61);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumerador_click);
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(3, 204);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(46, 61);
            this.btn1.TabIndex = 19;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumerador_click);
            this.btn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn1_KeyPress);
            // 
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(107, 204);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(46, 61);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumerador_click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 9.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(211, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 61);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSen
            // 
            this.btnSen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSen.FlatAppearance.BorderSize = 0;
            this.btnSen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSen.Font = new System.Drawing.Font("Open Sans", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnSen.Location = new System.Drawing.Point(211, 204);
            this.btnSen.Name = "btnSen";
            this.btnSen.Size = new System.Drawing.Size(50, 61);
            this.btnSen.TabIndex = 1;
            this.btnSen.Text = "Sen";
            this.btnSen.UseVisualStyleBackColor = true;
            this.btnSen.Click += new System.EventHandler(this.btnSen_click);
            // 
            // btnlog10
            // 
            this.btnlog10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlog10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlog10.FlatAppearance.BorderSize = 0;
            this.btnlog10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlog10.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnlog10.Location = new System.Drawing.Point(159, 70);
            this.btnlog10.Name = "btnlog10";
            this.btnlog10.Size = new System.Drawing.Size(46, 61);
            this.btnlog10.TabIndex = 18;
            this.btnlog10.Text = "Log10";
            this.btnlog10.UseVisualStyleBackColor = true;
            this.btnlog10.Click += new System.EventHandler(this.btnlog10_Click);
            // 
            // btnRD
            // 
            this.btnRD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRD.FlatAppearance.BorderSize = 0;
            this.btnRD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRD.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRD.Location = new System.Drawing.Point(159, 137);
            this.btnRD.Name = "btnRD";
            this.btnRD.Size = new System.Drawing.Size(46, 61);
            this.btnRD.TabIndex = 15;
            this.btnRD.Text = "%";
            this.btnRD.UseVisualStyleBackColor = true;
            this.btnRD.Click += new System.EventHandler(this.btnRD_click);
            // 
            // btnE
            // 
            this.btnE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnE.FlatAppearance.BorderSize = 0;
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnE.Location = new System.Drawing.Point(3, 271);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(46, 65);
            this.btnE.TabIndex = 27;
            this.btnE.Text = "e";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_click);
            // 
            // btnVirg
            // 
            this.btnVirg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVirg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVirg.FlatAppearance.BorderSize = 0;
            this.btnVirg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirg.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirg.Location = new System.Drawing.Point(159, 204);
            this.btnVirg.Name = "btnVirg";
            this.btnVirg.Size = new System.Drawing.Size(46, 61);
            this.btnVirg.TabIndex = 16;
            this.btnVirg.Text = ",";
            this.btnVirg.UseVisualStyleBackColor = true;
            this.btnVirg.Click += new System.EventHandler(this.btnVirg_Click);
            // 
            // tblLateral
            // 
            this.tblLateral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
            this.tblLateral.ColumnCount = 1;
            this.tblLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLateral.Controls.Add(this.btn0, 0, 3);
            this.tblLateral.Controls.Add(this.btnResult, 0, 2);
            this.tblLateral.Controls.Add(this.btnC, 0, 0);
            this.tblLateral.Controls.Add(this.btnSoma, 0, 1);
            this.tblLateral.Location = new System.Drawing.Point(267, 122);
            this.tblLateral.Name = "tblLateral";
            this.tblLateral.RowCount = 4;
            this.tblLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.07375F));
            this.tblLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.48378F));
            this.tblLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLateral.Size = new System.Drawing.Size(65, 339);
            this.tblLateral.TabIndex = 2;
            // 
            // btn0
            // 
            this.btn0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(3, 256);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(59, 80);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumerador_click);
            // 
            // btnResult
            // 
            this.btnResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(3, 173);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(59, 77);
            this.btnResult.TabIndex = 17;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_click);
            // 
            // btnC
            // 
            this.btnC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(3, 3);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(59, 79);
            this.btnC.TabIndex = 15;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnLimpar_click);
            // 
            // btnSoma
            // 
            this.btnSoma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoma.FlatAppearance.BorderSize = 0;
            this.btnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoma.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(3, 88);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(59, 79);
            this.btnSoma.TabIndex = 16;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSomar_click);
            // 
            // txtValorDigitado
            // 
            this.txtValorDigitado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(18)))), ((int)(((byte)(52)))));
            this.txtValorDigitado.Font = new System.Drawing.Font("Open Sans", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtValorDigitado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtValorDigitado.Location = new System.Drawing.Point(-3, 0);
            this.txtValorDigitado.Multiline = true;
            this.txtValorDigitado.Name = "txtValorDigitado";
            this.txtValorDigitado.Size = new System.Drawing.Size(334, 100);
            this.txtValorDigitado.TabIndex = 0;
            this.txtValorDigitado.TextChanged += new System.EventHandler(this.txtValorDigitado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 25.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(289, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 46);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(18)))), ((int)(((byte)(52)))));
            this.pnlDisplay.Controls.Add(this.label3);
            this.pnlDisplay.Controls.Add(this.label2);
            this.pnlDisplay.Controls.Add(this.label1);
            this.pnlDisplay.Controls.Add(this.txtValorDigitado);
            this.pnlDisplay.Location = new System.Drawing.Point(3, 28);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(332, 100);
            this.pnlDisplay.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 25.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(29, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = " ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 25.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(239, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 46);
            this.label2.TabIndex = 2;
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Image = ((System.Drawing.Image)(resources.GetObject("Max.Image")));
            this.Max.Location = new System.Drawing.Point(297, 3);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(13, 13);
            this.Max.TabIndex = 4;
            this.Max.Text = "  ";
            this.Max.Click += new System.EventHandler(this.max_click);
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Image = ((System.Drawing.Image)(resources.GetObject("Min.Image")));
            this.Min.Location = new System.Drawing.Point(313, 3);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(16, 13);
            this.Min.TabIndex = 5;
            this.Min.Text = "   ";
            this.Min.Click += new System.EventHandler(this.min_click);
            // 
            // Fechar
            // 
            this.Fechar.AutoSize = true;
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.Location = new System.Drawing.Point(278, 3);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(13, 13);
            this.Fechar.TabIndex = 6;
            this.Fechar.Text = "  ";
            this.Fechar.Click += new System.EventHandler(this.fechar_click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 461);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.tblLateral);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teclado_Num_Keypress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tblLateral.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
            this.pnlDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        //comando para utilizar a calculadora com o teclado numerico
        private void teclado_Num_Keypress(object sender, KeyPressEventArgs e)
        {

                switch (e.KeyChar)
                {
                    case (char)40: txtValorDigitado.Text = txtValorDigitado.Text + "("; break;
                    case (char)41: txtValorDigitado.Text = txtValorDigitado.Text + ")"; break;
                    case (char)44: txtValorDigitado.Text = txtValorDigitado.Text + ","; break;
                    case (char)46: txtValorDigitado.Text = txtValorDigitado.Text + ","; break;
                    case (char)48: txtValorDigitado.Text = txtValorDigitado.Text + "0"; break;
                    case (char)49: txtValorDigitado.Text = txtValorDigitado.Text + "1"; break;
                    case (char)50: txtValorDigitado.Text = txtValorDigitado.Text + "2"; break;
                    case (char)51: txtValorDigitado.Text = txtValorDigitado.Text + "3"; break;
                    case (char)52: txtValorDigitado.Text = txtValorDigitado.Text + "4"; break;
                    case (char)53: txtValorDigitado.Text = txtValorDigitado.Text + "5"; break;
                    case (char)54: txtValorDigitado.Text = txtValorDigitado.Text + "6"; break;
                    case (char)55: txtValorDigitado.Text = txtValorDigitado.Text + "7"; break;
                    case (char)56: txtValorDigitado.Text = txtValorDigitado.Text + "8"; break;
                    case (char)57: txtValorDigitado.Text = txtValorDigitado.Text + "9"; break;


            }

            switch (e.KeyChar)
            {
                case (char)43: btnSoma.PerformClick(); break;            

            }

            switch (e.KeyChar)
            {      
                case (char)42: btnMult.PerformClick(); break;
           
            }
            switch (e.KeyChar)
            {             
                case (char)37: btnRD.PerformClick(); break;
            
            }
            switch (e.KeyChar)
            {            
                case (char)45: btnSub.PerformClick(); break;
               
            }
            switch (e.KeyChar)
            {                
                case (char)47: btnDiv.PerformClick(); break;
             
            }
            switch (e.KeyChar)
            {              
                case (char)13: btnResult.PerformClick(); break;
              
            }
            switch (e.KeyChar)
            {          
                case (char)8: btnDel.PerformClick(); break;

            }
            switch (e.KeyChar)
            {
                case (char)67: btnC.PerformClick(); break;
            }



        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSen;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.TableLayoutPanel tblLateral;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.TextBox txtValorDigitado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnVirg;
        private System.Windows.Forms.Button btnRD;
        private System.Windows.Forms.Button btnlog10;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Fechar;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnOct;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnPI;
        private System.Windows.Forms.Button btn_hex;
    }
}

