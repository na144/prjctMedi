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
        DataSet dslokal = new DataSet();
        dbAccess db = new dbAccess();

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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string bDate = txtBirthDonation.Text;
            string donorInfo = "";

            dslokal = db.getDataByBDate(bDate);

            for (int i = 0; i < 9; i++)
            {
                donorInfo = donorInfo + dslokal.Tables[0].Rows[0].ItemArray[i].ToString() + Environment.NewLine;
            }

            txtDonation1.Text = donorInfo;


        }


        private void txtBirthDonation_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
