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
        Employee emp;

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
                    emp = new Employee();
                    dslokal = db.GetEmployee(username);
                    emp.Id = Convert.ToInt32(dslokal.Tables[0].Rows[0].ItemArray[0]);
                    emp.BirthDate = dslokal.Tables[0].Rows[0].ItemArray[1].ToString();
                    emp.FirstName = dslokal.Tables[0].Rows[0].ItemArray[2].ToString();
                    emp.LastName = dslokal.Tables[0].Rows[0].ItemArray[3].ToString();
                    emp.Password = dslokal.Tables[0].Rows[0].ItemArray[4].ToString();

                    string name = emp.FirstName + " " + emp.LastName;
                    int id = emp.Id;
                    //FrmLogin fl = new FrmLogin(emp);

                    FrmStart objFrmStart = new FrmStart(emp);
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

        /*private Employee getEmp(string username)
        {
            emp = new Employee();
            dslokal = db.GetEmployee(username);
            emp.Id = Convert.ToInt32(dslokal.Tables[0].Rows[0].ItemArray[0]);
            emp.BirthDate = dslokal.Tables[0].Rows[0].ItemArray[1].ToString();
            emp.FirstName = dslokal.Tables[0].Rows[0].ItemArray[2].ToString();
            emp.LastName = dslokal.Tables[0].Rows[0].ItemArray[3].ToString();
            emp.Password = dslokal.Tables[0].Rows[0].ItemArray[4].ToString();
            return emp;
        }*/

        /*public String getEmpName()
        {
            return emp.FirstName + " " + emp.LastName;
        }

        public int getEmpId()
        {
            return emp.Id;
        }*/

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}