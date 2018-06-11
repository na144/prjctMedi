using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediPrjct
{
    public partial class FrmRegNewDonar : Form
    {
        DataSet dslokal = new DataSet();
        dbAccess db = new dbAccess();

        public FrmRegNewDonar()
        {
            InitializeComponent();
            lblTimeStampFrmRegNewDonar.Text = DateTime.Now.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Donar d = new Donar();
                
                /*txtBirthDate.Text,
                txtFirstName.Text, 
                txtLastName.Text,
                txtAddress.Text,
                txtCity.Text,
                Int32.Parse(txtPostCode.Text),
                txtPhoneNo.Text, 
                cboBloodGroup.SelectedItem.ToString(),
                cboGender.SelectedItem.ToString()
                );  */

            d.FirstName = txtFirstName.Text;
            d.LastName = txtLastName.Text;
            d.BirthDate = txtBirthDate.Text;
            d.PhoneNo = txtPhoneNo.Text;
            d.Address = txtAddress.Text;
            d.PostCode = Int32.Parse(txtPostCode.Text);
            d.City = txtCity.Text;
            d.BloodGroup = cboBloodGroup.SelectedItem.ToString();
            d.Gender = cboGender.SelectedItem.ToString(); 

            Boolean answer = db.InsertDonarToDB(d);
            if (answer == true)
            {
                MessageBox.Show("New donar is registered.");
                txtFirstName.ResetText();
                txtLastName.ResetText();
                txtBirthDate.ResetText();
                txtPhoneNo.ResetText();
                txtAddress.ResetText();
                txtPostCode.ResetText();
                txtCity.ResetText();
                cboBloodGroup.ResetText();
                cboGender.ResetText();

            }
            else
            {
                MessageBox.Show("Invalid Input.");
            }
            


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmStart objFrmStart = new FrmStart();
            this.Hide();
            objFrmStart.Show();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
