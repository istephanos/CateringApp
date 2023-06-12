using Oracle.ManagedDataAccess.Client;

using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Catering
{
    public partial class Client : UserControl
    {
        private readonly string connectionString;
        public Client()
        {
            InitializeComponent();
            this.connectionString = ConfigurationManager.AppSettings["OracleConnectionString"];
            ShowClients();
            ClientDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClientDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            ClientDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ClientDGV.Columns[0].HeaderText = "ID client";
            ClientDGV.Columns[1].HeaderText = "Nume client";
            ClientDGV.Columns[2].HeaderText = "Prenume client";
            ClientDGV.Columns[3].HeaderText = "Telefon client";
            ClientDGV.Columns[4].HeaderText = "Email client";
        }

        private void reset()
        {
            NumeClientTb.Clear();
            PrenumeClientTb.Clear();
            TelefonClientTb.Clear();
            EmailClientTb.Clear();
        }
        private void ShowClients()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Clienti";
                    OracleCommand cmd = new OracleCommand(query, con);
                    OracleDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    ClientDGV.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ClientDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NumeClientTb.Text = ClientDGV.CurrentRow.Cells[1].Value.ToString();
            PrenumeClientTb.Text = ClientDGV.CurrentRow.Cells[2].Value.ToString();
            TelefonClientTb.Text = ClientDGV.CurrentRow.Cells[3].Value.ToString();
            EmailClientTb.Text = ClientDGV.CurrentRow.Cells[4].Value.ToString();

            if (NumeClientTb.Text == "")
            {
                key = 0;
                reset();
            }
            else
            {
                key = Convert.ToInt32(ClientDGV.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (NumeClientTb.Text == "" || PrenumeClientTb.Text == "" || TelefonClientTb.Text == "" || EmailClientTb.Text == "")
            {
                MessageBox.Show("Lipsesc informatii. Asigurati-va ca ati introdus toate datele cerute!");
            }
            else
            {
                try
                {
                    using (var oracleConection = new OracleConnection(connectionString))
                    {
                        oracleConection.Open();

                        using (var oracleCommand = new OracleCommand(@"Insert into Clienti (NUME_CLIENT,PRENUME_CLIENT," +
                            "TELEFON_CLIENT,EMAIL_CLIENT) values(:NC,:PC,:TC,:EC)", oracleConection))
                        {
                            oracleCommand.Parameters.Add("NC", OracleDbType.Varchar2).Value = NumeClientTb.Text;
                            oracleCommand.Parameters.Add("PC", OracleDbType.Varchar2).Value = PrenumeClientTb.Text;
                            oracleCommand.Parameters.Add("TC", OracleDbType.Varchar2).Value = TelefonClientTb.Text;
                            oracleCommand.Parameters.Add("EC", OracleDbType.Varchar2).Value = EmailClientTb.Text;

                            oracleCommand.ExecuteNonQuery(); // <- adaugare
                        }
                    }
                    reset();
                    MessageBox.Show("Client adaugat");
                    ShowClients();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key = 0;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (NumeClientTb.Text == "" || PrenumeClientTb.Text == "" || TelefonClientTb.Text == "" || EmailClientTb.Text == "")
            {
                MessageBox.Show("Lipsesc informatii. Asigurati-va ca ati ales o inregistrare pe care sa o editati!");
            }
            else
            {
                try {
                    using (var oracleConection = new OracleConnection(connectionString))
                    {
                        oracleConection.Open();

                        using (var oracleCommand = new OracleCommand(@"Update Clienti SET NUME_CLIENT=:NC,PRENUME_CLIENT=:PC," +
                            "TELEFON_CLIENT=:TC,EMAIL_CLIENT=:EC WHERE ID_CLIENT=:ID_CLIENT", oracleConection))
                        {
                            oracleCommand.Parameters.Add("NC", OracleDbType.Varchar2).Value = NumeClientTb.Text;
                            oracleCommand.Parameters.Add("PC", OracleDbType.Varchar2).Value = PrenumeClientTb.Text;
                            oracleCommand.Parameters.Add("TC", OracleDbType.Varchar2).Value = TelefonClientTb.Text;
                            oracleCommand.Parameters.Add("EC", OracleDbType.Varchar2).Value = EmailClientTb.Text;
                            oracleCommand.Parameters.Add("ID_CLIENT", OracleDbType.Decimal).Value = key;

                            oracleCommand.ExecuteNonQuery(); // <- update
                        }
                        reset();
                        MessageBox.Show("Datele clientului au fost modificate cu succes!");
                        ShowClients();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (NumeClientTb.Text == "" || PrenumeClientTb.Text == "" || TelefonClientTb.Text == "" || EmailClientTb.Text == "")
            {
                MessageBox.Show("Selectati clientul pe care doriti sa il stergeti!");
            }
            else
            {
                try
                {
                    using (var oracleConection = new OracleConnection(connectionString))
                    {
                        oracleConection.Open();

                        using (var oracleCommand = new OracleCommand(@"Delete from Clienti where ID_CLIENT=:ID_CLIENT", oracleConection))
                        {
                            oracleCommand.Parameters.Add("ID_CLIENT", OracleDbType.Decimal).Value = key;

                            oracleCommand.ExecuteNonQuery(); // <- stergere
                        }
                        MessageBox.Show("Datele clientului au fost sterse");
                        reset();
                        ShowClients();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            if (CautareTb.Text == "")
            {
                MessageBox.Show("Introduceti numele clientului cautat!");
            }
            else
            {
                try
                {
                    string SearchData = CautareTb.Text;
                    string Query = "SELECT * FROM Clienti";
                    if (ColumnCb.SelectedIndex == 0)
                    {
                        Query += " WHERE NUME_CLIENT LIKE '%" + SearchData + "%' OR " +
                            "PRENUME_CLIENT LIKE '%" + SearchData + "%' OR TELEFON_CLIENT LIKE '%" + SearchData
                            + "%'" + "%' OR EMAIL_CLIENT LIKE '%" + SearchData + "%'";
                        if (int.TryParse(SearchData, out _))
                        {
                            Query += " OR ID_CLIENT = " + SearchData;
                        }
                    }
                    else
                    {
                        if (ColumnCb.SelectedIndex == 1 && SearchData.Length > 0)
                        {
                            Query += " WHERE ID_CLIENT = " + SearchData;
                        }
                        else if (ColumnCb.SelectedIndex == 2)
                        {
                            Query += " WHERE NUME_CLIENT LIKE '%" + SearchData + "%'";
                        }
                        else if (ColumnCb.SelectedIndex == 3)
                        {
                            Query += " WHERE PRENUME_CLIENT LIKE '%" + SearchData + "%'";
                        }
                        else if (ColumnCb.SelectedIndex == 4)
                        {
                            Query += " WHERE TELEFON_CLIENT LIKE '%" + SearchData + "%'";
                        }
                    }

                    using (OracleConnection con = new OracleConnection(connectionString))
                    {
                        con.Open();
                        OracleCommand command = new OracleCommand(Query, con);
                        OracleDataAdapter adapter = new OracleDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        ClientDGV.DataSource = dt;
                    }

                    // ShowClients();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CautareTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string SearchData = CautareTb.Text;
                string Query = "SELECT * FROM Clienti";
                if (ColumnCb.SelectedIndex == 0)
                {
                    Query += " WHERE NUME_CLIENT LIKE '%" + SearchData + "%' OR " +
                        "PRENUME_CLIENT LIKE '%" + SearchData + "%' OR TELEFON_CLIENT LIKE '%" + SearchData + "%'";
                    if (int.TryParse(SearchData, out _))
                    {
                        Query += " OR ID_CLIENT = " + SearchData;
                    }
                }
                else
                {
                    if (ColumnCb.SelectedIndex == 1 && SearchData.Length > 0)
                    {
                        Query += " WHERE ID_CLIENT = " + SearchData;
                    }
                    else if (ColumnCb.SelectedIndex == 2)
                    {
                        Query += " WHERE NUME_CLIENT LIKE '%" + SearchData + "%'";
                    }
                    else if (ColumnCb.SelectedIndex == 3)
                    {
                        Query += " WHERE PRENUME_CLIENT LIKE '%" + SearchData + "%'";
                    }
                    else if (ColumnCb.SelectedIndex == 4)
                    {
                        Query += " WHERE TELEFON_CLIENT LIKE '%" + SearchData + "%'";
                    }
                }

                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    OracleCommand command = new OracleCommand(Query, con);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    ClientDGV.DataSource = dt;
                }

                reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        //validari
        //validare Nume
        private void eventNumeClientTb(object sender, EventArgs e)
        {
            string nume = NumeClientTb.Text.Trim();

            if (string.IsNullOrEmpty(nume))
            {
                labelNumeClient.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
            else if (nume.Length > 15 || !nume.All(char.IsLetter))
            {
                labelNumeClient.ForeColor = Color.Red;
                errorProvider1.SetError(NumeClientTb, "Numele contine doar litere!");
            }
            else
            {
                labelNumeClient.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
        }

        //validare prenume
        private void eventPrenumeClientTb(object sender, EventArgs e)
        {
            string prenumeClient = PrenumeClientTb.Text.Trim();
            string prenume = prenumeClient.Replace("-", "").Replace(" ", "");

            if (string.IsNullOrEmpty(prenume))
            {
                labelPrenumeClient.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
            else if (prenume.Length > 15 || !Regex.IsMatch(prenume, @"^[a-zA-Z]+([ -][a-zA-Z]+)*$"))
            {
                labelPrenumeClient.ForeColor = Color.Red;
                errorProvider1.SetError(PrenumeClientTb, "Prenumele conține doar litere și permite un singur caracter spațiu sau linie între cuvinte!");
            }
            else
            {
                labelPrenumeClient.ForeColor = Color.Black;
                errorProvider1.Clear();
            }

        }


        //validare email
        private void eventEmailClient(object sender, EventArgs e)
        {
            string email = EmailClientTb.Text.Trim();
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
            {
                labelEmailClient.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
            else if (!Regex.IsMatch(email, emailPattern))
            {
                labelEmailClient.ForeColor = Color.Red;
                errorProvider1.SetError(EmailClientTb, "Adresa de e-mail nu este validă.");
            }
            else
            {
                labelEmailClient.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
        }

        //validare numar de telefon
        private void eventTelefonClientTb(object sender, EventArgs e)
        {
            string telefon = TelefonClientTb.Text.Trim();

            // Înlăturăm spațiile și cratimele din numărul de telefon
            string numarTelefon = telefon.Replace(" ", "").Replace("-", "");

            if (string.IsNullOrEmpty(numarTelefon))
            {
                labelTelefonClient.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
            else if (!Regex.IsMatch(numarTelefon, @"^\+?[0-9]{10}$"))
            {
                labelTelefonClient.ForeColor = Color.Red;
                errorProvider1.SetError(TelefonClientTb, "Numărul de telefon nu este valid.");
            }
            else
            {
                labelTelefonClient.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
        }
    }
}

