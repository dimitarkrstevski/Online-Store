
namespace OnlineStore
{
    partial class Pocetna
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
            this.SuspendLayout();
            // 
            // Pocetna
            // 
            this.ClientSize = new System.Drawing.Size(287, 263);
            this.Name = "Pocetna";
            this.Load += new System.EventHandler(this.Pocetna_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip glavnoMeni;
        private System.Windows.Forms.ToolStripMenuItem човечкиРесурсиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem внесиВработенToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem извештаиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem извештаиЗаВработениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem годишниИзвештаиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem месечниИзвештаиToolStripMenuItem;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Button btnNajava;
        private System.Windows.Forms.GroupBox gbNajava;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pbPocetna;
    }
}