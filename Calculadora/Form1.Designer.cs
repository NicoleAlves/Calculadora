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
            this.UM = new System.Windows.Forms.Button();
            this.DOIS = new System.Windows.Forms.Button();
            this.TRES = new System.Windows.Forms.Button();
            this.QUATRO = new System.Windows.Forms.Button();
            this.CINCO = new System.Windows.Forms.Button();
            this.SEIS = new System.Windows.Forms.Button();
            this.SETE = new System.Windows.Forms.Button();
            this.OITO = new System.Windows.Forms.Button();
            this.NOVE = new System.Windows.Forms.Button();
            this.ZERO = new System.Windows.Forms.Button();
            this.SOMA = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SUBTRACAO = new System.Windows.Forms.Button();
            this.DIVISAO = new System.Windows.Forms.Button();
            this.MULTIPLICACAO = new System.Windows.Forms.Button();
            this.PORCENTAGEM = new System.Windows.Forms.Button();
            this.POTENCIA = new System.Windows.Forms.Button();
            this.RAIZ = new System.Windows.Forms.Button();
            this.SEN = new System.Windows.Forms.Button();
            this.COS = new System.Windows.Forms.Button();
            this.TG = new System.Windows.Forms.Button();
            this.RESTO = new System.Windows.Forms.Button();
            this.RESULTADO = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.PONTO = new System.Windows.Forms.Button();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UM
            // 
            this.UM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UM.Location = new System.Drawing.Point(8, 42);
            this.UM.Name = "UM";
            this.UM.Size = new System.Drawing.Size(36, 23);
            this.UM.TabIndex = 0;
            this.UM.Text = "1";
            this.UM.UseVisualStyleBackColor = true;
            this.UM.Click += new System.EventHandler(this.Digitou);
            // 
            // DOIS
            // 
            this.DOIS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DOIS.Location = new System.Drawing.Point(51, 42);
            this.DOIS.Name = "DOIS";
            this.DOIS.Size = new System.Drawing.Size(36, 23);
            this.DOIS.TabIndex = 1;
            this.DOIS.Text = "2";
            this.DOIS.UseVisualStyleBackColor = true;
            this.DOIS.Click += new System.EventHandler(this.Digitou);
            // 
            // TRES
            // 
            this.TRES.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TRES.Location = new System.Drawing.Point(93, 42);
            this.TRES.Name = "TRES";
            this.TRES.Size = new System.Drawing.Size(36, 23);
            this.TRES.TabIndex = 2;
            this.TRES.Text = "3";
            this.TRES.UseVisualStyleBackColor = true;
            this.TRES.Click += new System.EventHandler(this.Digitou);
            // 
            // QUATRO
            // 
            this.QUATRO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.QUATRO.Location = new System.Drawing.Point(8, 71);
            this.QUATRO.Name = "QUATRO";
            this.QUATRO.Size = new System.Drawing.Size(36, 23);
            this.QUATRO.TabIndex = 3;
            this.QUATRO.Text = "4";
            this.QUATRO.UseVisualStyleBackColor = true;
            this.QUATRO.Click += new System.EventHandler(this.Digitou);
            // 
            // CINCO
            // 
            this.CINCO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CINCO.Location = new System.Drawing.Point(51, 71);
            this.CINCO.Name = "CINCO";
            this.CINCO.Size = new System.Drawing.Size(36, 23);
            this.CINCO.TabIndex = 4;
            this.CINCO.Text = "5";
            this.CINCO.UseVisualStyleBackColor = true;
            this.CINCO.Click += new System.EventHandler(this.Digitou);
            // 
            // SEIS
            // 
            this.SEIS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SEIS.Location = new System.Drawing.Point(93, 71);
            this.SEIS.Name = "SEIS";
            this.SEIS.Size = new System.Drawing.Size(36, 23);
            this.SEIS.TabIndex = 5;
            this.SEIS.Text = "6";
            this.SEIS.UseVisualStyleBackColor = true;
            this.SEIS.Click += new System.EventHandler(this.Digitou);
            // 
            // SETE
            // 
            this.SETE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SETE.Location = new System.Drawing.Point(8, 100);
            this.SETE.Name = "SETE";
            this.SETE.Size = new System.Drawing.Size(36, 23);
            this.SETE.TabIndex = 6;
            this.SETE.Text = "7";
            this.SETE.UseVisualStyleBackColor = true;
            this.SETE.Click += new System.EventHandler(this.Digitou);
            // 
            // OITO
            // 
            this.OITO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OITO.Location = new System.Drawing.Point(51, 100);
            this.OITO.Name = "OITO";
            this.OITO.Size = new System.Drawing.Size(36, 23);
            this.OITO.TabIndex = 7;
            this.OITO.Text = "8";
            this.OITO.UseVisualStyleBackColor = true;
            this.OITO.Click += new System.EventHandler(this.Digitou);
            // 
            // NOVE
            // 
            this.NOVE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NOVE.Location = new System.Drawing.Point(93, 100);
            this.NOVE.Name = "NOVE";
            this.NOVE.Size = new System.Drawing.Size(36, 23);
            this.NOVE.TabIndex = 8;
            this.NOVE.Text = "9";
            this.NOVE.UseVisualStyleBackColor = true;
            this.NOVE.Click += new System.EventHandler(this.Digitou);
            // 
            // ZERO
            // 
            this.ZERO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ZERO.Location = new System.Drawing.Point(8, 129);
            this.ZERO.Name = "ZERO";
            this.ZERO.Size = new System.Drawing.Size(79, 23);
            this.ZERO.TabIndex = 9;
            this.ZERO.Text = "0";
            this.ZERO.UseVisualStyleBackColor = true;
            this.ZERO.Click += new System.EventHandler(this.Digitou);
            // 
            // SOMA
            // 
            this.SOMA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SOMA.Location = new System.Drawing.Point(177, 42);
            this.SOMA.Name = "SOMA";
            this.SOMA.Size = new System.Drawing.Size(36, 23);
            this.SOMA.TabIndex = 10;
            this.SOMA.Text = "+";
            this.SOMA.UseVisualStyleBackColor = true;
            this.SOMA.Click += new System.EventHandler(this.Operacao);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(8, 12);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(206, 20);
            this.txtResultado.TabIndex = 11;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SUBTRACAO
            // 
            this.SUBTRACAO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SUBTRACAO.Location = new System.Drawing.Point(177, 71);
            this.SUBTRACAO.Name = "SUBTRACAO";
            this.SUBTRACAO.Size = new System.Drawing.Size(36, 23);
            this.SUBTRACAO.TabIndex = 12;
            this.SUBTRACAO.Text = "-";
            this.SUBTRACAO.UseVisualStyleBackColor = true;
            this.SUBTRACAO.Click += new System.EventHandler(this.Operacao);
            // 
            // DIVISAO
            // 
            this.DIVISAO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DIVISAO.Location = new System.Drawing.Point(177, 100);
            this.DIVISAO.Name = "DIVISAO";
            this.DIVISAO.Size = new System.Drawing.Size(36, 23);
            this.DIVISAO.TabIndex = 13;
            this.DIVISAO.Text = "/";
            this.DIVISAO.UseVisualStyleBackColor = true;
            this.DIVISAO.Click += new System.EventHandler(this.Operacao);
            // 
            // MULTIPLICACAO
            // 
            this.MULTIPLICACAO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MULTIPLICACAO.Location = new System.Drawing.Point(177, 129);
            this.MULTIPLICACAO.Name = "MULTIPLICACAO";
            this.MULTIPLICACAO.Size = new System.Drawing.Size(36, 23);
            this.MULTIPLICACAO.TabIndex = 14;
            this.MULTIPLICACAO.Text = "*";
            this.MULTIPLICACAO.UseVisualStyleBackColor = true;
            this.MULTIPLICACAO.Click += new System.EventHandler(this.Operacao);
            // 
            // PORCENTAGEM
            // 
            this.PORCENTAGEM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PORCENTAGEM.Location = new System.Drawing.Point(93, 187);
            this.PORCENTAGEM.Name = "PORCENTAGEM";
            this.PORCENTAGEM.Size = new System.Drawing.Size(36, 23);
            this.PORCENTAGEM.TabIndex = 15;
            this.PORCENTAGEM.Text = "%";
            this.PORCENTAGEM.UseVisualStyleBackColor = true;
            this.PORCENTAGEM.Click += new System.EventHandler(this.Operacao);
            // 
            // POTENCIA
            // 
            this.POTENCIA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.POTENCIA.Location = new System.Drawing.Point(8, 158);
            this.POTENCIA.Name = "POTENCIA";
            this.POTENCIA.Size = new System.Drawing.Size(36, 23);
            this.POTENCIA.TabIndex = 16;
            this.POTENCIA.Text = "x²";
            this.POTENCIA.UseVisualStyleBackColor = true;
            this.POTENCIA.Click += new System.EventHandler(this.Operacao);
            // 
            // RAIZ
            // 
            this.RAIZ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RAIZ.Location = new System.Drawing.Point(51, 158);
            this.RAIZ.Name = "RAIZ";
            this.RAIZ.Size = new System.Drawing.Size(36, 23);
            this.RAIZ.TabIndex = 17;
            this.RAIZ.Text = " √x";
            this.RAIZ.UseVisualStyleBackColor = true;
            this.RAIZ.Click += new System.EventHandler(this.Operacao);
            // 
            // SEN
            // 
            this.SEN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SEN.Location = new System.Drawing.Point(93, 158);
            this.SEN.Name = "SEN";
            this.SEN.Size = new System.Drawing.Size(36, 23);
            this.SEN.TabIndex = 18;
            this.SEN.Text = "sen";
            this.SEN.UseVisualStyleBackColor = true;
            this.SEN.Click += new System.EventHandler(this.Operacao);
            // 
            // COS
            // 
            this.COS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.COS.Location = new System.Drawing.Point(8, 187);
            this.COS.Name = "COS";
            this.COS.Size = new System.Drawing.Size(36, 23);
            this.COS.TabIndex = 19;
            this.COS.Text = "cos";
            this.COS.UseVisualStyleBackColor = true;
            this.COS.Click += new System.EventHandler(this.Operacao);
            // 
            // TG
            // 
            this.TG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TG.Location = new System.Drawing.Point(51, 188);
            this.TG.Name = "TG";
            this.TG.Size = new System.Drawing.Size(36, 23);
            this.TG.TabIndex = 20;
            this.TG.Text = "tg";
            this.TG.UseVisualStyleBackColor = true;
            this.TG.Click += new System.EventHandler(this.Operacao);
            // 
            // RESTO
            // 
            this.RESTO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RESTO.Location = new System.Drawing.Point(135, 155);
            this.RESTO.Name = "RESTO";
            this.RESTO.Size = new System.Drawing.Size(78, 23);
            this.RESTO.TabIndex = 21;
            this.RESTO.Text = "resto";
            this.RESTO.UseVisualStyleBackColor = true;
            this.RESTO.Click += new System.EventHandler(this.Operacao);
            // 
            // RESULTADO
            // 
            this.RESULTADO.BackColor = System.Drawing.SystemColors.Control;
            this.RESULTADO.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RESULTADO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RESULTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULTADO.Location = new System.Drawing.Point(135, 71);
            this.RESULTADO.Name = "RESULTADO";
            this.RESULTADO.Size = new System.Drawing.Size(36, 81);
            this.RESULTADO.TabIndex = 22;
            this.RESULTADO.Text = "=";
            this.RESULTADO.UseVisualStyleBackColor = false;
            this.RESULTADO.Click += new System.EventHandler(this.Result);
            // 
            // C
            // 
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.C.Location = new System.Drawing.Point(135, 42);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(36, 23);
            this.C.TabIndex = 23;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.Cleaned);
            // 
            // PONTO
            // 
            this.PONTO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PONTO.Location = new System.Drawing.Point(93, 129);
            this.PONTO.Name = "PONTO";
            this.PONTO.Size = new System.Drawing.Size(36, 23);
            this.PONTO.TabIndex = 24;
            this.PONTO.Text = ",";
            this.PONTO.UseVisualStyleBackColor = true;
            this.PONTO.Click += new System.EventHandler(this.Digitou);
            // 
            // txtConta
            // 
            this.txtConta.Enabled = false;
            this.txtConta.Location = new System.Drawing.Point(135, 188);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(79, 20);
            this.txtConta.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 223);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.PONTO);
            this.Controls.Add(this.C);
            this.Controls.Add(this.RESULTADO);
            this.Controls.Add(this.RESTO);
            this.Controls.Add(this.TG);
            this.Controls.Add(this.COS);
            this.Controls.Add(this.SEN);
            this.Controls.Add(this.RAIZ);
            this.Controls.Add(this.POTENCIA);
            this.Controls.Add(this.PORCENTAGEM);
            this.Controls.Add(this.MULTIPLICACAO);
            this.Controls.Add(this.DIVISAO);
            this.Controls.Add(this.SUBTRACAO);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.SOMA);
            this.Controls.Add(this.ZERO);
            this.Controls.Add(this.NOVE);
            this.Controls.Add(this.OITO);
            this.Controls.Add(this.SETE);
            this.Controls.Add(this.SEIS);
            this.Controls.Add(this.CINCO);
            this.Controls.Add(this.QUATRO);
            this.Controls.Add(this.TRES);
            this.Controls.Add(this.DOIS);
            this.Controls.Add(this.UM);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UM;
        private System.Windows.Forms.Button DOIS;
        private System.Windows.Forms.Button TRES;
        private System.Windows.Forms.Button QUATRO;
        private System.Windows.Forms.Button CINCO;
        private System.Windows.Forms.Button SEIS;
        private System.Windows.Forms.Button SETE;
        private System.Windows.Forms.Button OITO;
        private System.Windows.Forms.Button NOVE;
        private System.Windows.Forms.Button ZERO;
        private System.Windows.Forms.Button SOMA;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button SUBTRACAO;
        private System.Windows.Forms.Button DIVISAO;
        private System.Windows.Forms.Button MULTIPLICACAO;
        private System.Windows.Forms.Button PORCENTAGEM;
        private System.Windows.Forms.Button POTENCIA;
        private System.Windows.Forms.Button RAIZ;
        private System.Windows.Forms.Button SEN;
        private System.Windows.Forms.Button COS;
        private System.Windows.Forms.Button TG;
        private System.Windows.Forms.Button RESTO;
        private System.Windows.Forms.Button RESULTADO;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button PONTO;
        private System.Windows.Forms.TextBox txtConta;

    }
}

