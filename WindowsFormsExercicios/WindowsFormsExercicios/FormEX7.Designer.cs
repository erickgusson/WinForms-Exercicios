namespace WindowsFormsExercicios
{
    partial class FormEX7
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
            this.components = new System.ComponentModel.Container();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.btnOpcao4 = new System.Windows.Forms.Button();
            this.btnOpcao3 = new System.Windows.Forms.Button();
            this.btnOpcao2 = new System.Windows.Forms.Button();
            this.btnOpcao1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPergunta
            // 
            this.lblPergunta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(50, 28);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(505, 130);
            this.lblPergunta.TabIndex = 14;
            this.lblPergunta.Text = "pergunta";
            this.lblPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpcao4
            // 
            this.btnOpcao4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcao4.Location = new System.Drawing.Point(310, 293);
            this.btnOpcao4.Name = "btnOpcao4";
            this.btnOpcao4.Size = new System.Drawing.Size(275, 100);
            this.btnOpcao4.TabIndex = 13;
            this.btnOpcao4.Text = "4";
            this.btnOpcao4.UseVisualStyleBackColor = true;
            this.btnOpcao4.Click += new System.EventHandler(this.btnOpcao4_Click);
            // 
            // btnOpcao3
            // 
            this.btnOpcao3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcao3.Location = new System.Drawing.Point(20, 293);
            this.btnOpcao3.Name = "btnOpcao3";
            this.btnOpcao3.Size = new System.Drawing.Size(275, 100);
            this.btnOpcao3.TabIndex = 12;
            this.btnOpcao3.Text = "3";
            this.btnOpcao3.UseVisualStyleBackColor = true;
            this.btnOpcao3.Click += new System.EventHandler(this.btnOpcao3_Click);
            // 
            // btnOpcao2
            // 
            this.btnOpcao2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcao2.Location = new System.Drawing.Point(310, 178);
            this.btnOpcao2.Name = "btnOpcao2";
            this.btnOpcao2.Size = new System.Drawing.Size(275, 100);
            this.btnOpcao2.TabIndex = 11;
            this.btnOpcao2.Text = "2";
            this.btnOpcao2.UseVisualStyleBackColor = true;
            this.btnOpcao2.Click += new System.EventHandler(this.btnOpcao2_Click);
            // 
            // btnOpcao1
            // 
            this.btnOpcao1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcao1.Location = new System.Drawing.Point(20, 178);
            this.btnOpcao1.Name = "btnOpcao1";
            this.btnOpcao1.Size = new System.Drawing.Size(275, 100);
            this.btnOpcao1.TabIndex = 10;
            this.btnOpcao1.Text = "1";
            this.btnOpcao1.UseVisualStyleBackColor = true;
            this.btnOpcao1.Click += new System.EventHandler(this.btnOpcao1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormEX7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 420);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.btnOpcao4);
            this.Controls.Add(this.btnOpcao3);
            this.Controls.Add(this.btnOpcao2);
            this.Controls.Add(this.btnOpcao1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEX7";
            this.Text = "FormEX7";
            this.Load += new System.EventHandler(this.FormEX7_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Button btnOpcao4;
        private System.Windows.Forms.Button btnOpcao3;
        private System.Windows.Forms.Button btnOpcao2;
        private System.Windows.Forms.Button btnOpcao1;
        private System.Windows.Forms.Timer timer1;
    }
}