using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;
using System.Data;

namespace Yaktemur_Levent_bkrFundbuero2023
{
    internal class Dbase
    {
        private string serverName = "";
        public string databaseName { get; private set; }

        private string uid;
        private string passwd;
        private string connString;
        private MySqlConnection connection;
        private MySqlCommand command;

        public Dbase(string servername, string database, string uid, string passwd)
        {
            this.serverName = servername;
            this.databaseName = database;
            this.uid = uid;
            this.passwd = passwd;
            Connect();
        }


        public void Connect()
        {
            connString = $"SERVER={serverName};DATABASE={databaseName};UID={uid};PWD={passwd}";
            try
            {
                connection = new MySqlConnection(connString);
                connection.Open();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Datenbank Verbindungsfehler");
            }
        
    }
        public DataTable TableToDataTable(string table)
        {
            DataTable dtData = new DataTable();
            string query = $"SELECT * FROM {table}";
            try
            {
                connection.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, connection);
                adp.Fill(dtData);
                connection.Close();
                return dtData;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Datenbank Query-Fehler");
                return new DataTable();
            }
        }

        public List<string> QueryToList(string query)
        {
            List<string> listData = new List<string>();
            string row;
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    row = String.Empty;
                    row = reader[0].ToString();
                    listData.Add(row);
                }
                reader.Close();
                connection.Close();
                return listData;
            }
            catch (MySqlException ex)
            {                
                MessageBox.Show(ex.Message + $"\n\n{query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }
        }
        public List<string[]> QueryToArrayList(string _query)
        {
            List<string[]> listData = new List<string[]>();
            string[] row;
            try
            {
                connection.Open();
                command = new MySqlCommand(_query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    row = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i].ToString();
                    }
                    listData.Add(row);
                }
                reader.Close();
                connection.Close();
                return listData;
            }
            catch (MySqlException ex)
            {                
                MessageBox.Show(ex.Message + $"\n\n{_query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string[]>();
            }
        }

        public string QueryToCell(string query)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string result = reader.GetValue(0).ToString();
                reader.Close();
                connection.Close();
                return result;
            }
            catch (MySqlException ex)
            {                
                MessageBox.Show(ex.Message + $"\n\n{query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public bool QueryToBool(string query)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                bool hasRows = reader.HasRows;
                reader.Close();
                connection.Close();
                return hasRows;
            }
            catch (MySqlException ex)
            {               
                MessageBox.Show(ex.Message + $"\n\n{query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
