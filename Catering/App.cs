using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Catering
{
    public partial class App : Form
    {
        private readonly string connectionString;

        public App()
        {
            InitializeComponent();
            this.connectionString = ConfigurationManager.AppSettings["OracleConnectionString"];
            CountClients();
            CountProducts();
            CountEvents();
        }

        private void addUC(UserControl uc)
        {
            panelCenter.Controls.Clear();
            uc.Dock= DockStyle.Fill;
            panelCenter.Controls.Add(uc);
        }

        private void moveSidePanel(Button btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            addUC(new Home());
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnClient);
            addUC(new Client());
        }


        private void btnEveniment_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnEveniment);
            addUC(new Eveniment());
        }

       
        private void btnProdus_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnProdus);
            addUC(new Produs());
        }

        private void btnComandaProdus_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnProdus);
            addUC(new ComandaProdus());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnLogout);
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close the application?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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
