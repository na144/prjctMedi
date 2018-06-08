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
    public partial class FrmLogin : Form
    {
        DataSet dslokal = new DataSet();
        dbAccess db = new dbAccess();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           string username = txtUsername.Text;
           string password = txtPassword.Text;
           Boolean answer = db.validateUser(username, password);
            try
            {
                if (answer == true)
                {
                    FrmStart objFrmStart = new FrmStart();
                    this.Hide();
                    objFrmStart.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          

           
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}