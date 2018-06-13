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
        Employee emp;
        public FrmStart(Employee e)
        {
            emp = new Employee();
            emp = e;
            InitializeComponent();
            lblTimeStampFrmStart.Text = DateTime.Now.ToString();
            lblName.Text = "Logged in as: " + emp.FirstName + " " + emp.LastName;
        }

        private void btnRegNewDonar_Click(object sender, EventArgs e)
        {
            FrmRegNewDonar objFrmRegNewDonar = new FrmRegNewDonar(emp);
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
            FrmRegNewDonation objFrmRegNewDonation = new FrmRegNewDonation(emp);
            this.Hide();
            objFrmRegNewDonation.Show();
        }

        private void lblTimeStamp_Click(object sender, EventArgs e)
        {
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {

        }
    }
}
