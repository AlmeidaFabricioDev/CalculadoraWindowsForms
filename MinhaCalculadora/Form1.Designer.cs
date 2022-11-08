namespace MinhaCalculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.btnCE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Botoes);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Botoes);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(195, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Botoes);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Botoes);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(101, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 60);
            this.button5.TabIndex = 4;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Botoes);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(195, 222);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 60);
            this.button6.TabIndex = 5;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Botoes);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 297);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 60);
            this.button7.TabIndex = 6;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Botoes);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(101, 297);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 60);
            this.button8.TabIndex = 7;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Botoes);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(195, 297);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 60);
            this.button9.TabIndex = 8;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Botoes);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 377);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(67, 60);
            this.button10.TabIndex = 9;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Botoes);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(195, 377);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(67, 60);
            this.btnIgual.TabIndex = 11;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(287, 150);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(67, 60);
            this.btnSoma.TabIndex = 12;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(287, 222);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(67, 60);
            this.btnSub.TabIndex = 13;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(287, 297);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(67, 60);
            this.btnMult.TabIndex = 14;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(287, 377);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(67, 60);
            this.btnDiv.TabIndex = 15;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 44);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(342, 86);
            this.txtResultado.TabIndex = 16;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(101, 377);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 60);
            this.button11.TabIndex = 17;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Botoes);
            // 
            // lblOperacao
            // 
            this.lblOperacao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOperacao.Location = new System.Drawing.Point(270, 86);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(28, 27);
            this.lblOperacao.TabIndex = 18;
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(148, 467);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(82, 60);
            this.btnCE.TabIndex = 19;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 539);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button btnIgual;
        private Button btnSoma;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
        private TextBox txtResultado;
        private Button button11;
        private Label lblOperacao;
        private Button btnCE;
    }
}