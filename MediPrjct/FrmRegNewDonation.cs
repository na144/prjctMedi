using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MediPrjct.FrmLogin;


namespace MediPrjct
{
    public partial class FrmRegNewDonation : Form
    {
        DataSet dslokal = new DataSet();
        dbAccess db = new dbAccess();
        Donar don;
        Employee emp;

        public FrmRegNewDonation(Employee e)
        {
            emp = new Employee();
            emp = e;
            InitializeComponent();
            lblTimeStampFrmRegNewDonation.Text = DateTime.Now.ToString();
            lblName.Text = "Logged in as: " + emp.FirstName + " " + emp.LastName; 

        }

        private void btnCancelDonation_Click(object sender, EventArgs e)
        {
            FrmStart objFrmStart = new FrmStart(emp);
            this.Hide();
            objFrmStart.Show();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string bDate = txtBirthDonation.Text;
            string donorInfo = "";
            //
            

            dslokal = db.getDataByBDate(bDate);
            don = new Donar();
            don.Id = Convert.ToInt32(dslokal.Tables[0].Rows[0].ItemArray[0]);
            don.BirthDate = dslokal.Tables[0].Rows[0].ItemArray[1].ToString();
            don.FirstName = dslokal.Tables[0].Rows[0].ItemArray[2].ToString();
            don.LastName = dslokal.Tables[0].Rows[0].ItemArray[3].ToString();
            don.Address = dslokal.Tables[0].Rows[0].ItemArray[4].ToString();
            don.City = dslokal.Tables[0].Rows[0].ItemArray[5].ToString();
            don.PostCode = Convert.ToInt32(dslokal.Tables[0].Rows[0].ItemArray[6]);
            don.PhoneNo = dslokal.Tables[0].Rows[0].ItemArray[7].ToString();
            don.BloodGroup = dslokal.Tables[0].Rows[0].ItemArray[8].ToString();
            don.Gender = dslokal.Tables[0].Rows[0].ItemArray[9].ToString();

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

        private void FrmRegNewDonation_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveDonation_Click(object sender, EventArgs e)
        {

            Donation donation = new Donation();

           
            donation.EmployeeID = emp.Id;
            donation.DonarID = don.Id;
            donation.Dt = DateTime.Now;

            db.RegisterDonation(donation);

            MessageBox.Show("New donation is registered.");
            txtBirthDonation.ResetText();
            txtDonation1.ResetText();


        }

        private void txtDonation1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
