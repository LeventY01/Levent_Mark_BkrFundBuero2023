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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label12 = new Label();
            tPStatistik = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnAbmelden = new Button();
            cStatistik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel3 = new Panel();
            btnVerloren = new Button();
            btnGefunden = new Button();
            cBJahr = new ComboBox();
            lblJahr = new Label();
            tabPage1 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            checkBox2 = new CheckBox();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            label11 = new Label();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tPStatistik.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cStatistik).BeginInit();
            panel3.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.67148F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.32852364F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(label11, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.24138F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.75862074F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1728, 696);
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
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1647, 636);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 0;
            // 
            // tPFundgegenstand
            // 
            tPFundgegenstand.Controls.Add(tableLayoutPanel2);
            tPFundgegenstand.Location = new Point(4, 32);
            tPFundgegenstand.Name = "tPFundgegenstand";
            tPFundgegenstand.Padding = new Padding(3);
            tPFundgegenstand.Size = new Size(1639, 600);
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
            tableLayoutPanel2.Size = new Size(1633, 594);
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
            dGVFundgegenstand.Size = new Size(1309, 534);
            dGVFundgegenstand.TabIndex = 1;
            dGVFundgegenstand.CellContentClick += dGVFundgegenstand_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(cBKatAuswahl);
            panel1.Controls.Add(lblKategorie1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1318, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 534);
            panel1.TabIndex = 3;
            // 
            // cBKatAuswahl
            // 
            cBKatAuswahl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cBKatAuswahl.FormattingEnabled = true;
            cBKatAuswahl.Location = new Point(3, 23);
            cBKatAuswahl.Name = "cBKatAuswahl";
            cBKatAuswahl.Size = new Size(303, 28);
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
            lblCount.Location = new Point(633, 557);
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
            tPVerlustmeldung.Controls.Add(lblFundgegenstand);
            tPVerlustmeldung.Controls.Add(lblKategorie2);
            tPVerlustmeldung.Controls.Add(lblDatum);
            tPVerlustmeldung.Controls.Add(lblFundort);
            tPVerlustmeldung.Controls.Add(comboBox3);
            tPVerlustmeldung.Location = new Point(4, 32);
            tPVerlustmeldung.Name = "tPVerlustmeldung";
            tPVerlustmeldung.Padding = new Padding(3);
            tPVerlustmeldung.Size = new Size(1639, 600);
            tPVerlustmeldung.TabIndex = 1;
            tPVerlustmeldung.Text = "Verlustmeldung";
            tPVerlustmeldung.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(845, 65);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 24);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Anonym";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(56, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(56, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 27);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(56, 309);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 27);
            textBox1.TabIndex = 14;
            // 
            // lblTelefon
            // 
            lblTelefon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(56, 139);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(113, 20);
            lblTelefon.TabIndex = 13;
            lblTelefon.Text = "Telefonnummer";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(56, 271);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "E-mail";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(343, 434);
            button1.Name = "button1";
            button1.Size = new Size(511, 29);
            button1.TabIndex = 11;
            button1.Text = "Verlust melden";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dTPDatum
            // 
            dTPDatum.Location = new Point(482, 65);
            dTPDatum.Name = "dTPDatum";
            dTPDatum.Size = new Size(250, 27);
            dTPDatum.TabIndex = 10;
            // 
            // lblFundgegenstand
            // 
            lblFundgegenstand.AutoSize = true;
            lblFundgegenstand.Location = new Point(845, 27);
            lblFundgegenstand.Name = "lblFundgegenstand";
            lblFundgegenstand.Size = new Size(72, 20);
            lblFundgegenstand.TabIndex = 8;
            lblFundgegenstand.Text = "Meldung ";
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
            lblDatum.Location = new Point(482, 27);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(54, 20);
            lblDatum.TabIndex = 4;
            lblDatum.Text = "Datum";
            // 
            // lblFundort
            // 
            lblFundort.AutoSize = true;
            lblFundort.Location = new Point(242, 27);
            lblFundort.Name = "lblFundort";
            lblFundort.Size = new Size(72, 20);
            lblFundort.TabIndex = 3;
            lblFundort.Text = "Verlustort";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(242, 67);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 1;
            // 
            // tPLogin
            // 
            tPLogin.Controls.Add(panel2);
            tPLogin.Location = new Point(4, 32);
            tPLogin.Name = "tPLogin";
            tPLogin.Size = new Size(1639, 600);
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
            panel2.Size = new Size(966, 398);
            panel2.TabIndex = 5;
            // 
            // tBPassword
            // 
            tBPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tBPassword.Location = new Point(136, 156);
            tBPassword.Name = "tBPassword";
            tBPassword.Size = new Size(667, 27);
            tBPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(219, 366);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(511, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(131, 80);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(136, 133);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // tBUsername
            // 
            tBUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tBUsername.Location = new Point(136, 103);
            tBUsername.Name = "tBUsername";
            tBUsername.Size = new Size(667, 27);
            tBUsername.TabIndex = 1;
            // 
            // tPVermittlung
            // 
            tPVermittlung.Controls.Add(tableLayoutPanel4);
            tPVermittlung.Controls.Add(label12);
            tPVermittlung.Location = new Point(4, 32);
            tPVermittlung.Name = "tPVermittlung";
            tPVermittlung.Size = new Size(1639, 600);
            tPVermittlung.TabIndex = 3;
            tPVermittlung.Text = "Vermittlung";
            tPVermittlung.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel4.Controls.Add(dataGridView2, 0, 0);
            tableLayoutPanel4.Location = new Point(-7, 34);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 274F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1668, 593);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 322);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1555, 180);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1555, 260);
            dataGridView2.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 11);
            label12.Name = "label12";
            label12.Size = new Size(127, 20);
            label12.TabIndex = 3;
            label12.Text = "Fundgegenstände";
            // 
            // tPStatistik
            // 
            tPStatistik.Controls.Add(tableLayoutPanel3);
            tPStatistik.Location = new Point(4, 32);
            tPStatistik.Name = "tPStatistik";
            tPStatistik.Size = new Size(1639, 600);
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
            tableLayoutPanel3.Size = new Size(1639, 600);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnAbmelden
            // 
            btnAbmelden.Dock = DockStyle.Fill;
            btnAbmelden.Location = new Point(1417, 543);
            btnAbmelden.Name = "btnAbmelden";
            btnAbmelden.Size = new Size(219, 54);
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
            cStatistik.Size = new Size(1408, 534);
            cStatistik.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnVerloren);
            panel3.Controls.Add(btnGefunden);
            panel3.Controls.Add(cBJahr);
            panel3.Controls.Add(lblJahr);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(1417, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 534);
            panel3.TabIndex = 2;
            // 
            // btnVerloren
            // 
            btnVerloren.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnVerloren.Location = new Point(3, 103);
            btnVerloren.Name = "btnVerloren";
            btnVerloren.Size = new Size(213, 29);
            btnVerloren.TabIndex = 3;
            btnVerloren.Text = "Verloren";
            btnVerloren.UseVisualStyleBackColor = true;
            // 
            // btnGefunden
            // 
            btnGefunden.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGefunden.Location = new Point(3, 68);
            btnGefunden.Name = "btnGefunden";
            btnGefunden.Size = new Size(213, 29);
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
            cBJahr.Size = new Size(213, 28);
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
            // tabPage1
            // 
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox8);
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1639, 600);
            tabPage1.TabIndex = 5;
            tabPage1.Text = "Fundgegenstand Abgeben";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(410, 166);
            label10.Name = "label10";
            label10.Size = new Size(235, 20);
            label10.TabIndex = 19;
            label10.Text = "Anonym oder mit Namen melden!";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(860, 74);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(985, 207);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 17;
            label8.Text = "E-Mail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(844, 207);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 16;
            label7.Text = "Telefonnummer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(703, 207);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 15;
            label6.Text = "Nachname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(584, 207);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 14;
            label5.Text = "Vorname";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(561, 249);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(832, 249);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(963, 249);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(692, 249);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(407, 407);
            button2.Name = "button2";
            button2.Size = new Size(376, 29);
            button2.TabIndex = 9;
            button2.Text = "Fund Abgeben";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 146);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 8;
            label4.Text = "Funddatum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(453, 43);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 7;
            label3.Text = "Fundort";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 43);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 6;
            label2.Text = "Beschreibung";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 43);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 5;
            label1.Text = "Kategorie";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(25, 187);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(410, 249);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(90, 24);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Anonym ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(453, 77);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(239, 77);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 642);
            label11.Name = "label11";
            label11.Size = new Size(128, 20);
            label11.TabIndex = 2;
            label11.Text = "VerlustMeldungen";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1728, 696);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
            tPVermittlung.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tPStatistik.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cStatistik).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
        private TextBox textBox3;
        private CheckBox checkBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cStatistik;
        private Panel panel3;
        private ComboBox cBJahr;
        private Label lblJahr;
        private Button btnVerloren;
        private Button btnGefunden;
        private TabPage tabPage1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox2;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Button button2;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label11;
        private Label label12;
    }
}