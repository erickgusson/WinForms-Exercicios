﻿namespace WindowsFormsExercicios
{
    partial class formEX1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNomeArquivo = new System.Windows.Forms.TextBox();
            this.txbConteudo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvarNota = new System.Windows.Forms.Button();
            this.lblAlert = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxArquivos = new System.Windows.Forms.ComboBox();
            this.lblConteudoNotas = new System.Windows.Forms.Label();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da nota";
            // 
            // txbNomeArquivo
            // 
            this.txbNomeArquivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeArquivo.Location = new System.Drawing.Point(10, 47);
            this.txbNomeArquivo.Name = "txbNomeArquivo";
            this.txbNomeArquivo.Size = new System.Drawing.Size(200, 25);
            this.txbNomeArquivo.TabIndex = 1;
            // 
            // txbConteudo
            // 
            this.txbConteudo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConteudo.Location = new System.Drawing.Point(10, 96);
            this.txbConteudo.Name = "txbConteudo";
            this.txbConteudo.Size = new System.Drawing.Size(200, 25);
            this.txbConteudo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conteúdo";
            // 
            // btnSalvarNota
            // 
            this.btnSalvarNota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarNota.Location = new System.Drawing.Point(10, 127);
            this.btnSalvarNota.Name = "btnSalvarNota";
            this.btnSalvarNota.Size = new System.Drawing.Size(92, 23);
            this.btnSalvarNota.TabIndex = 4;
            this.btnSalvarNota.Text = "Salvar nota";
            this.btnSalvarNota.UseVisualStyleBackColor = true;
            this.btnSalvarNota.Click += new System.EventHandler(this.btnSalvarNota_Click);
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.Tomato;
            this.lblAlert.Location = new System.Drawing.Point(10, 153);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(0, 17);
            this.lblAlert.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ler nota";
            // 
            // cbxArquivos
            // 
            this.cbxArquivos.FormattingEnabled = true;
            this.cbxArquivos.Location = new System.Drawing.Point(245, 47);
            this.cbxArquivos.Name = "cbxArquivos";
            this.cbxArquivos.Size = new System.Drawing.Size(121, 21);
            this.cbxArquivos.TabIndex = 7;
            this.cbxArquivos.SelectedIndexChanged += new System.EventHandler(this.cbxArquivos_SelectedIndexChanged);
            // 
            // lblConteudoNotas
            // 
            this.lblConteudoNotas.AutoSize = true;
            this.lblConteudoNotas.Location = new System.Drawing.Point(245, 79);
            this.lblConteudoNotas.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblConteudoNotas.Name = "lblConteudoNotas";
            this.lblConteudoNotas.Size = new System.Drawing.Size(0, 13);
            this.lblConteudoNotas.TabIndex = 8;
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.FlatAppearance.BorderSize = 0;
            this.btnRecarregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecarregar.Location = new System.Drawing.Point(372, 44);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(30, 28);
            this.btnRecarregar.TabIndex = 9;
            this.btnRecarregar.Text = "⟳";
            this.btnRecarregar.UseVisualStyleBackColor = true;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // formEX1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.lblConteudoNotas);
            this.Controls.Add(this.cbxArquivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.btnSalvarNota);
            this.Controls.Add(this.txbConteudo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNomeArquivo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEX1";
            this.Text = "Bloco de Notas";
            this.Load += new System.EventHandler(this.formEX1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNomeArquivo;
        private System.Windows.Forms.TextBox txbConteudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvarNota;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxArquivos;
        private System.Windows.Forms.Label lblConteudoNotas;
        private System.Windows.Forms.Button btnRecarregar;
    }
}