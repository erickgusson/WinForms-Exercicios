﻿namespace WindowsFormsExercicios
{
    partial class FormEX6
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
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTarefa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionarTarefa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluirTarefa = new System.Windows.Forms.Button();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(10, 195);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(125, 20);
            this.dtpVencimento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarefa";
            // 
            // txbTarefa
            // 
            this.txbTarefa.Location = new System.Drawing.Point(10, 32);
            this.txbTarefa.Name = "txbTarefa";
            this.txbTarefa.Size = new System.Drawing.Size(125, 20);
            this.txbTarefa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(10, 65);
            this.txbDesc.Multiline = true;
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(125, 105);
            this.txbDesc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expira em:";
            // 
            // btnAdicionarTarefa
            // 
            this.btnAdicionarTarefa.Location = new System.Drawing.Point(10, 344);
            this.btnAdicionarTarefa.Name = "btnAdicionarTarefa";
            this.btnAdicionarTarefa.Size = new System.Drawing.Size(125, 23);
            this.btnAdicionarTarefa.TabIndex = 6;
            this.btnAdicionarTarefa.Text = "Adicionar tarefa";
            this.btnAdicionarTarefa.UseVisualStyleBackColor = true;
            this.btnAdicionarTarefa.Click += new System.EventHandler(this.buttonAdicionarTarefa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnExcluirTarefa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpVencimento);
            this.panel1.Controls.Add(this.btnAdicionarTarefa);
            this.panel1.Controls.Add(this.txbTarefa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbDesc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 420);
            this.panel1.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(10, 315);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluirTarefa
            // 
            this.btnExcluirTarefa.Location = new System.Drawing.Point(10, 373);
            this.btnExcluirTarefa.Name = "btnExcluirTarefa";
            this.btnExcluirTarefa.Size = new System.Drawing.Size(125, 23);
            this.btnExcluirTarefa.TabIndex = 7;
            this.btnExcluirTarefa.Text = "Excluir tarefa";
            this.btnExcluirTarefa.UseVisualStyleBackColor = true;
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTarefas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarefas.Location = new System.Drawing.Point(145, 0);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.Size = new System.Drawing.Size(460, 420);
            this.dgvTarefas.TabIndex = 8;
            this.dgvTarefas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarefas_CellContentClick);
            // 
            // FormEX6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 420);
            this.Controls.Add(this.dgvTarefas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEX6";
            this.Text = "FormEX6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTarefa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionarTarefa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluirTarefa;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.Button btnLimpar;
    }
}