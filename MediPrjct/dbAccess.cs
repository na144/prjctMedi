using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPrjct
{
    public class dbAccess
    {
        //Deklarerar resurser
        DataSet ds; //dataset
        SqlCommand myCommand; //kommandorad
        SqlDataAdapter adapter; //adapter som fyller datasetet
        SqlConnection myConnection; //connectionsträngen
        SqlDataReader dr;

       SqlParameter workparameter1; //parametervariabler
        SqlParameter workparameter2;
        SqlParameter workparameter3;
        SqlParameter workparameter4;
        SqlParameter workparameter5;
        SqlParameter workparameter6;
        SqlParameter workparameter7;

        public dbAccess()
        { //Skapar en connectionsträng för att koppla sig till databasen
            myConnection = new SqlConnection(); // Byt här till din databas och till din MS-SQL server (obs. dubbla \\)
            myConnection.ConnectionString = "Server=LAPTOP-968N0DPK\\SQL2014EXPRESS;Database=dbMediABO;Trusted_Connection=True;";
            // V - "Server=LAPTOP-B0P8Q1VE\\SQLEXPRESS;Database=dbMediABO;Trusted_Connection=True;";
            // L - "LAPTOP-N1P331T2\\SQLEXPRESS;Database=dbMediABO;Trusted_Connection=True;";
           
        }

        public bool validateUser(string username, string password)
        { //Tar reda på om en viss epostadress finns för anställd, returnerar variabeltypen bool
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spLoginValidate"; //Namnet på den lagrade proceduren i db
            SqlParameter workparameter1 = new SqlParameter();
            SqlParameter workparameter2 = new SqlParameter();
            SqlParameter workparameter3 = new SqlParameter();
            workparameter1 = myCommand.Parameters.Add("@BirthDate", SqlDbType.VarChar); //@BirthDate är en parameter/variabel som finns i spFinnsAnsteldsEpost
            workparameter1.Value = username;
            workparameter2 = myCommand.Parameters.Add("@Password", SqlDbType.VarChar);
            workparameter2.Value = password;
            workparameter3 = myCommand.Parameters.Add("@AntalRader", SqlDbType.Int);
            workparameter3.Direction = ParameterDirection.Output;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            int svar = Convert.ToInt32(workparameter3.SqlValue.ToString());
            myConnection.Close();
            if (svar == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertDonarToDB(Donar newDonar)
        {
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spRegNewDonar";

            SqlParameter workparameter1 = new SqlParameter();
            SqlParameter workparameter2 = new SqlParameter();
            SqlParameter workparameter3 = new SqlParameter();
            SqlParameter workparameter4 = new SqlParameter();
            SqlParameter workparameter5 = new SqlParameter();
            SqlParameter workparameter6 = new SqlParameter();
            SqlParameter workparameter7 = new SqlParameter();
            SqlParameter workparameter8 = new SqlParameter();
            SqlParameter workparameter9 = new SqlParameter();
            SqlParameter workparameter10 = new SqlParameter();

            workparameter1 = myCommand.Parameters.Add("@FirstName", SqlDbType.VarChar);
            workparameter1.Value = newDonar.FirstName;

            workparameter2 = myCommand.Parameters.Add("@LastName", SqlDbType.VarChar);
            workparameter2.Value = newDonar.LastName;

            workparameter3 = myCommand.Parameters.Add("@BirthDate", SqlDbType.VarChar);
            workparameter3.Value = newDonar.BirthDate;

            workparameter4 = myCommand.Parameters.Add("@PhoneNo", SqlDbType.VarChar);
            workparameter4.Value = newDonar.PhoneNo;

            workparameter5 = myCommand.Parameters.Add("@Address", SqlDbType.VarChar);
            workparameter5.Value = newDonar.Address;

            workparameter6 = myCommand.Parameters.Add("@PostCode", SqlDbType.Int);
            workparameter6.Value = newDonar.PostCode;

            workparameter7 = myCommand.Parameters.Add("@City", SqlDbType.VarChar);
            workparameter7.Value = newDonar.City;

            workparameter8 = myCommand.Parameters.Add("@BloodGroup", SqlDbType.VarChar);
            workparameter8.Value = newDonar.BloodGroup;

            workparameter9 = myCommand.Parameters.Add("@Gender", SqlDbType.VarChar);
            workparameter9.Value = newDonar.Gender;

            workparameter10 = myCommand.Parameters.Add("@AntalRader", SqlDbType.Int);
            workparameter10.Direction = ParameterDirection.Output;

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            int svar = Convert.ToInt32(workparameter10.SqlValue.ToString());
            myConnection.Close();

            if (svar == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DataSet getDataByBDate(string BDate)
        {
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spGetDataByBDate"; //Namnet på den lagrade proceduren i db

            SqlParameter workparameter1 = new SqlParameter();
            workparameter1 = myCommand.Parameters.Add("@BirthDate", SqlDbType.VarChar);
            workparameter1.Value = BDate;
       

            ds = new DataSet();
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = myCommand;

            adapter.Fill(ds);
            return ds;


        }

        public bool RegisterDonation(Donation newDonation)
        {
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "spDonationBooking";

            SqlParameter workparameter1 = new SqlParameter();
            SqlParameter workparameter2 = new SqlParameter();
            SqlParameter workparameter3 = new SqlParameter();
            SqlParameter workparameter4 = new SqlParameter();

            
            workparameter1 = myCommand.Parameters.Add("@EmployeeID", SqlDbType.Int);
            workparameter1.Value = newDonation.EmployeeID;

            workparameter2 = myCommand.Parameters.Add("@DonarID", SqlDbType.Int);
            workparameter2.Value = newDonation.DonarID;

            workparameter3 = myCommand.Parameters.Add("@Date", SqlDbType.DateTime);
            workparameter3.Value = newDonation.Dt;

            workparameter4 = myCommand.Parameters.Add("@AntalRader", SqlDbType.Int);
            workparameter4.Direction = ParameterDirection.Output;

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            int svar = Convert.ToInt32(workparameter4.SqlValue.ToString());
            myConnection.Close();

            if (svar ==1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DataSet GetEmployee(string bDate)
        {
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText ="SELECT * FROM dbo.tblEmployee WHERE BirthDate = '" + bDate +"'";
            myCommand.CommandType = CommandType.Text;
            ds = new DataSet();
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = myCommand;
            myConnection.Open();
            myCommand.ExecuteNonQuery();

            
            
            adapter.Fill(ds);
            myConnection.Close();
            return ds;

            /*
            Employee em = new Employee();
            myConnection.Open();
            myCommand = new SqlCommand("SELECT * FROM dbo.tblEmployee WHERE BirthDate = " + bDate, myConnection);
            dr = myCommand.ExecuteReader();

           if (dr.Read())
            {
                

                em.Id = Convert.ToInt32(dr[0]);
                em.BirthDate = dr[1].ToString();
                em.FirstName = dr[2].ToString();
                em.LastName = dr[3].ToString();
                em.Password = dr[4].ToString();
                myConnection.Close();

                return em;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Hahaha");

                myConnection.Close();
                return em;
            }   */ 
           
        }  
        }
}
