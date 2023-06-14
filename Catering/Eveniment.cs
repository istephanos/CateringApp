using Oracle.ManagedDataAccess.Client;

using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Catering
{
    public partial class Eveniment : UserControl
    {
        private readonly string connectionString;
        private int key = 0;

        public Eveniment()
        {
            InitializeComponent();
            this.connectionString = ConfigurationManager.AppSettings["OracleConnectionString"];
            ShowEvents();
            GetClientName();
            toggleStatusEveniment();
            ShowProductsInListView();
            EvenimentDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EvenimentDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EvenimentDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EvenimentDGV.Columns[0].HeaderText = "ID Eveniment";
            EvenimentDGV.Columns[1].HeaderText = "Denumire Eveniment";
            EvenimentDGV.Columns[2].HeaderText = "ID Client";
            EvenimentDGV.Columns[3].HeaderText = "Data Comanda";
            EvenimentDGV.Columns[4].HeaderText = "Data Livrare";
            EvenimentDGV.Columns[5].HeaderText = "Adresa Livrare";
            EvenimentDGV.Columns[6].HeaderText = "Numar Invitati";
            EvenimentDGV.Columns[7].HeaderText = "Status Comanda";
            EvenimentDGV.Columns[6].DefaultCellStyle.Format = "N0";
        }

        private void ShowEvents()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Evenimente";
                    OracleCommand cmd = new OracleCommand(query, con);
                    OracleDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    EvenimentDGV.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowProductsInListView()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Produse";
                    OracleCommand cmd = new OracleCommand(query, con);
                    OracleDataReader reader = cmd.ExecuteReader();

                    listViewProduse.Clear(); // Curățați ListView pentru a evita duplicarea datelor
                    listViewProduse.View=View.List;

                    
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(); // Creați un nou element ListViewItem pentru fiecare produs

                        item.Text = reader["DESCRIERE_PRODUS"].ToString(); // Setarea primului sub-element (coloana principală)

                        // Adăugați celelalte sub-elemente (coloane) în elementul ListViewItem
                        item.SubItems.Add(reader["DENUMIRE_PRODUS"].ToString());
                        // ...

                        listViewProduse.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void reset()
        {
            denumireEvenimentTb.Clear();
            numeClientCb.ResetText();
            statusCb.ResetText();
            nrInvitatiNUD.ResetText();
            adresaEvenimentTb.Clear();
        }

        private void GetClientName()
        {
            OracleConnection con = new OracleConnection(connectionString);
            con.Open();
            OracleCommand cmd = new OracleCommand("SELECT ID_CLIENT, NUME_CLIENT, PRENUME_CLIENT FROM Clienti", con);
            OracleDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_CLIENT", typeof(int));
            dt.Columns.Add("NUME_COMPLET", typeof(string)); // Adaugă o nouă coloană pentru numele complet

            while (rdr.Read())
            {
                int idClient = rdr.GetInt32(0);
                string nume = rdr.GetString(1);
                string prenume = rdr.GetString(2);
                string numeComplet = nume + " " + prenume;

                dt.Rows.Add(idClient, numeComplet);
            }

            numeClientCb.ValueMember = "ID_CLIENT";
            numeClientCb.DisplayMember = "NUME_COMPLET";
            numeClientCb.DataSource = dt;
            con.Close();
        }

        private string GetClientNameById(int clientId)
        {
            string clientName = string.Empty;

            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT NUME_CLIENT, PRENUME_CLIENT FROM Clienti WHERE ID_CLIENT = :ClientId";
                    OracleCommand cmd = new OracleCommand(query, con);
                    cmd.Parameters.Add(":ClientId", OracleDbType.Int32).Value = clientId;

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        clientName = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return clientName;
        }

        private void EvenimentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            denumireEvenimentTb.Text = EvenimentDGV.CurrentRow.Cells[1].Value.ToString();
            int idClient;
            if (EvenimentDGV.CurrentRow.Cells[2].Value != DBNull.Value)
            {
                idClient = Convert.ToInt32(EvenimentDGV.CurrentRow.Cells[2].Value);
                numeClientCb.Text = GetClientNameById(idClient);
            }
            else
            {
                numeClientCb.Text = string.Empty;
            }
            dataLivrariiDTP.Text = EvenimentDGV.CurrentRow.Cells[4].Value.ToString();
            adresaEvenimentTb.Text = EvenimentDGV.CurrentRow.Cells[5].Value.ToString();
            nrInvitatiNUD.Text = EvenimentDGV.CurrentRow.Cells[6].Value.ToString();
            statusCb.Text = EvenimentDGV.CurrentRow.Cells[7].Value.ToString();

            if (denumireEvenimentTb.Text == "")
            {
                key = 0;
                reset();
            }
            else
            {
                key = Convert.ToInt32(EvenimentDGV.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            // Obțineți data curentă
            DateTime dataCurenta = DateTime.Now.Date;

            // Verificați dacă data livrării este mai mică decât data curentă
            if (dataLivrariiDTP.Value < dataCurenta)
            {
                MessageBox.Show("Data livrării trebuie să fie mai mare sau egală cu data curentă.", "Eroare de validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (denumireEvenimentTb.Text=="" || numeClientCb.Text=="" || statusCb.Text=="" || nrInvitatiNUD.Value==0 || adresaEvenimentTb.Text=="")
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

                        using (var oracleCommand = new OracleCommand(@"Insert into Evenimente 
                        (DENUMIRE_EVENIMENT,ID_CLIENT,DATA_COMANDA,DATA_LIVRARE,ADRESA_LIVRARE,NUMAR_INVITATI,STATUS_COMANDA)
                    values(:DE,:IC,:DC,:DL,:AL,:NI,:SC)", oracleConection))
                        {
                            oracleCommand.Parameters.Add("DE", OracleDbType.Varchar2).Value = denumireEvenimentTb.Text;
                            oracleCommand.Parameters.Add("IC", OracleDbType.Decimal).Value = numeClientCb.SelectedValue;
                            oracleCommand.Parameters.Add("DC", OracleDbType.Date).Value = DateTime.Now;
                            oracleCommand.Parameters.Add("DL", OracleDbType.Date).Value = dataLivrariiDTP.Value;
                            oracleCommand.Parameters.Add("AL", OracleDbType.Varchar2).Value = adresaEvenimentTb.Text;
                            oracleCommand.Parameters.Add("NI", OracleDbType.Decimal).Value =nrInvitatiNUD.Text;
                            oracleCommand.Parameters.Add("SC", OracleDbType.Varchar2).Value = statusCb.Text;

                            oracleCommand.ExecuteNonQuery(); // <- adaugare
                        }
                    }
                    reset();
                    MessageBox.Show("Eveniment adaugat");
                    ShowEvents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void toggleStatusEveniment()
        {
            using (var oracleConection = new OracleConnection(connectionString))
            {
                oracleConection.Open();

                // Obțineți data livrării din controldate
                DateTime dataLivrarii = dataLivrariiDTP.Value;

                // Verificați dacă data curentă depășește data livrării
                if (DateTime.Now.Date > dataLivrarii.Date)
                {
                    // Actualizați statusul evenimentului ca "finalizat"
                    using (var updateCommand = new OracleCommand(@"UPDATE Evenimente SET STATUS_COMANDA = 'Finalizat' WHERE ID_EVENIMENT = :KEY", oracleConection))
                    {
                        updateCommand.Parameters.Add("KEY", OracleDbType.Decimal).Value = key;
                        updateCommand.ExecuteNonQuery();
                    }
                }
                oracleConection.Close();

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (denumireEvenimentTb.Text == "" || numeClientCb.Text == "" || statusCb.Text == "" || nrInvitatiNUD.Value == 0 || adresaEvenimentTb.Text == "")
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

                        using (var oracleCommand = new OracleCommand(@"Update Evenimente SET
                        DENUMIRE_EVENIMENT=:DE,ID_CLIENT=:IC,DATA_COMANDA=:DC,DATA_LIVRARE=:DL,ADRESA_LIVRARE=:AL
                    ,NUMAR_INVITATI=:NI,STATUS_COMANDA=:SC WHERE ID_EVENIMENT=:KEY", oracleConection))
                        {
                            oracleCommand.Parameters.Add("DE", OracleDbType.Varchar2).Value = denumireEvenimentTb.Text;
                            oracleCommand.Parameters.Add("IC", OracleDbType.Decimal).Value = numeClientCb.SelectedValue;
                            oracleCommand.Parameters.Add("DC", OracleDbType.Date).Value = DateTime.Now;
                            oracleCommand.Parameters.Add("DL", OracleDbType.Date).Value = dataLivrariiDTP.Value;
                            oracleCommand.Parameters.Add("AL", OracleDbType.Varchar2).Value = adresaEvenimentTb.Text;
                            oracleCommand.Parameters.Add("NI", OracleDbType.Decimal).Value = nrInvitatiNUD.Text;
                            oracleCommand.Parameters.Add("SC", OracleDbType.Varchar2).Value = statusCb.Text;
                            oracleCommand.Parameters.Add("KEY", OracleDbType.Decimal).Value = key;

                            oracleCommand.ExecuteNonQuery(); // <- adaugare
                         
                        }
                        // Obțineți data livrării din DataGridView
                        DateTime dataLivrarii = Convert.ToDateTime(EvenimentDGV.CurrentRow.Cells[4].Value);

                        // Verificați dacă data curentă depășește data livrării
                        if (DateTime.Now.Date > dataLivrarii.Date)
                        {
                            // Actualizați statusul evenimentului ca "finalizat"
                            using (var updateCommand = new OracleCommand(@"UPDATE Evenimente SET STATUS_COMANDA = 'Finalizat' WHERE ID_EVENIMENT = :KEY", oracleConection))
                            {
                                updateCommand.Parameters.Add("KEY", OracleDbType.Decimal).Value = key;
                                updateCommand.ExecuteNonQuery();
                            }
                        }

                    }
                    reset();
                    MessageBox.Show("Eveniment editat cu succes!");
                    ShowEvents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (denumireEvenimentTb.Text == "" || numeClientCb.Text == "" || statusCb.Text == "" || nrInvitatiNUD.Value == 0 || adresaEvenimentTb.Text == "")
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

                        using (var oracleCommand = new OracleCommand(@"Delete from Evenimente
                WHERE ID_EVENIMENT=:KEY", oracleConection))
                        {
                            oracleCommand.Parameters.Add("KEY", OracleDbType.Decimal).Value = key;

                            oracleCommand.ExecuteNonQuery(); // <- adaugare
                        }
                    }
                    reset();
                    MessageBox.Show("Eveniment sters!");
                    ShowEvents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        //validari
        private void eventDenumireEvenimentTb(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(denumireEvenimentTb.Text))
            {
                labelDenumireEveniment.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
            else if (denumireEvenimentTb.Text.Length > 50 || !Regex.IsMatch(denumireEvenimentTb.Text, @"^[a-zA-Z][a-zA-Z0-9 ]*$"))
            {
                labelDenumireEveniment.ForeColor = Color.Red;
                errorProvider1.SetError(denumireEvenimentTb, "Denumirea evenimentului este incorecta (doar litere, cifre,excluzand " +
                    "primul caracter care trebuie sa fie obligatoriu o litera, si spatiu)!");
            }
            else
            {
                labelDenumireEveniment.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
        }

        private void eventAdresaEvenimentTb(object sender, EventArgs e)
        {
            Console.Write("Am intrat aici cu valoarea: " + adresaEvenimentTb.Text);

            if (string.IsNullOrEmpty(adresaEvenimentTb.Text))
            {
                labelAdresa.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
            else if (adresaEvenimentTb.Text.Length > 50 || !Regex.IsMatch(adresaEvenimentTb.Text, @"^[a-zA-Z][a-zA-Z0-9.,; ]*$"))
            {
                Console.Write("Am intrat aici cu valoarea: " + adresaEvenimentTb.Text);

                labelAdresa.ForeColor = Color.Red;
                errorProvider1.SetError(adresaEvenimentTb, "Adresa evenimentului este incorectă (doar litere, cifre, puncte, virgule și punct și virgulă între cuvinte, excluzând primul caracter care trebuie să fie obligatoriu o literă și spațiu)!");
            }
            else
            {
                Console.Write("Am intrat aici cu valoarea: " + adresaEvenimentTb.Text);

                labelAdresa.ForeColor = Color.Black;
                errorProvider1.Clear();
            }
        }
    }
}
