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
        }

        private void ShowProducts()
        {
            OracleConnection con = new OracleConnection(connectionString);

            try
            {
                con.Open();
                string query = "select * from Produse";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                ProdusDGV.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
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
    }
}
