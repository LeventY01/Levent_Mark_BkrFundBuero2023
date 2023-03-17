using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Starodubzev_Mark_bkrFundbuero2023
{
    public partial class Form1 : Form
    {

        string servername = "localhost";
        string database = "bkr_fundbuero";
        string uid = "root";
        string passwd = ";";
        Dbase dbase;
        public Form1()
        {
            InitializeComponent();
            EigentuemerTab.TabPages.Remove(tPVermittlung);
            EigentuemerTab.TabPages.Remove(tPStatistik);
            EigentuemerTab.TabPages.Remove(tPEigentuemer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbase = new Dbase(servername, database, uid, passwd);

            Fill_Combobox();
        }
        private void Fill_Combobox()
        {
            List<string> listData = dbase.QueryToList("SELECT Bezeichnung FROM kategorie;");
            cBKatAuswahl.DataSource = listData;

            listData = dbase.QueryToList("SELECT Bezeichnung FROM kategorie;");
            cBKategorie.DataSource = listData;


            // fill the comboBox3 with fundort data
            listData = dbase.QueryToList("SELECT Bezeichnung FROM fundort;");
            cBVerlustort.DataSource = listData;

            listData = dbase.QueryToList("SELECT YEAR(Funddatum) AS Jahr, COUNT(*) AS Anzahl_gefundene_Gegenstände FROM fundgegenstand GROUP BY YEAR(Funddatum);");
            cBJahr.DataSource = listData;


            listData = dbase.QueryToList("SELECT Bezeichnung FROM fundort;");
            cBFundort.DataSource = listData;
        }

        private void Fill_Daten()
        {
            // Populate dataGridView with Fundggenstand data
            dGVFundgegenstand.Rows.Clear();
            dGVFundgegenstand.ColumnCount = 3;
            dGVFundgegenstand.Columns[0].Name = "Beschreibung";
            dGVFundgegenstand.Columns[1].Name = "Funddatum";
            dGVFundgegenstand.Columns[2].Name = "Fundort";

            List<string[]> listData = dbase.QueryToArrayList($@"
            SELECT fg.Beschreibung, DATE_FORMAT(fg.Funddatum, '%d.%m.%Y') as Funddatum, fo.Bezeichnung as Fundort 
            FROM fundgegenstand fg
            JOIN fundort fo ON fg.FundortID = fo.FundortID
            WHERE fg.KatID = '{cBKatAuswahl.SelectedIndex + 1}'; ");

            foreach (string[] item in listData)
            {
                dGVFundgegenstand.Rows.Add(item);
            }

            lblCount.Text = dbase.QueryToCell($"SELECT COUNT(*) FROM fundgegenstand WHERE KatID = '{cBKatAuswahl.SelectedIndex + 1}';");

            // Populate dataGridView1 with Verlustmeldung data
            dGVVerluste.Rows.Clear();
            dGVVerluste.ColumnCount = 7;
            dGVVerluste.Columns[0].Name = "VerlustNr";
            dGVVerluste.Columns[1].Name = "Beschreibung";
            dGVVerluste.Columns[2].Name = "VerlustOrt";
            dGVVerluste.Columns[3].Name = "Verlustdatum";
            dGVVerluste.Columns[4].Name = "Telefonnummer";
            dGVVerluste.Columns[5].Name = "Email";
            dGVVerluste.Columns[6].Name = "Eigentumer";

            listData = dbase.QueryToArrayList($@"
            SELECT vm.VerlustNr, vm.Beschreibung, fo.Bezeichnung as Verlustort, 
            DATE_FORMAT(vm.Verlustdatum, '%d.%m.%Y') as Verlustdatum, vm.Telefonnummer, 
            vm.Email,  vm.EigentumNr
            FROM Verlustmeldung vm
            LEFT JOIN eigentuemer eig ON vm.EigentumNr = eig.EigentumNr
            JOIN fundort fo ON vm.VerlustOrt = fo.FundortID
            WHERE vm.EigentumNr IS NULL;");

            foreach (string[] item in listData)
            {
                dGVVerluste.Rows.Add(item);
            }

            // Populate dataGridView2 with Fundgegenstand data
            dGVFund.Rows.Clear();
            dGVFund.ColumnCount = 7;
            dGVFund.Columns[0].Name = "Gnr";
            dGVFund.Columns[1].Name = "Kategorie";
            dGVFund.Columns[2].Name = "Beschreibung";
            dGVFund.Columns[3].Name = "Fundort";
            dGVFund.Columns[4].Name = "FinderNr";
            dGVFund.Columns[5].Name = "Eigentumer";
            dGVFund.Columns[6].Name = "Funddatum";
            listData = dbase.QueryToArrayList($@"
           SELECT Gnr ,kat.Bezeichnung, fg.Beschreibung, fo.Bezeichnung as Fundort, fg.FinderNr, fg.EigentumNr, DATE_FORMAT(fg.Funddatum, '%d.%m.%Y') as Funddatum 
            FROM fundgegenstand fg
            JOIN fundort fo ON fg.FundortID = fo.FundortID
            JOIN kategorie kat ON fg.KatID = kat.KatID
            WHERE fg.EigentumNr IS NULL;");

            foreach (string[] item in listData)
            {
                dGVFund.Rows.Add(item);
            }

        }

        private void cBKatAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill_Daten();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (dbase.QueryToBool($"SELECT * FROM login WHERE User = '{tBUsername.Text}' AND Pass = '{SHA256(tBPassword.Text)}';"))
            {
                EigentuemerTab.TabPages.Add(tPVermittlung);
                EigentuemerTab.TabPages.Add(tPStatistik);
                EigentuemerTab.TabPages.Add(tPEigentuemer);
                EigentuemerTab.TabPages.Remove(tPLogin);

                tBUsername.Clear();
                tBPassword.Clear();
            }
        }
        private static string SHA256(string clearText)
        {
            var sb = new StringBuilder();
            var bytes = Encoding.UTF8.GetBytes(clearText);
            var algo = HashAlgorithm.Create(nameof(SHA256));
            var hash = algo.ComputeHash(bytes);
            foreach (var byt in hash)
                sb.Append(byt.ToString("x2"));
            return sb.ToString();
        }

        private void btnAbmelden_Click(object sender, EventArgs e)
        {
            EigentuemerTab.TabPages.Remove(tPVermittlung);
            EigentuemerTab.TabPages.Remove(tPStatistik);
            EigentuemerTab.TabPages.Remove(tPEigentuemer);
            EigentuemerTab.TabPages.Add(tPLogin);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (dbase.QueryToBool($"SELECT * FROM login WHERE User = '{tBUsername.Text}' AND Pass = '{SHA256(tBPassword.Text)}';"))
            {
                EigentuemerTab.TabPages.Add(tPVermittlung);
                EigentuemerTab.TabPages.Add(tPStatistik);
                EigentuemerTab.TabPages.Add(tPEigentuemer);
                EigentuemerTab.TabPages.Remove(tPLogin);
                tBUsername.Clear();
                tBPassword.Clear();
            }
        }

        private void dGVFundgegenstand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnVerlustmelden_Click(object sender, EventArgs e)
        {
            string beschreibung = tBBeschreibung.Text;
            string fundort = cBVerlustort.SelectedItem.ToString();
            DateTime verlustdatum = dTPDatum.Value;
            string telefonnummer = tBTelefon.Text;
            string email = tBEmail.Text;
            string eigentumNr = "NULL";
            string fundortID = dbase.QueryToCell($"SELECT FundortID FROM fundort WHERE Bezeichnung = '{fundort}'");

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Bitte geben Sie eine gültige E-Mail-Adresse ein.");
                return;
            }


            //eintrag verlustmeldung
            dbase.QueryToList($"INSERT INTO verlustmeldung (Beschreibung, VerlustOrt, Verlustdatum, Telefonnummer, EMail, EigentumNr) " +
            $"VALUES ('{beschreibung}', '{fundortID}', '{verlustdatum:yyyy-MM-dd}', '{telefonnummer}', '{email}', {eigentumNr});");

            MessageBox.Show("Erfolgreich Aufgegeben!");
            tBBeschreibung.Clear();
            cBVerlustort.SelectedIndex = -1;
            dTPDatum.Value = DateTime.Now;
            tBTelefon.Clear();
            tBEmail.Clear();

            Fill_Daten();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGefunden_Click(object sender, EventArgs e)
        {
            cStatistik.Series.Clear();
            List<String[]> liste = new List<String[]>();
            liste = dbase.QueryToArrayList($"SELECT count(*),YEAR(Funddatum) from fundgegenstand WHERE YEAR(Funddatum) = {cBJahr.Text} GROUP BY YEAR(Funddatum);");

            string[] jahr = cBJahr.Text.Split('_');
            string first = jahr[0];

            var s = cStatistik.Series.Add($"JahrGefunden-{cBJahr.Text}");
            //s.ChartType = SeriesChartType.Spline;
            for (int i = 0; i < liste.Count; i++)
            {
                s.Points.AddXY(liste[i][1], liste[i][0]);
            }
        }
        private void btnVerloren_Click(object sender, EventArgs e)
        {
            List<String[]> liste = new List<String[]>();
            liste = dbase.QueryToArrayList($"SELECT count(*),Year(Funddatum) from fundgegenstand where EigentumNr is null and Year(Funddatum) = {cBJahr.Text} GROUP BY YEAR(Funddatum);");
            //jahr identifizieren
            string[] jahr = cBJahr.Text.Split('_');
            string first = jahr[0];
            //name seires
            var s = cStatistik.Series.Add($"Jahr!Gefunden-{cBJahr.Text}");
            //s.ChartType = SeriesChartType.Spline;
            for (int i = 0; i < liste.Count; i++)
            {

                s.Points.AddXY(liste[i][1], liste[i][0]);
            }
        }


        private void btnFundabgeben_Click(object sender, EventArgs e)
        {
            string kategorie = cBKategorie.SelectedItem.ToString();
            string beschreibung = tBBeschreibung2.Text;
            string fundortID = dbase.QueryToCell($"SELECT FundortID FROM fundort WHERE Bezeichnung = '{cBFundort.SelectedItem.ToString()}'");

            string findernr;
            if (chBAnonym2.Checked)
            {
                findernr = "100"; // anonymous finder
            }
            else
            {
                // insert a new finder record
                string vorname = tBVorname.Text;
                string nachname = tBNachname.Text;
                string telefonnummer = tBTelefon2.Text;
                string email = tBEmail2.Text;


                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Bitte geben Sie eine gültige E-Mail-Adresse ein.");
                    return;
                }

                dbase.QueryToList($"INSERT INTO finder (Vorname, Nachname, Telefonnummer, EMail) " +
                    $"VALUES ('{vorname}', '{nachname}', '{telefonnummer}', '{email}');");

                // get the new FinderNr
                findernr = dbase.QueryToCell($"SELECT MAX(FinderNr) FROM finder").ToString();
            }

            DateTime funddatum = dTPFunddatum2.Value;
            string katID = dbase.QueryToCell($"SELECT KatID FROM Kategorie WHERE Bezeichnung = '{kategorie}'");

            dbase.QueryToList($"INSERT INTO fundgegenstand (KatID, Beschreibung, FundortID, FinderNr, EigentumNr, Funddatum) " +
                $"VALUES ('{katID}', '{beschreibung}', '{fundortID}', '{findernr}', NULL, '{funddatum:yyyy-MM-dd}');");

            MessageBox.Show("Erfolgreich Aufgegeben!");

            // clear the form fields
            cBKategorie.SelectedIndex = -1;
            tBBeschreibung2.Clear();
            cBFundort.SelectedIndex = -1;
            chBAnonym2.Checked = false;
            dTPFunddatum2.Value = DateTime.Now;
            tBVorname.Clear();
            tBNachname.Clear();
            tBTelefon2.Clear();
            tBEmail2.Clear();

            Fill_Daten();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void dGVVerluste_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the double-clicked cell is in the "Eigentumer" column
            if (dGVVerluste.Columns[e.ColumnIndex].Name == "Eigentumer")
            {
                // Get the VerlustNr from the selected row
                string verlustNr = dGVVerluste.Rows[e.RowIndex].Cells["VerlustNr"].Value.ToString();

                // Pass the VerlustNr to the tPEigentuemer tab page
                tPEigentuemer.Tag = verlustNr;

                // Switch to the "tPEigentuemer" tab page
                EigentuemerTab.SelectedTab = tPEigentuemer;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string verlustNr = tPEigentuemer.Tag.ToString();
            // Get the EigentumNr for the new Eigentümer record
            string eigentumNr = dbase.QueryToCell($"SELECT EigentumNr FROM verlustmeldung WHERE VerlustNr = '{verlustNr}'");

            // Check if the CheckBox1 is selected
            if (chBAnonym3.Checked)
            {
                // Insert EigentumNr 100 into the verlustmeldung table
                dbase.QueryToList($"UPDATE verlustmeldung SET EigentumNr = '100' WHERE VerlustNr = '{verlustNr}'");
            }
            else
            {
                // Get the input values for the new Eigentümer record
                string vorname = tBVorname2.Text;
                string nachname = tBNachname2.Text;
                string telefonnummer = tBTelefon3.Text;
                string email = tBEmail3.Text;


                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Bitte geben Sie eine gültige E-Mail-Adresse ein.");
                    return;
                }

                // Insert the new Eigentümer record into the database
                dbase.QueryToList($"INSERT INTO eigentuemer (Vorname, Nachname, Telefonnummer, EMail) " +
                                  $"VALUES ('{vorname}', '{nachname}', '{telefonnummer}', '{email}');");

                // Get the new EigentumNr for the inserted record
                string newEigentumNr = dbase.QueryToCell($"SELECT MAX(EigentumNr) FROM eigentuemer").ToString();

                // Update the EigentumNr in the verlustmeldung table
                dbase.QueryToList($"UPDATE verlustmeldung SET EigentumNr = '{newEigentumNr}' WHERE VerlustNr = '{verlustNr}'");
            }

            MessageBox.Show("Erfolgreich Hinzugefügt!");

            // Clear the input fields
            tBVorname2.Clear();
            tBNachname2.Clear();
            tBTelefon3.Clear();
            tBEmail3.Clear();
            Fill_Daten();
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the selected row from the Verlustmeldung datagrid
            if (dGVVerluste.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dGVVerluste.SelectedRows[0];
                string verlustNr = row.Cells["VerlustNr"].Value.ToString();

                // Pass the verlustNr value to the next tabpage
                tPEigentuemer.Tag = verlustNr;
            }

            // Get the selected row from the Fundgegenstand datagrid
            if (dGVFund.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dGVFund.SelectedRows[0];
                string gnr = row.Cells["Gnr"].Value.ToString();

                // Pass the gnr value to the next tabpage
                tPEigentuemer.Tag += "," + gnr;
            }

            // Select the next tabpage
            EigentuemerTab.SelectedTab = tPEigentuemer;
            // Move to the next tab page


        }
    }
}

