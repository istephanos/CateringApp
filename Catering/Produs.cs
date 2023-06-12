using Oracle.ManagedDataAccess.Client;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Catering
{
    public partial class Produs : UserControl
    {
        private readonly string connectionString;
        private int key = 0;
        public Produs()
        {
            InitializeComponent();
            this.connectionString = ConfigurationManager.AppSettings["OracleConnectionString"];
            ShowProducts();
            ProdusDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProdusDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProdusDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProdusDGV.Columns[0].HeaderText = "ID produs";
            ProdusDGV.Columns[1].HeaderText = "Denumire produs";
            ProdusDGV.Columns[2].HeaderText = "Pret produs";
            ProdusDGV.Columns[3].HeaderText = "Descriere produs";

        }

        private void ShowProducts()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Produse";
                    OracleCommand cmd = new OracleCommand(query, con);
                    OracleDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    ProdusDGV.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void reset()
        {
            denumireProdusTb.Clear();
            pretProdusNUD.ResetText();
            descriereProdusTb.Clear();
        }

        private void ProdusDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            denumireProdusTb.Text = ProdusDGV.CurrentRow.Cells[1].Value.ToString();
            pretProdusNUD.Text = ProdusDGV.CurrentRow.Cells[2].Value.ToString();
            descriereProdusTb.Text = ProdusDGV.CurrentRow.Cells[3].Value.ToString();

            if (denumireProdusTb.Text == "")
            {
                key = 0;
                reset();
            }
            else
            {
                key = Convert.ToInt32(ProdusDGV.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (denumireProdusTb.Text == "" || pretProdusNUD.Text == "" || descriereProdusTb.Text == "")
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

                        using (var oracleCommand = new OracleCommand(@"Insert into Produse 
                        (DENUMIRE_PRODUS,PRET_PRODUS,DESCRIERE_PRODUS) values(:DP,:PP,:DSP)", oracleConection))
                        {
                            oracleCommand.Parameters.Add("DP", OracleDbType.Varchar2).Value = denumireProdusTb.Text;
                            oracleCommand.Parameters.Add("PP", OracleDbType.Varchar2).Value = pretProdusNUD.Text;
                            oracleCommand.Parameters.Add("DSP", OracleDbType.Varchar2).Value = descriereProdusTb.Text;

                            oracleCommand.ExecuteNonQuery(); // <- adaugare
                        }
                    }
                    reset();
                    MessageBox.Show("Produs adaugat");
                    ShowProducts();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (denumireProdusTb.Text == "" || pretProdusNUD.Text == "" || descriereProdusTb.Text == "")
            {
                MessageBox.Show("Lipsesc informatii. Asigurati-va ca ati ales o inregistrare pe care sa o editati!");
            }
            else
            {
                try
                {
                    using (var oracleConection = new OracleConnection(connectionString))
                    {
                        oracleConection.Open();

                        using (var oracleCommand = new OracleCommand(@"Update Produse SET
                        DENUMIRE_PRODUS=:DP,PRET_PRODUS=:PP,DESCRIERE_PRODUS=:DSP WHERE ID_PRODUS=:ID", oracleConection))
                        {
                            oracleCommand.Parameters.Add("DP", OracleDbType.Varchar2).Value = denumireProdusTb.Text;
                            oracleCommand.Parameters.Add("PP", OracleDbType.Varchar2).Value = pretProdusNUD.Text;
                            oracleCommand.Parameters.Add("DSP", OracleDbType.Varchar2).Value = descriereProdusTb.Text;
                            oracleCommand.Parameters.Add("ID", OracleDbType.Decimal).Value = key;

                            oracleCommand.ExecuteNonQuery(); // <- adaugare
                        }
                    }
                    reset();
                    MessageBox.Show("Produs editat cu succes!");
                    ShowProducts();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (denumireProdusTb.Text == "" || pretProdusNUD.Text == "" || descriereProdusTb.Text == "")
            {
                MessageBox.Show("Lipsesc informatii. Asigurati-va ca ati ales o inregistrare pe care sa o stergeti!");
            }
            else
            {
                try
                {
                    using (var oracleConection = new OracleConnection(connectionString))
                    {
                        oracleConection.Open();

                        using (var oracleCommand = new OracleCommand(@"Delete from Produse WHERE ID_PRODUS=:ID", oracleConection))
                        {
                            oracleCommand.Parameters.Add("ID", OracleDbType.Decimal).Value = key;

                            oracleCommand.ExecuteNonQuery(); // <- adaugare
                        }
                    }
                    reset();
                    MessageBox.Show("Produs eliminat cu succes!");
                    ShowProducts();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void eventDenumireProdusTb(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(denumireProdusTb.Text))
            {
                labelDenumire.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
            else if (denumireProdusTb.Text.Length > 50 || !Regex.IsMatch(denumireProdusTb.Text, @"^[a-zA-Z][a-zA-Z0-9 ]*$"))
            {
                labelDenumire.ForeColor = Color.Red;
                errorProvider1.SetError(denumireProdusTb, "Denumirea produsului este incorecta (doar litere, cifre,excluzand " +
                    "primul caracter care trebuie sa fie obligatoriu o litera, si spatiu)!");
            }
            else
            {
                labelDenumire.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
        }

        private void eventDesciereProdusTb(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(descriereProdusTb.Text))
            {
                labelDescriere.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
            else if (descriereProdusTb.Text.Length > 100 || !Regex.IsMatch(descriereProdusTb.Text, @"^[a-zA-Z][a-zA-Z0-9 ]*$"))
            {
                labelDescriere.ForeColor = Color.Red;
                errorProvider1.SetError(descriereProdusTb, "Descrierea produsului este incorecta (doar litere, cifre, excluzand " +
                    "primul caracter care trebuie sa fie obligatoriu o litera, si spatiu)!");
            }
            else
            {
                labelDescriere.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
        }

        private void CautareProdusTb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string SearchData = CautareProdusTb.Text;
                string Query = "SELECT * FROM Produse";
                if (ColumnProdusCb.SelectedIndex == 0)
                {
                    Query += " WHERE DENUMIRE_PRODUS LIKE '%" + SearchData + "%' OR " +
                        "PRET_PRODUS LIKE '%" + SearchData + "%' OR DESCRIERE_PRODUS LIKE '%" + SearchData + "%'";
                    if (int.TryParse(SearchData, out _))
                    {
                        Query += " OR ID_PRODUS = " + SearchData;
                    }
                }
                else
                {
                    if (ColumnProdusCb.SelectedIndex == 1 && SearchData.Length > 0)
                    {
                        Query += " WHERE ID_PRODUS = " + SearchData;
                    }
                    else if (ColumnProdusCb.SelectedIndex == 2)
                    {
                        Query += " WHERE DENUMIRE_PRODUS LIKE '%" + SearchData + "%'";
                    }
                    else if (ColumnProdusCb.SelectedIndex == 3)
                    {
                        Query += " WHERE PRET_PRODUS LIKE '%" + SearchData + "%'";
                    }
                    else if (ColumnProdusCb.SelectedIndex == 4)
                    {
                        Query += " WHERE DESCRIERE_PRODUS LIKE '%" + SearchData + "%'";
                    }
                }

                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    OracleCommand command = new OracleCommand(Query, con);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    ProdusDGV.DataSource = dt;
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
}