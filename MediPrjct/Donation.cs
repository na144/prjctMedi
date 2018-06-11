using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPrjct
{
    public class Donation
    {
        private int donationID;
        private int employeeID;
        private int donarID;
        private DateTime dt;

        public Donation()
        {
            this.donationID = 0;
            this.employeeID = 0;
            this.donarID = 0;
            //this.dt = 0;

        }

        public Donation(int donatID, int empID, int donarID, DateTime d)
        {
            this.donationID = donatID;
            this.employeeID = empID;
            this.donarID = donarID;
            this.dt = d;
        }

        public int DonationID
        {
            get
            {
                return this.donationID;
            }
            set
            {
                this.donationID = value;
            }
        }

        public int EmployeeID
        {
            get
            {
                return this.employeeID;
            }
            set
            {
                this.employeeID  = value;
            }
        }

        public int DonarID
        {
            get
            {
                return this.donarID;
            }
            set
            {
                this.donarID = value;
            }
        }

        public DateTime Dt
        {
            get
            {
                return this.dt;
            }
            set
            {
                this.dt = value;
            }
        }
    }
}
