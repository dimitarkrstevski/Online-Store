﻿
namespace OnlineStore
{
    partial class Dokumenti
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
            this.tbDokumenti = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbDokumenti
            // 
            this.tbDokumenti.Location = new System.Drawing.Point(12, 12);
            this.tbDokumenti.Multiline = true;
            this.tbDokumenti.Name = "tbDokumenti";
            this.tbDokumenti.ReadOnly = true;
            this.tbDokumenti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDokumenti.Size = new System.Drawing.Size(776, 426);
            this.tbDokumenti.TabIndex = 0;
            this.tbDokumenti.Text = "1. Изјава за почитување на правилникот.\r\n2. Изјава за почитување на кодексот.\r\n3." +
    " М1/М2 образец.\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDokumenti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDokumenti;
    }
}