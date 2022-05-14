
namespace OnlineStore
{
    partial class HRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRM));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbVnesiVraboten = new System.Windows.Forms.TabPage();
            this.lblErrTel = new System.Windows.Forms.Label();
            this.lblerrEMBG = new System.Windows.Forms.Label();
            this.lblerrImePrezime = new System.Windows.Forms.Label();
            this.lblNevalidnaEmailAdresa = new System.Windows.Forms.Label();
            this.lblNevalidnaVozrast = new System.Windows.Forms.Label();
            this.btnVnesi = new System.Windows.Forms.Button();
            this.gbVnesiInformaciiZaVraboten = new System.Windows.Forms.GroupBox();
            this.llblDokumenti = new System.Windows.Forms.LinkLabel();
            this.lblUslovi = new System.Windows.Forms.Label();
            this.cbUslovi = new System.Windows.Forms.CheckBox();
            this.lblKodVraboten = new System.Windows.Forms.Label();
            this.tbKodVraboten = new System.Windows.Forms.TextBox();
            this.lblEMBG = new System.Windows.Forms.Label();
            this.tbEMBG = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lblVozrast = new System.Windows.Forms.Label();
            this.tbVozrast = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.mtbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblGrad = new System.Windows.Forms.Label();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbPrebarajVraboten = new System.Windows.Forms.TabPage();
            this.errPVozrast = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPEMBG = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbVnesiVraboten.SuspendLayout();
            this.gbVnesiInformaciiZaVraboten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPVozrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPEMBG)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbVnesiVraboten);
            this.tabControl1.Controls.Add(this.tbPrebarajVraboten);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(944, 474);
            this.tabControl1.TabIndex = 0;
            // 
            // tbVnesiVraboten
            // 
            this.tbVnesiVraboten.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbVnesiVraboten.Controls.Add(this.lblErrTel);
            this.tbVnesiVraboten.Controls.Add(this.lblerrEMBG);
            this.tbVnesiVraboten.Controls.Add(this.lblerrImePrezime);
            this.tbVnesiVraboten.Controls.Add(this.lblNevalidnaEmailAdresa);
            this.tbVnesiVraboten.Controls.Add(this.lblNevalidnaVozrast);
            this.tbVnesiVraboten.Controls.Add(this.btnVnesi);
            this.tbVnesiVraboten.Controls.Add(this.gbVnesiInformaciiZaVraboten);
            this.tbVnesiVraboten.Location = new System.Drawing.Point(4, 22);
            this.tbVnesiVraboten.Name = "tbVnesiVraboten";
            this.tbVnesiVraboten.Padding = new System.Windows.Forms.Padding(3);
            this.tbVnesiVraboten.Size = new System.Drawing.Size(936, 448);
            this.tbVnesiVraboten.TabIndex = 0;
            this.tbVnesiVraboten.Text = "Внеси вработен";
            // 
            // lblErrTel
            // 
            this.lblErrTel.AutoSize = true;
            this.lblErrTel.Location = new System.Drawing.Point(618, 143);
            this.lblErrTel.Name = "lblErrTel";
            this.lblErrTel.Size = new System.Drawing.Size(0, 13);
            this.lblErrTel.TabIndex = 5;
            // 
            // lblerrEMBG
            // 
            this.lblerrEMBG.AutoSize = true;
            this.lblerrEMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrEMBG.ForeColor = System.Drawing.Color.Red;
            this.lblerrEMBG.Location = new System.Drawing.Point(624, 237);
            this.lblerrEMBG.Name = "lblerrEMBG";
            this.lblerrEMBG.Size = new System.Drawing.Size(0, 13);
            this.lblerrEMBG.TabIndex = 4;
            // 
            // lblerrImePrezime
            // 
            this.lblerrImePrezime.AutoSize = true;
            this.lblerrImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrImePrezime.ForeColor = System.Drawing.Color.Red;
            this.lblerrImePrezime.Location = new System.Drawing.Point(606, 25);
            this.lblerrImePrezime.Name = "lblerrImePrezime";
            this.lblerrImePrezime.Size = new System.Drawing.Size(0, 13);
            this.lblerrImePrezime.TabIndex = 3;
            // 
            // lblNevalidnaEmailAdresa
            // 
            this.lblNevalidnaEmailAdresa.AutoSize = true;
            this.lblNevalidnaEmailAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNevalidnaEmailAdresa.ForeColor = System.Drawing.Color.Red;
            this.lblNevalidnaEmailAdresa.Location = new System.Drawing.Point(612, 176);
            this.lblNevalidnaEmailAdresa.Name = "lblNevalidnaEmailAdresa";
            this.lblNevalidnaEmailAdresa.Size = new System.Drawing.Size(125, 26);
            this.lblNevalidnaEmailAdresa.TabIndex = 2;
            this.lblNevalidnaEmailAdresa.Text = "Невалидно внесена\r\n     Е-mail адреса!";
            this.lblNevalidnaEmailAdresa.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNevalidnaVozrast
            // 
            this.lblNevalidnaVozrast.AutoSize = true;
            this.lblNevalidnaVozrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNevalidnaVozrast.ForeColor = System.Drawing.Color.Red;
            this.lblNevalidnaVozrast.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNevalidnaVozrast.Location = new System.Drawing.Point(612, 143);
            this.lblNevalidnaVozrast.Name = "lblNevalidnaVozrast";
            this.lblNevalidnaVozrast.Size = new System.Drawing.Size(0, 13);
            this.lblNevalidnaVozrast.TabIndex = 1;
            // 
            // btnVnesi
            // 
            this.btnVnesi.Location = new System.Drawing.Point(612, 310);
            this.btnVnesi.Name = "btnVnesi";
            this.btnVnesi.Size = new System.Drawing.Size(122, 36);
            this.btnVnesi.TabIndex = 1;
            this.btnVnesi.Text = "ВНЕСИ:";
            this.btnVnesi.UseVisualStyleBackColor = true;
            this.btnVnesi.Click += new System.EventHandler(this.btnVnesi_Click);
            this.btnVnesi.Validating += new System.ComponentModel.CancelEventHandler(this.btnVnesi_Validating);
            // 
            // gbVnesiInformaciiZaVraboten
            // 
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.button1);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.llblDokumenti);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.lblUslovi);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.cbUslovi);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.lblKodVraboten);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.tbKodVraboten);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.lblEMBG);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.tbEMBG);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.lblEmail);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.tbEmail);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.lblIme);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.tbIme);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.lblVozrast);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.tbVozrast);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.lblTelefon);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.mtbTelefon);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.lblGrad);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.tbGrad);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.lblAdresa);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.tbAdresa);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.lblPrezime);
            this.gbVnesiInformaciiZaVraboten.Controls.Add(this.tbPrezime);
            this.gbVnesiInformaciiZaVraboten.Location = new System.Drawing.Point(8, 6);
            this.gbVnesiInformaciiZaVraboten.Name = "gbVnesiInformaciiZaVraboten";
            this.gbVnesiInformaciiZaVraboten.Size = new System.Drawing.Size(577, 340);
            this.gbVnesiInformaciiZaVraboten.TabIndex = 0;
            this.gbVnesiInformaciiZaVraboten.TabStop = false;
            this.gbVnesiInformaciiZaVraboten.Text = "Внеси информации за вработен";
            this.gbVnesiInformaciiZaVraboten.Enter += new System.EventHandler(this.gbVnesiInformaciiZaVraboten_Enter);
            // 
            // llblDokumenti
            // 
            this.llblDokumenti.AutoSize = true;
            this.llblDokumenti.Location = new System.Drawing.Point(130, 304);
            this.llblDokumenti.Name = "llblDokumenti";
            this.llblDokumenti.Size = new System.Drawing.Size(64, 13);
            this.llblDokumenti.TabIndex = 23;
            this.llblDokumenti.TabStop = true;
            this.llblDokumenti.Text = "Документи";
            this.llblDokumenti.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblUslovi_LinkClicked);
            // 
            // lblUslovi
            // 
            this.lblUslovi.AutoSize = true;
            this.lblUslovi.Location = new System.Drawing.Point(64, 304);
            this.lblUslovi.Name = "lblUslovi";
            this.lblUslovi.Size = new System.Drawing.Size(60, 13);
            this.lblUslovi.TabIndex = 22;
            this.lblUslovi.Text = "доставени";
            // 
            // cbUslovi
            // 
            this.cbUslovi.AutoSize = true;
            this.cbUslovi.Location = new System.Drawing.Point(43, 304);
            this.cbUslovi.Name = "cbUslovi";
            this.cbUslovi.Size = new System.Drawing.Size(15, 14);
            this.cbUslovi.TabIndex = 20;
            this.cbUslovi.UseVisualStyleBackColor = true;
            this.cbUslovi.CheckedChanged += new System.EventHandler(this.cbUslovi_CheckedChanged);
            // 
            // lblKodVraboten
            // 
            this.lblKodVraboten.AutoSize = true;
            this.lblKodVraboten.Location = new System.Drawing.Point(11, 231);
            this.lblKodVraboten.Name = "lblKodVraboten";
            this.lblKodVraboten.Size = new System.Drawing.Size(97, 13);
            this.lblKodVraboten.TabIndex = 19;
            this.lblKodVraboten.Text = "Код на вработен :";
            // 
            // tbKodVraboten
            // 
            this.tbKodVraboten.Location = new System.Drawing.Point(114, 224);
            this.tbKodVraboten.MaxLength = 9;
            this.tbKodVraboten.Name = "tbKodVraboten";
            this.tbKodVraboten.Size = new System.Drawing.Size(152, 20);
            this.tbKodVraboten.TabIndex = 8;
            this.tbKodVraboten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKodVraboten_KeyPress);
            // 
            // lblEMBG
            // 
            this.lblEMBG.AutoSize = true;
            this.lblEMBG.Location = new System.Drawing.Point(300, 183);
            this.lblEMBG.Name = "lblEMBG";
            this.lblEMBG.Size = new System.Drawing.Size(39, 13);
            this.lblEMBG.TabIndex = 17;
            this.lblEMBG.Text = "ЕМБГ:";
            // 
            // tbEMBG
            // 
            this.tbEMBG.Location = new System.Drawing.Point(362, 176);
            this.tbEMBG.MaxLength = 13;
            this.tbEMBG.Name = "tbEMBG";
            this.tbEMBG.Size = new System.Drawing.Size(152, 20);
            this.tbEMBG.TabIndex = 7;
            this.tbEMBG.TextChanged += new System.EventHandler(this.tbEMBG_TextChanged);
            this.tbEMBG.Validating += new System.ComponentModel.CancelEventHandler(this.tbEMBG_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 183);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "E-mail:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(114, 176);
            this.tbEmail.MaxLength = 15;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(152, 20);
            this.tbEmail.TabIndex = 6;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(11, 39);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 13);
            this.lblIme.TabIndex = 13;
            this.lblIme.Text = "Име:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(114, 32);
            this.tbIme.MaxLength = 15;
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(152, 20);
            this.tbIme.TabIndex = 0;
            // 
            // lblVozrast
            // 
            this.lblVozrast.AutoSize = true;
            this.lblVozrast.Location = new System.Drawing.Point(300, 130);
            this.lblVozrast.Name = "lblVozrast";
            this.lblVozrast.Size = new System.Drawing.Size(52, 13);
            this.lblVozrast.TabIndex = 11;
            this.lblVozrast.Text = "Возраст:";
            // 
            // tbVozrast
            // 
            this.tbVozrast.Location = new System.Drawing.Point(362, 127);
            this.tbVozrast.Name = "tbVozrast";
            this.tbVozrast.Size = new System.Drawing.Size(152, 20);
            this.tbVozrast.TabIndex = 5;
            this.tbVozrast.TextChanged += new System.EventHandler(this.tbVozrast_TextChanged);
            this.tbVozrast.Validating += new System.ComponentModel.CancelEventHandler(this.tbVozrast_Validating);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(11, 134);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(55, 13);
            this.lblTelefon.TabIndex = 9;
            this.lblTelefon.Text = "Телефон:";
            // 
            // mtbTelefon
            // 
            this.mtbTelefon.Location = new System.Drawing.Point(114, 130);
            this.mtbTelefon.Mask = "999 - 000 - 000";
            this.mtbTelefon.Name = "mtbTelefon";
            this.mtbTelefon.Size = new System.Drawing.Size(152, 20);
            this.mtbTelefon.TabIndex = 4;
            this.mtbTelefon.Text = "07";
            this.mtbTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbTelefon_MaskInputRejected);
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Location = new System.Drawing.Point(300, 86);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(34, 13);
            this.lblGrad.TabIndex = 7;
            this.lblGrad.Text = "Град:";
            // 
            // tbGrad
            // 
            this.tbGrad.AutoCompleteCustomSource.AddRange(new string[] {
            "Велес",
            "Демир Капија",
            "Кавадарци",
            "Неготино",
            "Св.Николе",
            "Берово",
            "Виница",
            "Делчево",
            "Кочани",
            "Македонска Каменица",
            "Пехчево",
            "Пробиштип",
            "Штип",
            "Дебар",
            "Македонски Брод",
            "Охрид",
            "Кичево",
            "Струга ",
            "Богадници",
            "Валандово",
            "Гевгелија",
            "Радовиш",
            "Струмица",
            "Битола",
            "Демир Хисар",
            "Крушево",
            "Прилеп",
            "Ресен",
            "Гостивар",
            "Тетово",
            "Кратово",
            "Крива Паланка",
            "Куманово",
            "Скопје"});
            this.tbGrad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbGrad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbGrad.Location = new System.Drawing.Point(362, 79);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(152, 20);
            this.tbGrad.TabIndex = 3;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(11, 86);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(47, 13);
            this.lblAdresa.TabIndex = 5;
            this.lblAdresa.Text = "Адреса:";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(114, 83);
            this.tbAdresa.MaxLength = 120;
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(152, 20);
            this.tbAdresa.TabIndex = 2;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(300, 32);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(56, 13);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Презиме:";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(362, 28);
            this.tbPrezime.MaxLength = 15;
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(152, 20);
            this.tbPrezime.TabIndex = 1;
            // 
            // tbPrebarajVraboten
            // 
            this.tbPrebarajVraboten.Location = new System.Drawing.Point(4, 22);
            this.tbPrebarajVraboten.Name = "tbPrebarajVraboten";
            this.tbPrebarajVraboten.Padding = new System.Windows.Forms.Padding(3);
            this.tbPrebarajVraboten.Size = new System.Drawing.Size(936, 448);
            this.tbPrebarajVraboten.TabIndex = 1;
            this.tbPrebarajVraboten.Text = "Пребарај вработен";
            this.tbPrebarajVraboten.UseVisualStyleBackColor = true;
            // 
            // errPVozrast
            // 
            this.errPVozrast.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errPVozrast.ContainerControl = this;
            // 
            // errPEmail
            // 
            this.errPEmail.ContainerControl = this;
            // 
            // errPEMBG
            // 
            this.errPEMBG.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 471);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HRM";
            this.Text = "Управување со човечки ресурси";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbVnesiVraboten.ResumeLayout(false);
            this.tbVnesiVraboten.PerformLayout();
            this.gbVnesiInformaciiZaVraboten.ResumeLayout(false);
            this.gbVnesiInformaciiZaVraboten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPVozrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPEMBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbVnesiVraboten;
        private System.Windows.Forms.TabPage tbPrebarajVraboten;
        private System.Windows.Forms.GroupBox gbVnesiInformaciiZaVraboten;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Button btnVnesi;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.MaskedTextBox mtbTelefon;
        private System.Windows.Forms.Label lblVozrast;
        private System.Windows.Forms.TextBox tbVozrast;
        private System.Windows.Forms.ErrorProvider errPVozrast;
        private System.Windows.Forms.Label lblNevalidnaVozrast;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.ErrorProvider errPEmail;
        private System.Windows.Forms.Label lblNevalidnaEmailAdresa;
        private System.Windows.Forms.Label lblKodVraboten;
        private System.Windows.Forms.TextBox tbKodVraboten;
        private System.Windows.Forms.Label lblEMBG;
        private System.Windows.Forms.TextBox tbEMBG;
        private System.Windows.Forms.CheckBox cbUslovi;
        private System.Windows.Forms.ErrorProvider errPEMBG;
        private System.Windows.Forms.LinkLabel llblDokumenti;
        private System.Windows.Forms.Label lblUslovi;
        private System.Windows.Forms.Label lblerrImePrezime;
        private System.Windows.Forms.Label lblerrEMBG;
        private System.Windows.Forms.Label lblErrTel;
        private System.Windows.Forms.Button button1;
    }
}

