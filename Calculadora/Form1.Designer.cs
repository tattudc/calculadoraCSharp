namespace Calculadora
{
    partial class Form1
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
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btMais = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btResult = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(13, 49);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(70, 23);
            this.bt7.TabIndex = 1;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(94, 49);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(70, 23);
            this.bt8.TabIndex = 2;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(175, 49);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(70, 23);
            this.bt9.TabIndex = 3;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.gerarNumero);
            // 
            // btMais
            // 
            this.btMais.Location = new System.Drawing.Point(251, 49);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(35, 23);
            this.btMais.TabIndex = 4;
            this.btMais.Text = "+";
            this.btMais.UseVisualStyleBackColor = true;
            this.btMais.Click += new System.EventHandler(this.operadores);
            // 
            // btMenos
            // 
            this.btMenos.Location = new System.Drawing.Point(251, 87);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(35, 23);
            this.btMenos.TabIndex = 8;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = true;
            this.btMenos.Click += new System.EventHandler(this.operadores);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(175, 87);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(70, 23);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(94, 87);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(70, 23);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(13, 87);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(70, 23);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.gerarNumero);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.Location = new System.Drawing.Point(251, 162);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(35, 23);
            this.btMultiplicar.TabIndex = 16;
            this.btMultiplicar.Text = "X";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.operadores);
            // 
            // btResult
            // 
            this.btResult.Location = new System.Drawing.Point(175, 162);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(70, 23);
            this.btResult.TabIndex = 15;
            this.btResult.Text = "=";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(94, 162);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(70, 23);
            this.bt0.TabIndex = 14;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.gerarNumero);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(13, 162);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(70, 23);
            this.btLimpar.TabIndex = 13;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btDividir
            // 
            this.btDividir.Location = new System.Drawing.Point(251, 124);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(35, 23);
            this.btDividir.TabIndex = 12;
            this.btDividir.Text = "/";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.operadores);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(175, 124);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(70, 23);
            this.bt3.TabIndex = 11;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(94, 124);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(70, 23);
            this.bt2.TabIndex = 10;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.gerarNumero);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(13, 124);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(70, 23);
            this.bt1.TabIndex = 9;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.gerarNumero);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(13, 13);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(273, 20);
            this.textResult.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 220);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.btMultiplicar);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btMais);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btMultiplicar;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.MaskedTextBox textResult;
    }
}

