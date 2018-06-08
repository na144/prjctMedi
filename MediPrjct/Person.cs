using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPrjct
{
    public abstract class Person    
    {
        private int id;
        private string birthDate;
        private string firstName;
        private string lastName;

        public Person()
        {
            this.id = 0;
            this.birthDate = "";
            this.firstName = "";
            this.lastName = "";
        }

        public Person(int id, string bDate, string fName, string lName)
        {
            this.id = id;
            this.birthDate = bDate;
            this.firstName = fName;
            this.lastName = lName;
        }
            public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string BirthDate
        {
            get
            {
                return this.birthDate;
            }
            set
            {
                this.birthDate = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

    }

    public class Donar : Person
    {
        private string address;
        private string city;
        private int postCode;
        private string phoneNo;
        private string bloodGroup;
        private string gender;

        public Donar()
        {   
            this.address = "";
            this.city = "";
            this.postCode = 0;
            this.phoneNo = "";
            this.bloodGroup = "";
            this.gender = "";
        }

        public Donar(int id, string bDate, string fName, string lName, string adr, string city, int pCode, string pNo, string bGroup, string gen)
                       
        {
            Id = id;
            BirthDate = bDate;
            FirstName = fName;
            LastName = lName;
            this.address = adr;
            this.city = city;
            this.postCode = pCode;
            this.phoneNo = pNo;
            this.bloodGroup = bGroup;
            this.gender = gen;
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }

        public int PostCode
        {
            get
            {
                return this.postCode;
            }
            set
            { 
                this.postCode = value;
            }
        }

        public string PhoneNo
        {
            get
            {
                return this.phoneNo;
            }
            set
            {
                this.phoneNo = value;
            }
        }
        public string BloodGroup
        {
            get
            {
                return this.bloodGroup;
            }
            set
            {
                this.bloodGroup = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }
    }

    public class Employee : Person
    {
        private string password;

        public Employee()
        {
            this.password = "";
        }

        public Employee(int id, string bDate, string fName, string lName, string pass)
        {
            Id = id;
            BirthDate = bDate;
            FirstName = fName;
            LastName = lName;
            this.password = pass;
        }

        public string Password
        {      
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

    }


}
