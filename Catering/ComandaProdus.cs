using Oracle.ManagedDataAccess.Client;

using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Catering
{
    public partial class ComandaProdus : UserControl
    {
        private readonly string connectionString;
        private int selectedEventId; // Id-ul evenimentului selectat

        public ComandaProdus()
        {
            InitializeComponent();
            this.connectionString = ConfigurationManager.AppSettings["OracleConnectionString"];
            ShowProductsInListView();
            ShowOrders();
            GetEventName();

            ComenziDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ComenziDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ComenziDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

                    listViewProduse.Clear(); // Curățare ListView pentru a evita duplicarea datelor
                    listViewProduse.View = View.List;

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem();

                        item.Text = reader["DESCRIERE_PRODUS"].ToString();
                        item.SubItems.Add(reader["DENUMIRE_PRODUS"].ToString());

                        listViewProduse.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowOrders()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT c.ID_EVENIMENT, e.DENUMIRE_EVENIMENT, c.ID_PRODUS, p.DENUMIRE_PRODUS, c.CANTITATE, c.PRET_TOTAL " +
                                   "FROM COMANDA_PRODUS c " +
                                   "INNER JOIN Evenimente e ON c.ID_EVENIMENT = e.ID_EVENIMENT " +
                                   "INNER JOIN Produse p ON c.ID_PRODUS = p.ID_PRODUS";
                    OracleCommand cmd = new OracleCommand(query, con);
                    OracleDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    ComenziDGV.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetEventName()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT e.ID_EVENIMENT, e.DENUMIRE_EVENIMENT, c.NUME_CLIENT, c.PRENUME_CLIENT " +
                                   "FROM Evenimente e " +
                                   "INNER JOIN Clienti c ON e.ID_CLIENT = c.ID_CLIENT";
                    OracleCommand cmd = new OracleCommand(query, con);
                    OracleDataReader rdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID_EVENIMENT", typeof(int));
                    dt.Columns.Add("DENUMIRE_EVENIMENT", typeof(string));
                    dt.Columns.Add("NUME_CLIENT", typeof(string));
                    dt.Columns.Add("PRENUME_CLIENT", typeof(string));
                    dt.Columns.Add("NUME_COMPLET", typeof(string));

                    while (rdr.Read())
                    {
                        int idEveniment = rdr.GetInt32(0);
                        string denumireEveniment = rdr.GetString(1);
                        string numeClient = rdr.GetString(2);
                        string prenumeClient = rdr.GetString(3);
                        string numeComplet = denumireEveniment + " " + numeClient + " " + prenumeClient;

                        dt.Rows.Add(idEveniment, denumireEveniment, numeClient, prenumeClient, numeComplet);
                    }

                    numeEvenimentCb.ValueMember = "ID_EVENIMENT";
                    numeEvenimentCb.DisplayMember = "NUME_COMPLET";
                    numeEvenimentCb.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetNumberOfGuests(int eventId, OracleConnection con)
        {
            string query = "SELECT NUMAR_INVITATI FROM Evenimente WHERE ID_EVENIMENT = :EventId";
            OracleCommand cmd = new OracleCommand(query, con);
            cmd.Parameters.Add(":EventId", OracleDbType.Int32).Value = eventId;

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            return 0;
        }

        private int GetProductIdByName(string productName, OracleConnection con)
        {
            string query = "SELECT ID_PRODUS FROM Produse WHERE DENUMIRE_PRODUS = :ProductName";
            OracleCommand cmd = new OracleCommand(query, con);
            cmd.Parameters.Add(":ProductName", OracleDbType.Varchar2).Value = productName;

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            return 0;
        }

        private decimal GetProductPrice(int productId, OracleConnection con)
        {
            string query = "SELECT PRET_PRODUS FROM Produse WHERE ID_PRODUS = :ProductId";
            OracleCommand cmd = new OracleCommand(query, con);
            cmd.Parameters.Add(":ProductId", OracleDbType.Int32).Value = productId;

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                return Convert.ToDecimal(result);
            }

            return 0;
        }

        private void SaveOrder(int eventId, int productId, int quantity, decimal totalAmount, OracleConnection con)
        {
            string query = "INSERT INTO COMANDA_PRODUS (ID_EVENIMENT, ID_PRODUS, CANTITATE, PRET_TOTAL) " +
                           "VALUES (:EventId, :ProductId, :Quantity, :TotalAmount)";
            OracleCommand cmd = new OracleCommand(query, con);
            cmd.Parameters.Add(":EventId", OracleDbType.Int32).Value = eventId;
            cmd.Parameters.Add(":ProductId", OracleDbType.Int32).Value = productId;
            cmd.Parameters.Add(":Quantity", OracleDbType.Int32).Value = quantity;
            cmd.Parameters.Add(":TotalAmount", OracleDbType.Decimal).Value = totalAmount;

            cmd.ExecuteNonQuery();
        }

        private void btnComanda_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    // Obținere număr de invitați pentru evenimentul selectat
                    int numarInvitati = GetNumberOfGuests(selectedEventId, con);

                    // Preluare produse selectate și cantitățile aferente
                    foreach (ListViewItem item in listViewProduse.CheckedItems)
                    {
                        string denumireProdus = item.SubItems[1].Text;
                        int idProdus = GetProductIdByName(denumireProdus, con);

                        // Calcul pret comanda pentru produsul selectat
                        decimal pretProdus = GetProductPrice(idProdus, con);
                        decimal pretComanda = pretProdus * numarInvitati;

                        // Salvare în tabelul COMANDA_PRODUS
                        SaveOrder(selectedEventId, idProdus, numarInvitati, pretComanda, con);
                    }

                    ShowOrders();
                    MessageBox.Show("Comanda a fost salvata cu succes!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numeEvenimentCb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedEventId = Convert.ToInt32(numeEvenimentCb.SelectedValue);
        }
    }
}
