﻿namespace WindowsFormsExercicios
{
    partial class FormDesafio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesafio));
            this.pbxQR = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTexto = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxQR
            // 
            this.pbxQR.Location = new System.Drawing.Point(155, 85);
            this.pbxQR.Name = "pbxQR";
            this.pbxQR.Size = new System.Drawing.Size(295, 295);
            this.pbxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxQR.TabIndex = 0;
            this.pbxQR.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserir texto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbTexto
            // 
            this.txbTexto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTexto.Location = new System.Drawing.Point(10, 55);
            this.txbTexto.Name = "txbTexto";
            this.txbTexto.Size = new System.Drawing.Size(585, 25);
            this.txbTexto.TabIndex = 2;
            this.txbTexto.TextChanged += new System.EventHandler(this.txbTexto_TextChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.White;
            this.btnDownload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.Location = new System.Drawing.Point(0, 385);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(605, 35);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // FormDesafio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 420);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txbTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxQR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDesafio";
            this.Text = "FormDesafio";
            ((System.ComponentModel.ISupportInitialize)(this.pbxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxQR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTexto;
        private System.Windows.Forms.Button btnDownload;
    }
}