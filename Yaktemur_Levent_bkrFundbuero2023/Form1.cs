using System.Security.Cryptography;
using System.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;


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

            // fill the comboBox3 with fundort data
            comboBox3.Items.Clear();
            listData = dbase.QueryToList("SELECT Bezeichnung FROM fundort;");
            comboBox3.DataSource = listData;

            listData = dbase.QueryToList("SELECT YEAR(Funddatum) AS Jahr, COUNT(*) AS Anzahl_gefundene_Gegenstände FROM fundgegenstand GROUP BY YEAR(Funddatum);");
            cBJahr.DataSource = listData;

        }

        private void Fill_Daten()
        {
            dGVFundgegenstand.Rows.Clear();
            dGVFundgegenstand.ColumnCount = 3;
            dGVFundgegenstand.Columns[0].Name = "Beschreibung";
            dGVFundgegenstand.Columns[1].Name = "Funddatum";
            dGVFundgegenstand.Columns[2].Name = "Fundrt";

            List<string[]> listData = dbase.QueryToArrayList($@"
            SELECT fg.Beschreibung, DATE_FORMAT(fg.Funddatum, '%d.%m.%Y') as Funddatum, fo.Bezeichnung as Fundort 
            FROM fundgegenstand fg
            JOIN fundort fo ON fg.FundortID = fo.FundortID
            WHERE fg.KatID = '{cBKatAuswahl.SelectedIndex + 1}';
    ");

            foreach (string[] item in listData)
            {
                dGVFundgegenstand.Rows.Add(item);
            }

            lblCount.Text = dbase.QueryToCell($"SELECT COUNT(*) FROM fundgegenstand WHERE KatID = '{cBKatAuswahl.SelectedIndex + 1}';");
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


        private void button1_Click(object sender, EventArgs e)
        {
            string beschreibung = textBox3.Text;
            string fundort = comboBox3.SelectedItem.ToString();
            DateTime verlustdatum = dTPDatum.Value;
            string telefonnummer = textBox2.Text;
            string email = textBox1.Text;
            string eigentumNr = tBFundgegenstand.Text;

            if (checkBox1.Checked)
            {
                eigentumNr = "100";
            }

            string fundortID = dbase.QueryToCell($"SELECT FundortID FROM fundort WHERE Bezeichnung = '{fundort}'");


            dbase.QueryToList($"INSERT INTO verlustmeldung (Beschreibung, VerlustOrt, Verlustdatum, Telefonnummer, EMail, EigentumNr) " +
       $"VALUES ('{beschreibung}', '{fundortID}', '{verlustdatum:yyyy-MM-dd}', '{telefonnummer}', '{email}', '{eigentumNr}');");


            MessageBox.Show("Erfolgreich Aufgegeben!");
            textBox3.Clear();
            comboBox3.SelectedIndex = -1;
            dTPDatum.Value = DateTime.Now;
            tBFundgegenstand.Clear();
            textBox2.Clear();
            textBox1.Clear();







        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGefunden_Click(object sender, EventArgs e)
        {
            List<String[]> liste = new List<String[]>();
            liste = dbase.QueryToArrayList($"SELECT {cBJahr.Text} AS Jahr AS Anzahl_gefundene_Gegenstände FROM fundgegenstand;");

            string[] jahr = cBJahr.Text.Split('_');
            string first = jahr[0];

            var s = cStatistik.Series.Add($"Jahr-{cBJahr.Text}");
            for (int i = 0; i < liste.Count; i++)
            {
                s.Points.AddXY(liste[i][0], liste[i][1]);
            }
        }
    }
}