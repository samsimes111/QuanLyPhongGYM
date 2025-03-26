using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class DBGYM
    {
        public DAL db = new DAL();

        public DataTable GetMembershipPackages()
        {
            return db.GetMembershipPackages();
        }

        public void AddCustomer(string fullName, string phoneNumber, DateTime startDate, int? membershipID)
        {
            db.AddCustomer(fullName, phoneNumber, startDate, membershipID);
        }


    }
}
