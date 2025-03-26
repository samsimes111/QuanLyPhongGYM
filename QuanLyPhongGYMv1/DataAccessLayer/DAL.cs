using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DAL
    {
        private string ConnStr = "Data Source=YUUUUUBIN;Initial Catalog=QuanLyPhongGymV1;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand comm;

        public DAL()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }

        public DataTable GetMembershipPackages()
        {
            string query = "SELECT MembershipID, MembershipName FROM MembershipPackages";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void AddCustomer(string fullName, string phoneNumber, DateTime startDate, int? membershipID)
        {
            string query = "INSERT INTO Customers (FullName, PhoneNumber, StartDate, MembershipID) VALUES (@FullName, @PhoneNumber, @StartDate, @MembershipID)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FullName", fullName);
            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@MembershipID", (object)membershipID ?? DBNull.Value);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
