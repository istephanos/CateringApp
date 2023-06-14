using Oracle.ManagedDataAccess.Client;

using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Catering
{
    public partial class Home : UserControl
    {
        private readonly string connectionString;

        public Home()
        {
            InitializeComponent();
            this.connectionString = ConfigurationManager.AppSettings["OracleConnectionString"];
            CountClients();
            CountProducts();
            CountEvents();
        }
        private void CountClients()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT Count(*) FROM Clienti";
                    OracleCommand cmd = new OracleCommand(query, con);
                    OracleDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    labelNrClienti.Text = "Nr: " + dt.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CountEvents()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT Count(*) FROM Evenimente";
                    OracleCommand cmd = new OracleCommand(query, con);
                    OracleDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    labelNrEvenimente.Text = "Nr: " + dt.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CountProducts()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT Count(*) FROM Produse";
                    OracleCommand cmd = new OracleCommand(query, con);
                    OracleDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    labelNrProduse.Text = "Nr: " + dt.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
