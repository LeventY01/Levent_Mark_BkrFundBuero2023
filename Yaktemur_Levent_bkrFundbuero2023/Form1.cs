using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Yaktemur_Levent_bkrFundbuero2023
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
            tabControl1.TabPages.Remove(tPVermittlung);
            tabControl1.TabPages.Remove(tPStatistik);
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

            // fill the Verlustort with fundort data
            listData = dbase.QueryToList("SELECT Bezeichnung FROM fundort;");
            cBVerlustort.DataSource = listData;

            listData = dbase.QueryToList("SELECT YEAR(Funddatum) AS Jahr, COUNT(*) AS Anzahl_gefundene_Gegenstände FROM fundgegenstand GROUP BY YEAR(Funddatum);");
            cBJahr.DataSource = listData;


            listData = dbase.QueryToList("SELECT Bezeichnung FROM fundort;");
            cBFundort.DataSource = listData;



        }

        private void Fill_Daten()
        {
            // Populate dataGridView with Fundgegenstand data
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
            dGVFund.ColumnCount = 6;
            dGVFund.Columns[0].Name = "Kategorie";
            dGVFund.Columns[1].Name = "Beschreibung";
            dGVFund.Columns[2].Name = "Fundort";
            dGVFund.Columns[3].Name = "FinderNr";
            dGVFund.Columns[4].Name = "EigentumNr";
            dGVFund.Columns[5].Name = "Funddatum";
            listData = dbase.QueryToArrayList($@"
            SELECT kat.Bezeichnung, fg.Beschreibung, fo.Bezeichnung as Fundort, fg.FinderNr, fg.EigentumNr, DATE_FORMAT(fg.Funddatum, '%d.%m.%Y') as Funddatum 
            FROM fundgegenstand fg
            JOIN fundort fo ON fg.FundortID = fo.FundortID
            JOIN kategorie kat ON fg.KatID = kat.KatID;");

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
                tabControl1.TabPages.Add(tPVermittlung);
                tabControl1.TabPages.Add(tPStatistik);
                tabControl1.TabPages.Remove(tPLogin);
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
            tabControl1.TabPages.Remove(tPVermittlung);
            tabControl1.TabPages.Remove(tPStatistik);
            tabControl1.TabPages.Add(tPLogin);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (dbase.QueryToBool($"SELECT * FROM login WHERE User = '{tBUsername.Text}' AND Pass = '{SHA256(tBPassword.Text)}';"))
            {
                tabControl1.TabPages.Add(tPVermittlung);
                tabControl1.TabPages.Add(tPStatistik);
                tabControl1.TabPages.Remove(tPLogin);
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
            string eigentumNr = cHBAnonym.Checked ? "100" : "NULL";
            string fundortID = dbase.QueryToCell($"SELECT FundortID FROM fundort WHERE Bezeichnung = '{fundort}'");
            //eintrag verlustmeldung
            dbase.QueryToList($"INSERT INTO verlustmeldung (Beschreibung, VerlustOrt, Verlustdatum, Telefonnummer, EMail, EigentumNr) " +
            $"VALUES ('{beschreibung}', '{fundortID}', '{verlustdatum:yyyy-MM-dd}', '{telefonnummer}', '{email}', {eigentumNr});");

            MessageBox.Show("Erfolgreich Aufgegeben!");
            tBBeschreibung.Clear();
            cBVerlustort.SelectedIndex = -1;
            dTPDatum.Value = DateTime.Now;
            tBTelefon.Clear();
            tBEmail.Clear();
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

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cBJahr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}