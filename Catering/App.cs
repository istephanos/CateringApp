using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catering
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUC(UserControl uc)
        {
            panelCenter.Controls.Clear();
            uc.Dock= DockStyle.Fill;
            panelCenter.Controls.Clear();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnLogout);
        }

       
    }
}
