namespace WindowsFormsExercicios
{
    partial class FormEX2
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
            this.cbxCidades = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.temperatura = new System.Windows.Forms.Label();
            this.sensacao = new System.Windows.Forms.Label();
            this.minima = new System.Windows.Forms.Label();
            this.maxima = new System.Windows.Forms.Label();
            this.cidadeNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxCidades
            // 
            this.cbxCidades.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCidades.FormattingEnabled = true;
            this.cbxCidades.Items.AddRange(new object[] {
            "Americana",
            "Campinas",
            "Limeira"});
            this.cbxCidades.Location = new System.Drawing.Point(10, 30);
            this.cbxCidades.Name = "cbxCidades";
            this.cbxCidades.Size = new System.Drawing.Size(135, 25);
            this.cbxCidades.TabIndex = 0;
            this.cbxCidades.SelectedIndexChanged += new System.EventHandler(this.cbxCidades_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione uma cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Temperatura: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mínima:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sensação:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Máxima:";
            // 
            // temperatura
            // 
            this.temperatura.AutoSize = true;
            this.temperatura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatura.Location = new System.Drawing.Point(100, 110);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(14, 17);
            this.temperatura.TabIndex = 8;
            this.temperatura.Text = "x";
            // 
            // sensacao
            // 
            this.sensacao.AutoSize = true;
            this.sensacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensacao.Location = new System.Drawing.Point(100, 130);
            this.sensacao.Name = "sensacao";
            this.sensacao.Size = new System.Drawing.Size(14, 17);
            this.sensacao.TabIndex = 9;
            this.sensacao.Text = "x";
            // 
            // minima
            // 
            this.minima.AutoSize = true;
            this.minima.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minima.Location = new System.Drawing.Point(100, 150);
            this.minima.Name = "minima";
            this.minima.Size = new System.Drawing.Size(14, 17);
            this.minima.TabIndex = 10;
            this.minima.Text = "x";
            // 
            // maxima
            // 
            this.maxima.AutoSize = true;
            this.maxima.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxima.Location = new System.Drawing.Point(100, 170);
            this.maxima.Name = "maxima";
            this.maxima.Size = new System.Drawing.Size(14, 17);
            this.maxima.TabIndex = 11;
            this.maxima.Text = "x";
            // 
            // cidadeNome
            // 
            this.cidadeNome.AutoSize = true;
            this.cidadeNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeNome.Location = new System.Drawing.Point(100, 90);
            this.cidadeNome.Name = "cidadeNome";
            this.cidadeNome.Size = new System.Drawing.Size(14, 17);
            this.cidadeNome.TabIndex = 13;
            this.cidadeNome.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cidade:";
            // 
            // FormEX2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cidadeNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxima);
            this.Controls.Add(this.minima);
            this.Controls.Add(this.sensacao);
            this.Controls.Add(this.temperatura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEX2";
            this.Text = "FormEX2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label temperatura;
        private System.Windows.Forms.Label sensacao;
        private System.Windows.Forms.Label minima;
        private System.Windows.Forms.Label maxima;
        private System.Windows.Forms.Label cidadeNome;
        private System.Windows.Forms.Label label6;
    }
}