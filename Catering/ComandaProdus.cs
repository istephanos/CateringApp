using Oracle.ManagedDataAccess.Client;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catering
{
    public partial class ComandaProdus : UserControl
    {
        private readonly string connectionString;
        private int key = 0;
        public ComandaProdus()
        {
            InitializeComponent();
            this.connectionString = ConfigurationManager.AppSettings["OracleConnectionString"];
            ShowOrders();
            GetEventName();
        }

        private void ShowOrders()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Comanda_Produs";
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
            OracleConnection con = new OracleConnection(connectionString);
            con.Open();
            OracleCommand cmd = new OracleCommand("SELECT ID_EVENIMENT, DENUMIRE_EVENIMENT FROM EVENIMENTE", con);
            OracleDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_EVENIMENT", typeof(int));
            dt.Columns.Add("DENUMIRE_EVENIMENT", typeof(string));
            dt.Load(rdr);
            denumireEvenimentCb.ValueMember = "ID_EVENIMENT";
            denumireEvenimentCb.DisplayMember = "DENUMIRE_EVENIMENT";
            con.Close();
        }
    }
}
