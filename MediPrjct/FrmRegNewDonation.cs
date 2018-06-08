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
    public partial class FrmRegNewDonation : Form
    {
        public FrmRegNewDonation()
        {
            InitializeComponent();
            lblTimeStampFrmRegNewDonation.Text = DateTime.Now.ToString();
        }

        private void btnCancelDonation_Click(object sender, EventArgs e)
        {
            FrmStart objFrmStart = new FrmStart();
            this.Hide();
            objFrmStart.Show();
        }
    }
}
