using Oracle.ManagedDataAccess.Client;

using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

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
        }

        public  void EXEMPLU()
        {
            using (var oracleConection = new OracleConnection(connectionString))
            {
                oracleConection.Open();

                using (var oracleCommand = new OracleCommand(/*oracle query*/))
                {
                   // oracleCommand.Parameters.Add(/*adaugare parametrii*/);
                    //
                    //
                    //

                    oracleCommand.ExecuteReader(); // <- citire
                    oracleCommand.ExecuteNonQuery(); // <- adaugare/update/stergere
                }
            }
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
            OracleConnection con = new OracleConnection(connectionString);

            try
            {
                con.Open();
                string query = "select * from Clienti";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                ClientDGV.DataSource = ds.Tables[0];
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


        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if(NumeClientTb.Text=="" || PrenumeClientTb.Text=="" || TelefonClientTb.Text=="" || EmailClientTb.Text=="")
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

                            oracleCommand.ExecuteNonQuery(); // <- adaugare/update/stergere
                        }
                    }
                    reset();
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
                    oracleCommand.Parameters.Add("ID_CLIENT", OracleDbType.Varchar2).Value = EmailClientTb.Text;

                    oracleCommand.ExecuteNonQuery(); // <- adaugare/update/stergere
                }

            }
        }

        private void ClientDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NumeClientTb.Text = ClientDGV.CurrentRow.Cells[1].Value.ToString();
            PrenumeClientTb.Text = ClientDGV.CurrentRow.Cells[2].Value.ToString();
            TelefonClientTb.Text = ClientDGV.CurrentRow.Cells[3].Value.ToString();
            EmailClientTb.Text= ClientDGV.CurrentRow.Cells[4].Value.ToString();

            if(NumeClientTb.Text=="")
            {
                key = 0;
                reset();
            }
            else
            {
                key = Convert.ToInt32(ClientDGV.CurrentRow.Cells[0].Value.ToString());
            }
        }
    }
}
