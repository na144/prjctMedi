using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediPrjct
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
            lblTimeStampFrmStart.Text = DateTime.Now.ToString();
        }

        private void btnRegNewDonar_Click(object sender, EventArgs e)
        {
            FrmRegNewDonar objFrmRegNewDonar = new FrmRegNewDonar();
            this.Hide();
            objFrmRegNewDonar.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin objFrmLogin = new FrmLogin();
            this.Hide();
            objFrmLogin.Show();
        }

        private void btnRegNewDonation_Click(object sender, EventArgs e)
        {
            FrmRegNewDonation objFrmRegNewDonation = new FrmRegNewDonation();
            this.Hide();
            objFrmRegNewDonation.Show();
        }

        private void lblTimeStamp_Click(object sender, EventArgs e)
        {

        }
    }
}
