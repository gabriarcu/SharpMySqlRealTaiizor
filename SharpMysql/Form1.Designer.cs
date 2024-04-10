namespace SharpMysql
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.airTabPage1 = new ReaLTaiizor.Controls.AirTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new ReaLTaiizor.Controls.HopeGroupBox();
            this.txt_idgenere = new ReaLTaiizor.Controls.SkyTextBox();
            this.skyLabel4 = new ReaLTaiizor.Controls.SkyLabel();
            this.txt_nome = new ReaLTaiizor.Controls.SkyTextBox();
            this.skyLabel3 = new ReaLTaiizor.Controls.SkyLabel();
            this.txt_trama = new ReaLTaiizor.Controls.SkyTextBox();
            this.skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            this.txt_id = new ReaLTaiizor.Controls.SkyTextBox();
            this.skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            this.groupBox1 = new ReaLTaiizor.Controls.HopeGroupBox();
            this.btn_elimina = new ReaLTaiizor.Controls.SkyButton();
            this.btn_modifica = new ReaLTaiizor.Controls.SkyButton();
            this.DataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.skyLabel5 = new ReaLTaiizor.Controls.SkyLabel();
            this.n_ora = new ReaLTaiizor.Controls.SkyNumeric();
            this.n_minuti = new ReaLTaiizor.Controls.SkyNumeric();
            this.skyLabel6 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel7 = new ReaLTaiizor.Controls.SkyLabel();
            this.dateTimePicker1 = new ReaLTaiizor.Controls.PoisonDateTime();
            this.btn_annulla = new ReaLTaiizor.Controls.SkyButton();
            this.btn_salva = new ReaLTaiizor.Controls.SkyButton();
            this.btn_esci = new ReaLTaiizor.Controls.SkyButton();
            this.btn_nuovo = new ReaLTaiizor.Controls.SkyButton();
            this.aloneNotice1 = new ReaLTaiizor.Controls.AloneNotice();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.airTabPage1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // airTabPage1
            // 
            this.airTabPage1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.airTabPage1.BaseColor = System.Drawing.Color.SteelBlue;
            this.airTabPage1.Controls.Add(this.tabPage1);
            this.airTabPage1.Controls.Add(this.tabPage2);
            this.airTabPage1.Controls.Add(this.tabPage3);
            this.airTabPage1.Controls.Add(this.tabPage4);
            this.airTabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.airTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airTabPage1.ItemSize = new System.Drawing.Size(50, 115);
            this.airTabPage1.Location = new System.Drawing.Point(0, 0);
            this.airTabPage1.Multiline = true;
            this.airTabPage1.Name = "airTabPage1";
            this.airTabPage1.NormalTextColor = System.Drawing.Color.LightGray;
            this.airTabPage1.SelectedIndex = 0;
            this.airTabPage1.SelectedTabBackColor = System.Drawing.Color.White;
            this.airTabPage1.SelectedTextColor = System.Drawing.Color.Black;
            this.airTabPage1.ShowOuterBorders = false;
            this.airTabPage1.Size = new System.Drawing.Size(1086, 700);
            this.airTabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.airTabPage1.SquareColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.airTabPage1.TabCursor = System.Windows.Forms.Cursors.Hand;
            this.airTabPage1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.DataGridView1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(119, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(963, 692);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.groupBox2.Controls.Add(this.aloneNotice1);
            this.groupBox2.Controls.Add(this.btn_salva);
            this.groupBox2.Controls.Add(this.btn_annulla);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.skyLabel7);
            this.groupBox2.Controls.Add(this.skyLabel6);
            this.groupBox2.Controls.Add(this.n_minuti);
            this.groupBox2.Controls.Add(this.n_ora);
            this.groupBox2.Controls.Add(this.skyLabel5);
            this.groupBox2.Controls.Add(this.txt_idgenere);
            this.groupBox2.Controls.Add(this.skyLabel4);
            this.groupBox2.Controls.Add(this.txt_nome);
            this.groupBox2.Controls.Add(this.skyLabel3);
            this.groupBox2.Controls.Add(this.txt_trama);
            this.groupBox2.Controls.Add(this.skyLabel1);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.skyLabel2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.groupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.groupBox2.Location = new System.Drawing.Point(362, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.ShowText = false;
            this.groupBox2.Size = new System.Drawing.Size(544, 427);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disable";
            this.groupBox2.ThemeColor = System.Drawing.Color.SteelBlue;
            // 
            // txt_idgenere
            // 
            this.txt_idgenere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.txt_idgenere.BaseColor = System.Drawing.Color.Transparent;
            this.txt_idgenere.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_idgenere.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_idgenere.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txt_idgenere.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txt_idgenere.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idgenere.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_idgenere.Location = new System.Drawing.Point(12, 280);
            this.txt_idgenere.MaxLength = 32767;
            this.txt_idgenere.MultiLine = false;
            this.txt_idgenere.Name = "txt_idgenere";
            this.txt_idgenere.Size = new System.Drawing.Size(255, 31);
            this.txt_idgenere.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_idgenere.TabIndex = 18;
            this.txt_idgenere.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_idgenere.UnknownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txt_idgenere.UseSystemPasswordChar = false;
            // 
            // skyLabel4
            // 
            this.skyLabel4.AutoSize = true;
            this.skyLabel4.BackColor = System.Drawing.Color.SteelBlue;
            this.skyLabel4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel4.ForeColor = System.Drawing.Color.White;
            this.skyLabel4.Location = new System.Drawing.Point(284, 285);
            this.skyLabel4.Name = "skyLabel4";
            this.skyLabel4.Size = new System.Drawing.Size(76, 20);
            this.skyLabel4.TabIndex = 17;
            this.skyLabel4.Text = "Genere";
            this.skyLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.txt_nome.BaseColor = System.Drawing.Color.Transparent;
            this.txt_nome.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_nome.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_nome.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txt_nome.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txt_nome.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_nome.Location = new System.Drawing.Point(12, 71);
            this.txt_nome.MaxLength = 32767;
            this.txt_nome.MultiLine = false;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(255, 31);
            this.txt_nome.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_nome.TabIndex = 16;
            this.txt_nome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nome.UnknownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txt_nome.UseSystemPasswordChar = false;
            // 
            // skyLabel3
            // 
            this.skyLabel3.AutoSize = true;
            this.skyLabel3.BackColor = System.Drawing.Color.SteelBlue;
            this.skyLabel3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel3.ForeColor = System.Drawing.Color.White;
            this.skyLabel3.Location = new System.Drawing.Point(284, 76);
            this.skyLabel3.Name = "skyLabel3";
            this.skyLabel3.Size = new System.Drawing.Size(64, 20);
            this.skyLabel3.TabIndex = 15;
            this.skyLabel3.Text = "Nome";
            this.skyLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_trama
            // 
            this.txt_trama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.txt_trama.BaseColor = System.Drawing.Color.Transparent;
            this.txt_trama.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_trama.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_trama.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txt_trama.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txt_trama.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trama.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_trama.Location = new System.Drawing.Point(12, 123);
            this.txt_trama.MaxLength = 32767;
            this.txt_trama.MultiLine = true;
            this.txt_trama.Name = "txt_trama";
            this.txt_trama.Size = new System.Drawing.Size(432, 31);
            this.txt_trama.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_trama.TabIndex = 14;
            this.txt_trama.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_trama.UnknownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txt_trama.UseSystemPasswordChar = false;
            // 
            // skyLabel1
            // 
            this.skyLabel1.AutoSize = true;
            this.skyLabel1.BackColor = System.Drawing.Color.SteelBlue;
            this.skyLabel1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel1.ForeColor = System.Drawing.Color.White;
            this.skyLabel1.Location = new System.Drawing.Point(461, 128);
            this.skyLabel1.Name = "skyLabel1";
            this.skyLabel1.Size = new System.Drawing.Size(69, 20);
            this.skyLabel1.TabIndex = 13;
            this.skyLabel1.Text = "Trama";
            this.skyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.txt_id.BaseColor = System.Drawing.Color.Transparent;
            this.txt_id.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_id.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.txt_id.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.txt_id.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_id.Location = new System.Drawing.Point(12, 22);
            this.txt_id.MaxLength = 32767;
            this.txt_id.MultiLine = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(255, 31);
            this.txt_id.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_id.TabIndex = 12;
            this.txt_id.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_id.UnknownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txt_id.UseSystemPasswordChar = false;
            // 
            // skyLabel2
            // 
            this.skyLabel2.AutoSize = true;
            this.skyLabel2.BackColor = System.Drawing.Color.SteelBlue;
            this.skyLabel2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel2.ForeColor = System.Drawing.Color.White;
            this.skyLabel2.Location = new System.Drawing.Point(284, 27);
            this.skyLabel2.Name = "skyLabel2";
            this.skyLabel2.Size = new System.Drawing.Size(30, 20);
            this.skyLabel2.TabIndex = 11;
            this.skyLabel2.Text = "Id";
            this.skyLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.groupBox1.Controls.Add(this.btn_nuovo);
            this.groupBox1.Controls.Add(this.btn_esci);
            this.groupBox1.Controls.Add(this.btn_elimina);
            this.groupBox1.Controls.Add(this.btn_modifica);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.groupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.ShowText = false;
            this.groupBox1.Size = new System.Drawing.Size(350, 427);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "hopeGroupBox1";
            this.groupBox1.ThemeColor = System.Drawing.Color.SteelBlue;
            // 
            // btn_elimina
            // 
            this.btn_elimina.BackColor = System.Drawing.Color.Transparent;
            this.btn_elimina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_elimina.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.btn_elimina.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.btn_elimina.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btn_elimina.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btn_elimina.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.btn_elimina.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btn_elimina.DownForeColor = System.Drawing.Color.White;
            this.btn_elimina.DownShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_elimina.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elimina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.btn_elimina.HoverBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.btn_elimina.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.btn_elimina.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btn_elimina.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btn_elimina.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.btn_elimina.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btn_elimina.HoverForeColor = System.Drawing.Color.White;
            this.btn_elimina.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_elimina.Location = new System.Drawing.Point(177, 20);
            this.btn_elimina.Name = "btn_elimina";
            this.btn_elimina.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btn_elimina.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_elimina.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_elimina.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_elimina.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btn_elimina.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btn_elimina.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.btn_elimina.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_elimina.Size = new System.Drawing.Size(156, 40);
            this.btn_elimina.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_elimina.TabIndex = 1;
            this.btn_elimina.Text = "Elimina";
            this.btn_elimina.Click += new System.EventHandler(this.btn_elimina_Click);
            // 
            // btn_modifica
            // 
            this.btn_modifica.BackColor = System.Drawing.Color.Transparent;
            this.btn_modifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modifica.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.btn_modifica.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.btn_modifica.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btn_modifica.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btn_modifica.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.btn_modifica.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btn_modifica.DownForeColor = System.Drawing.Color.White;
            this.btn_modifica.DownShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_modifica.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.btn_modifica.HoverBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.btn_modifica.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.btn_modifica.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btn_modifica.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btn_modifica.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.btn_modifica.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btn_modifica.HoverForeColor = System.Drawing.Color.White;
            this.btn_modifica.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_modifica.Location = new System.Drawing.Point(15, 20);
            this.btn_modifica.Name = "btn_modifica";
            this.btn_modifica.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btn_modifica.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_modifica.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_modifica.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_modifica.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btn_modifica.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btn_modifica.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.btn_modifica.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_modifica.Size = new System.Drawing.Size(156, 40);
            this.btn_modifica.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_modifica.TabIndex = 0;
            this.btn_modifica.Text = "Modifica";
            this.btn_modifica.Click += new System.EventHandler(this.btn_modifica_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridView1.Location = new System.Drawing.Point(6, 6);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(900, 217);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(119, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(963, 692);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attori";
            // 
            // skyLabel5
            // 
            this.skyLabel5.AutoSize = true;
            this.skyLabel5.BackColor = System.Drawing.Color.SteelBlue;
            this.skyLabel5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel5.ForeColor = System.Drawing.Color.White;
            this.skyLabel5.Location = new System.Drawing.Point(207, 180);
            this.skyLabel5.Name = "skyLabel5";
            this.skyLabel5.Size = new System.Drawing.Size(73, 20);
            this.skyLabel5.TabIndex = 19;
            this.skyLabel5.Text = "Durata";
            this.skyLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // n_ora
            // 
            this.n_ora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.n_ora.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.n_ora.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.n_ora.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.n_ora.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.n_ora.BotTriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.n_ora.ButtonBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.n_ora.ButtonBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.n_ora.ButtonBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.n_ora.ButtonBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.n_ora.ButtonBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.n_ora.ButtonBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.n_ora.ButtonBorderColorE = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.n_ora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.n_ora.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_ora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.n_ora.Location = new System.Drawing.Point(12, 175);
            this.n_ora.Maximum = ((long)(9999999));
            this.n_ora.Minimum = ((long)(0));
            this.n_ora.Name = "n_ora";
            this.n_ora.Size = new System.Drawing.Size(75, 30);
            this.n_ora.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.n_ora.TabIndex = 25;
            this.n_ora.Text = "skyNumeric1";
            this.n_ora.TopTriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.n_ora.Value = ((long)(0));
            // 
            // n_minuti
            // 
            this.n_minuti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.n_minuti.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.n_minuti.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.n_minuti.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.n_minuti.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.n_minuti.BotTriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.n_minuti.ButtonBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.n_minuti.ButtonBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.n_minuti.ButtonBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.n_minuti.ButtonBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.n_minuti.ButtonBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.n_minuti.ButtonBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.n_minuti.ButtonBorderColorE = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.n_minuti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.n_minuti.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_minuti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.n_minuti.Location = new System.Drawing.Point(115, 175);
            this.n_minuti.Maximum = ((long)(9999999));
            this.n_minuti.Minimum = ((long)(0));
            this.n_minuti.Name = "n_minuti";
            this.n_minuti.Size = new System.Drawing.Size(75, 30);
            this.n_minuti.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.n_minuti.TabIndex = 26;
            this.n_minuti.Text = "skyNumeric2";
            this.n_minuti.TopTriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.n_minuti.Value = ((long)(0));
            // 
            // skyLabel6
            // 
            this.skyLabel6.AutoSize = true;
            this.skyLabel6.BackColor = System.Drawing.Color.SteelBlue;
            this.skyLabel6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel6.ForeColor = System.Drawing.Color.White;
            this.skyLabel6.Location = new System.Drawing.Point(93, 180);
            this.skyLabel6.Name = "skyLabel6";
            this.skyLabel6.Size = new System.Drawing.Size(16, 20);
            this.skyLabel6.TabIndex = 27;
            this.skyLabel6.Text = ":";
            this.skyLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skyLabel7
            // 
            this.skyLabel7.AutoSize = true;
            this.skyLabel7.BackColor = System.Drawing.Color.SteelBlue;
            this.skyLabel7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel7.ForeColor = System.Drawing.Color.White;
            this.skyLabel7.Location = new System.Drawing.Point(232, 234);
            this.skyLabel7.Name = "skyLabel7";
            this.skyLabel7.Size = new System.Drawing.Size(140, 20);
            this.skyLabel7.TabIndex = 28;
            this.skyLabel7.Text = "Data di uscita";
            this.skyLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 227);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 34);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // btn_annulla
            // 
            this.btn_annulla.BackColor = System.Drawing.Color.Transparent;
            this.btn_annulla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_annulla.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.btn_annulla.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.btn_annulla.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btn_annulla.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btn_annulla.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.btn_annulla.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btn_annulla.DownForeColor = System.Drawing.Color.White;
            this.btn_annulla.DownShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_annulla.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annulla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.btn_annulla.HoverBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.btn_annulla.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.btn_annulla.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btn_annulla.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btn_annulla.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.btn_annulla.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btn_annulla.HoverForeColor = System.Drawing.Color.White;
            this.btn_annulla.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_annulla.Location = new System.Drawing.Point(333, 367);
            this.btn_annulla.Name = "btn_annulla";
            this.btn_annulla.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btn_annulla.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_annulla.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_annulla.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_annulla.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btn_annulla.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btn_annulla.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.btn_annulla.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_annulla.Size = new System.Drawing.Size(89, 40);
            this.btn_annulla.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_annulla.TabIndex = 30;
            this.btn_annulla.Text = "Annulla";
            this.btn_annulla.Click += new System.EventHandler(this.btn_annulla_Click);
            // 
            // btn_salva
            // 
            this.btn_salva.BackColor = System.Drawing.Color.Red;
            this.btn_salva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salva.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.btn_salva.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.btn_salva.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btn_salva.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btn_salva.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.btn_salva.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btn_salva.DownForeColor = System.Drawing.Color.White;
            this.btn_salva.DownShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_salva.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.btn_salva.HoverBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.btn_salva.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.btn_salva.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btn_salva.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btn_salva.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.btn_salva.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btn_salva.HoverForeColor = System.Drawing.Color.White;
            this.btn_salva.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_salva.Location = new System.Drawing.Point(439, 367);
            this.btn_salva.Name = "btn_salva";
            this.btn_salva.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btn_salva.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_salva.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_salva.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_salva.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btn_salva.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btn_salva.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.btn_salva.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_salva.Size = new System.Drawing.Size(89, 40);
            this.btn_salva.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_salva.TabIndex = 31;
            this.btn_salva.Text = "Salva";
            this.btn_salva.Click += new System.EventHandler(this.btn_salva_Click);
            // 
            // btn_esci
            // 
            this.btn_esci.BackColor = System.Drawing.Color.Transparent;
            this.btn_esci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_esci.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.btn_esci.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.btn_esci.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btn_esci.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btn_esci.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.btn_esci.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btn_esci.DownForeColor = System.Drawing.Color.White;
            this.btn_esci.DownShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_esci.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_esci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.btn_esci.HoverBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.btn_esci.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.btn_esci.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btn_esci.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btn_esci.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.btn_esci.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btn_esci.HoverForeColor = System.Drawing.Color.White;
            this.btn_esci.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_esci.Location = new System.Drawing.Point(15, 367);
            this.btn_esci.Name = "btn_esci";
            this.btn_esci.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btn_esci.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_esci.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_esci.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_esci.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btn_esci.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btn_esci.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.btn_esci.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_esci.Size = new System.Drawing.Size(318, 40);
            this.btn_esci.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_esci.TabIndex = 32;
            this.btn_esci.Text = "Esci";
            this.btn_esci.Click += new System.EventHandler(this.btn_esci_Click);
            // 
            // btn_nuovo
            // 
            this.btn_nuovo.BackColor = System.Drawing.Color.Transparent;
            this.btn_nuovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuovo.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.btn_nuovo.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.btn_nuovo.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btn_nuovo.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btn_nuovo.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.btn_nuovo.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btn_nuovo.DownForeColor = System.Drawing.Color.White;
            this.btn_nuovo.DownShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_nuovo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.btn_nuovo.HoverBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.btn_nuovo.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.btn_nuovo.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.btn_nuovo.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.btn_nuovo.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.btn_nuovo.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.btn_nuovo.HoverForeColor = System.Drawing.Color.White;
            this.btn_nuovo.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_nuovo.Location = new System.Drawing.Point(15, 97);
            this.btn_nuovo.Name = "btn_nuovo";
            this.btn_nuovo.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btn_nuovo.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_nuovo.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_nuovo.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_nuovo.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btn_nuovo.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btn_nuovo.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.btn_nuovo.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_nuovo.Size = new System.Drawing.Size(318, 40);
            this.btn_nuovo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btn_nuovo.TabIndex = 33;
            this.btn_nuovo.Text = "Nuovo Film";
            this.btn_nuovo.Click += new System.EventHandler(this.btn_nuovo_Click);
            // 
            // aloneNotice1
            // 
            this.aloneNotice1.BackColor = System.Drawing.Color.SteelBlue;
            this.aloneNotice1.BorderColor = System.Drawing.Color.White;
            this.aloneNotice1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aloneNotice1.Cursor = System.Windows.Forms.Cursors.Default;
            this.aloneNotice1.Enabled = false;
            this.aloneNotice1.ForeColor = System.Drawing.Color.White;
            this.aloneNotice1.Location = new System.Drawing.Point(428, 6);
            this.aloneNotice1.Multiline = true;
            this.aloneNotice1.Name = "aloneNotice1";
            this.aloneNotice1.ReadOnly = true;
            this.aloneNotice1.Size = new System.Drawing.Size(110, 34);
            this.aloneNotice1.TabIndex = 34;
            this.aloneNotice1.Text = "Disable";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.Location = new System.Drawing.Point(119, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(963, 692);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generi";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage4.Location = new System.Drawing.Point(119, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(963, 692);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Attori - Film";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 700);
            this.Controls.Add(this.airTabPage1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione Film";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.airTabPage1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.AirTabPage airTabPage1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ReaLTaiizor.Controls.PoisonDataGridView DataGridView1;
        private ReaLTaiizor.Controls.HopeGroupBox groupBox1;
        private ReaLTaiizor.Controls.SkyButton btn_elimina;
        private ReaLTaiizor.Controls.SkyButton btn_modifica;
        private ReaLTaiizor.Controls.HopeGroupBox groupBox2;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.SkyTextBox txt_id;
        private ReaLTaiizor.Controls.SkyTextBox txt_idgenere;
        private ReaLTaiizor.Controls.SkyLabel skyLabel4;
        private ReaLTaiizor.Controls.SkyTextBox txt_nome;
        private ReaLTaiizor.Controls.SkyLabel skyLabel3;
        private ReaLTaiizor.Controls.SkyTextBox txt_trama;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel6;
        private ReaLTaiizor.Controls.SkyNumeric n_minuti;
        private ReaLTaiizor.Controls.SkyNumeric n_ora;
        private ReaLTaiizor.Controls.SkyLabel skyLabel5;
        private ReaLTaiizor.Controls.SkyLabel skyLabel7;
        private ReaLTaiizor.Controls.PoisonDateTime dateTimePicker1;
        private ReaLTaiizor.Controls.SkyButton btn_salva;
        private ReaLTaiizor.Controls.SkyButton btn_annulla;
        private ReaLTaiizor.Controls.SkyButton btn_esci;
        private ReaLTaiizor.Controls.SkyButton btn_nuovo;
        private ReaLTaiizor.Controls.AloneNotice aloneNotice1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

