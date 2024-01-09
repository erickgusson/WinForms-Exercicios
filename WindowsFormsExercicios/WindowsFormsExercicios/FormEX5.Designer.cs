namespace WindowsFormsExercicios
{
    partial class FormEX5
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
            this.lbxNotas = new System.Windows.Forms.ListBox();
            this.txbNotaConteudo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txbCriacaoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCriacaoConteudo = new System.Windows.Forms.TextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxNotas
            // 
            this.lbxNotas.FormattingEnabled = true;
            this.lbxNotas.Location = new System.Drawing.Point(10, 13);
            this.lbxNotas.Name = "lbxNotas";
            this.lbxNotas.Size = new System.Drawing.Size(280, 394);
            this.lbxNotas.Sorted = true;
            this.lbxNotas.TabIndex = 0;
            this.lbxNotas.SelectedIndexChanged += new System.EventHandler(this.lbxNotas_SelectedIndexChanged);
            // 
            // txbNotaConteudo
            // 
            this.txbNotaConteudo.Location = new System.Drawing.Point(300, 190);
            this.txbNotaConteudo.Multiline = true;
            this.txbNotaConteudo.Name = "txbNotaConteudo";
            this.txbNotaConteudo.Size = new System.Drawing.Size(295, 180);
            this.txbNotaConteudo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Conteúdo da nota";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(300, 384);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir nota";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(385, 384);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(84, 23);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar nota";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txbCriacaoNome
            // 
            this.txbCriacaoNome.Location = new System.Drawing.Point(300, 24);
            this.txbCriacaoNome.Name = "txbCriacaoNome";
            this.txbCriacaoNome.Size = new System.Drawing.Size(295, 20);
            this.txbCriacaoNome.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Conteúdo";
            // 
            // txbCriacaoConteudo
            // 
            this.txbCriacaoConteudo.Location = new System.Drawing.Point(300, 72);
            this.txbCriacaoConteudo.Multiline = true;
            this.txbCriacaoConteudo.Name = "txbCriacaoConteudo";
            this.txbCriacaoConteudo.Size = new System.Drawing.Size(295, 56);
            this.txbCriacaoConteudo.TabIndex = 8;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(300, 138);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 10;
            this.btnCriar.Text = "Criar nota";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // FormEX5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 420);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCriacaoConteudo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCriacaoNome);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNotaConteudo);
            this.Controls.Add(this.lbxNotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEX5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEX5";
            this.Load += new System.EventHandler(this.FormEX5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxNotas;
        private System.Windows.Forms.TextBox txbNotaConteudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txbCriacaoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCriacaoConteudo;
        private System.Windows.Forms.Button btnCriar;
    }
}