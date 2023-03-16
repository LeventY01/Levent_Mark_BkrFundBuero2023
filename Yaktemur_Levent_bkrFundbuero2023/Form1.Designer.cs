namespace Yaktemur_Levent_bkrFundbuero2023
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl1 = new TabControl();
            tPFundgegenstand = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            dGVFundgegenstand = new DataGridView();
            panel1 = new Panel();
            cBKatAuswahl = new ComboBox();
            lblKategorie1 = new Label();
            lblCount = new Label();
            tPVerlustmeldung = new TabPage();
            checkBox1 = new CheckBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblTelefon = new Label();
            lblEmail = new Label();
            button1 = new Button();
            dTPDatum = new DateTimePicker();
            tBFundgegenstand = new TextBox();
            lblFundgegenstand = new Label();
            lblKategorie2 = new Label();
            lblDatum = new Label();
            lblFundort = new Label();
            comboBox3 = new ComboBox();
            tPLogin = new TabPage();
            panel2 = new Panel();
            tBPassword = new TextBox();
            btnLogin = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            tBUsername = new TextBox();
            tPVermittlung = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnAbmelden2 = new Button();
            tPStatistik = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnAbmelden = new Button();
            cStatistik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel3 = new Panel();
            btnVerloren = new Button();
            btnGefunden = new Button();
            cBJahr = new ComboBox();
            lblJahr = new Label();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tPFundgegenstand.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVFundgegenstand).BeginInit();
            panel1.SuspendLayout();
            tPVerlustmeldung.SuspendLayout();
            tPLogin.SuspendLayout();
            panel2.SuspendLayout();
            tPVermittlung.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tPStatistik.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cStatistik).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.67148F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.32852364F));
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.44444F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.555555F));
            tableLayoutPanel1.Size = new Size(901, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tPFundgegenstand);
            tabControl1.Controls.Add(tPVerlustmeldung);
            tabControl1.Controls.Add(tPLogin);
            tabControl1.Controls.Add(tPVermittlung);
            tabControl1.Controls.Add(tPStatistik);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(856, 410);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 0;
            // 
            // tPFundgegenstand
            // 
            tPFundgegenstand.Controls.Add(tableLayoutPanel2);
            tPFundgegenstand.Location = new Point(4, 32);
            tPFundgegenstand.Name = "tPFundgegenstand";
            tPFundgegenstand.Padding = new Padding(3);
            tPFundgegenstand.Size = new Size(848, 374);
            tPFundgegenstand.TabIndex = 0;
            tPFundgegenstand.Text = "Fundgegenstände";
            tPFundgegenstand.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.57901F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.42099F));
            tableLayoutPanel2.Controls.Add(dGVFundgegenstand, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Controls.Add(lblCount, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 91.03261F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.967391F));
            tableLayoutPanel2.Size = new Size(842, 368);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dGVFundgegenstand
            // 
            dGVFundgegenstand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVFundgegenstand.Dock = DockStyle.Fill;
            dGVFundgegenstand.Location = new Point(3, 3);
            dGVFundgegenstand.Name = "dGVFundgegenstand";
            dGVFundgegenstand.RowHeadersWidth = 51;
            dGVFundgegenstand.RowTemplate.Height = 29;
            dGVFundgegenstand.Size = new Size(672, 329);
            dGVFundgegenstand.TabIndex = 1;
            dGVFundgegenstand.CellContentClick += dGVFundgegenstand_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(cBKatAuswahl);
            panel1.Controls.Add(lblKategorie1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(681, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 329);
            panel1.TabIndex = 3;
            // 
            // cBKatAuswahl
            // 
            cBKatAuswahl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cBKatAuswahl.FormattingEnabled = true;
            cBKatAuswahl.Location = new Point(3, 23);
            cBKatAuswahl.Name = "cBKatAuswahl";
            cBKatAuswahl.Size = new Size(149, 28);
            cBKatAuswahl.TabIndex = 3;
            cBKatAuswahl.SelectedIndexChanged += cBKatAuswahl_SelectedIndexChanged;
            // 
            // lblKategorie1
            // 
            lblKategorie1.AutoSize = true;
            lblKategorie1.Dock = DockStyle.Fill;
            lblKategorie1.Location = new Point(0, 0);
            lblKategorie1.Name = "lblKategorie1";
            lblKategorie1.Size = new Size(77, 20);
            lblKategorie1.TabIndex = 2;
            lblKategorie1.Text = "Kategorie:";
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.None;
            lblCount.AutoSize = true;
            lblCount.Location = new Point(315, 341);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(48, 20);
            lblCount.TabIndex = 4;
            lblCount.Text = "Count";
            // 
            // tPVerlustmeldung
            // 
            tPVerlustmeldung.Controls.Add(checkBox1);
            tPVerlustmeldung.Controls.Add(textBox3);
            tPVerlustmeldung.Controls.Add(textBox2);
            tPVerlustmeldung.Controls.Add(textBox1);
            tPVerlustmeldung.Controls.Add(lblTelefon);
            tPVerlustmeldung.Controls.Add(lblEmail);
            tPVerlustmeldung.Controls.Add(button1);
            tPVerlustmeldung.Controls.Add(dTPDatum);
            tPVerlustmeldung.Controls.Add(tBFundgegenstand);
            tPVerlustmeldung.Controls.Add(lblFundgegenstand);
            tPVerlustmeldung.Controls.Add(lblKategorie2);
            tPVerlustmeldung.Controls.Add(lblDatum);
            tPVerlustmeldung.Controls.Add(lblFundort);
            tPVerlustmeldung.Controls.Add(comboBox3);
            tPVerlustmeldung.Location = new Point(4, 32);
            tPVerlustmeldung.Name = "tPVerlustmeldung";
            tPVerlustmeldung.Padding = new Padding(3);
            tPVerlustmeldung.Size = new Size(848, 374);
            tPVerlustmeldung.TabIndex = 1;
            tPVerlustmeldung.Text = "Verlustmeldung";
            tPVerlustmeldung.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(630, 90);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 24);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Anonym";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(56, 53);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(56, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 27);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(56, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 14;
            // 
            // lblTelefon
            // 
            lblTelefon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(56, 94);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(113, 20);
            lblTelefon.TabIndex = 13;
            lblTelefon.Text = "Telefonnummer";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(56, 168);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "E-mail";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(309, 322);
            button1.Name = "button1";
            button1.Size = new Size(210, 29);
            button1.TabIndex = 11;
            button1.Text = "Verlust melden";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dTPDatum
            // 
            dTPDatum.Location = new Point(370, 53);
            dTPDatum.Name = "dTPDatum";
            dTPDatum.Size = new Size(250, 27);
            dTPDatum.TabIndex = 10;
            // 
            // tBFundgegenstand
            // 
            tBFundgegenstand.Location = new Point(626, 53);
            tBFundgegenstand.Name = "tBFundgegenstand";
            tBFundgegenstand.Size = new Size(185, 27);
            tBFundgegenstand.TabIndex = 9;
            // 
            // lblFundgegenstand
            // 
            lblFundgegenstand.AutoSize = true;
            lblFundgegenstand.Location = new Point(630, 27);
            lblFundgegenstand.Name = "lblFundgegenstand";
            lblFundgegenstand.Size = new Size(110, 20);
            lblFundgegenstand.TabIndex = 8;
            lblFundgegenstand.Text = "Eigentum/nicht";
            // 
            // lblKategorie2
            // 
            lblKategorie2.AutoSize = true;
            lblKategorie2.Location = new Point(56, 27);
            lblKategorie2.Name = "lblKategorie2";
            lblKategorie2.Size = new Size(98, 20);
            lblKategorie2.TabIndex = 5;
            lblKategorie2.Text = "Beschreibung";
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Location = new Point(370, 27);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(54, 20);
            lblDatum.TabIndex = 4;
            lblDatum.Text = "Datum";
            // 
            // lblFundort
            // 
            lblFundort.AutoSize = true;
            lblFundort.Location = new Point(201, 27);
            lblFundort.Name = "lblFundort";
            lblFundort.Size = new Size(72, 20);
            lblFundort.TabIndex = 3;
            lblFundort.Text = "Verlustort";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(201, 50);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 1;
            // 
            // tPLogin
            // 
            tPLogin.Controls.Add(panel2);
            tPLogin.Location = new Point(4, 32);
            tPLogin.Name = "tPLogin";
            tPLogin.Size = new Size(848, 374);
            tPLogin.TabIndex = 2;
            tPLogin.Text = "Admin login";
            tPLogin.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(tBPassword);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(tBUsername);
            panel2.Location = new Point(86, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(665, 301);
            panel2.TabIndex = 5;
            // 
            // tBPassword
            // 
            tBPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tBPassword.Location = new Point(136, 107);
            tBPassword.Name = "tBPassword";
            tBPassword.Size = new Size(366, 27);
            tBPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(219, 269);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(210, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(131, 31);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(136, 84);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // tBUsername
            // 
            tBUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tBUsername.Location = new Point(136, 54);
            tBUsername.Name = "tBUsername";
            tBUsername.Size = new Size(366, 27);
            tBUsername.TabIndex = 1;
            // 
            // tPVermittlung
            // 
            tPVermittlung.Controls.Add(tableLayoutPanel4);
            tPVermittlung.Location = new Point(4, 32);
            tPVermittlung.Name = "tPVermittlung";
            tPVermittlung.Size = new Size(848, 374);
            tPVermittlung.TabIndex = 3;
            tPVermittlung.Text = "Vermittlung";
            tPVermittlung.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.90419F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.09581F));
            tableLayoutPanel4.Controls.Add(btnAbmelden2, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 89.03743F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.96257F));
            tableLayoutPanel4.Size = new Size(848, 374);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // btnAbmelden2
            // 
            btnAbmelden2.Dock = DockStyle.Fill;
            btnAbmelden2.Location = new Point(748, 336);
            btnAbmelden2.Name = "btnAbmelden2";
            btnAbmelden2.Size = new Size(97, 35);
            btnAbmelden2.TabIndex = 1;
            btnAbmelden2.Text = "Abmelden";
            btnAbmelden2.UseVisualStyleBackColor = true;
            btnAbmelden2.Click += btnAbmelden_Click;
            // 
            // tPStatistik
            // 
            tPStatistik.Controls.Add(tableLayoutPanel3);
            tPStatistik.Location = new Point(4, 32);
            tPStatistik.Name = "tPStatistik";
            tPStatistik.Size = new Size(848, 374);
            tPStatistik.TabIndex = 4;
            tPStatistik.Text = "Statistik";
            tPStatistik.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.320755F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.679245F));
            tableLayoutPanel3.Controls.Add(btnAbmelden, 1, 1);
            tableLayoutPanel3.Controls.Add(cStatistik, 0, 0);
            tableLayoutPanel3.Controls.Add(panel3, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 90.10695F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.893048F));
            tableLayoutPanel3.Size = new Size(848, 374);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnAbmelden
            // 
            btnAbmelden.Dock = DockStyle.Fill;
            btnAbmelden.Location = new Point(735, 340);
            btnAbmelden.Name = "btnAbmelden";
            btnAbmelden.Size = new Size(110, 31);
            btnAbmelden.TabIndex = 0;
            btnAbmelden.Text = "Abmelden";
            btnAbmelden.UseVisualStyleBackColor = true;
            btnAbmelden.Click += btnAbmelden_Click;
            // 
            // cStatistik
            // 
            chartArea1.Name = "ChartArea1";
            cStatistik.ChartAreas.Add(chartArea1);
            cStatistik.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            cStatistik.Legends.Add(legend1);
            cStatistik.Location = new Point(3, 3);
            cStatistik.Name = "cStatistik";
            cStatistik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            cStatistik.Series.Add(series1);
            cStatistik.Size = new Size(726, 331);
            cStatistik.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnVerloren);
            panel3.Controls.Add(btnGefunden);
            panel3.Controls.Add(cBJahr);
            panel3.Controls.Add(lblJahr);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(735, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(110, 331);
            panel3.TabIndex = 2;
            // 
            // btnVerloren
            // 
            btnVerloren.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnVerloren.Location = new Point(3, 103);
            btnVerloren.Name = "btnVerloren";
            btnVerloren.Size = new Size(104, 29);
            btnVerloren.TabIndex = 3;
            btnVerloren.Text = "Verloren";
            btnVerloren.UseVisualStyleBackColor = true;
            // 
            // btnGefunden
            // 
            btnGefunden.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGefunden.Location = new Point(3, 68);
            btnGefunden.Name = "btnGefunden";
            btnGefunden.Size = new Size(104, 29);
            btnGefunden.TabIndex = 2;
            btnGefunden.Text = "Gefunden";
            btnGefunden.UseVisualStyleBackColor = true;
            btnGefunden.Click += btnGefunden_Click;
            // 
            // cBJahr
            // 
            cBJahr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cBJahr.FormattingEnabled = true;
            cBJahr.Location = new Point(3, 23);
            cBJahr.Name = "cBJahr";
            cBJahr.Size = new Size(104, 28);
            cBJahr.TabIndex = 1;
            // 
            // lblJahr
            // 
            lblJahr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblJahr.AutoSize = true;
            lblJahr.Location = new Point(3, 0);
            lblJahr.Name = "lblJahr";
            lblJahr.Size = new Size(38, 20);
            lblJahr.TabIndex = 0;
            lblJahr.Text = "Jahr:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tPFundgegenstand.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVFundgegenstand).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tPVerlustmeldung.ResumeLayout(false);
            tPVerlustmeldung.PerformLayout();
            tPLogin.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tPVermittlung.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tPStatistik.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cStatistik).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tPFundgegenstand;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dGVFundgegenstand;
        private Panel panel1;
        private ComboBox cBKatAuswahl;
        private Label lblKategorie1;
        private TabPage tPVerlustmeldung;
        private TextBox tBFundgegenstand;
        private Label lblFundgegenstand;
        private Label lblKategorie2;
        private Label lblDatum;
        private Label lblFundort;
        private ComboBox comboBox3;
        private TabPage tPLogin;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox tBPassword;
        private TextBox tBUsername;
        private Button btnLogin;
        private TabPage tPVermittlung;
        private TabPage tPStatistik;
        private TableLayoutPanel tableLayoutPanel3;
        private DateTimePicker dTPDatum;
        private Panel panel2;
        private Button button1;
        private Label lblCount;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblTelefon;
        private Label lblEmail;
        private Button btnAbmelden;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnAbmelden2;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cStatistik;
        private Panel panel3;
        private ComboBox cBJahr;
        private Label lblJahr;
        private Button btnVerloren;
        private Button btnGefunden;
    }
}