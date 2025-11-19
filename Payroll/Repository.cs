using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Payroll
{
    public class Repository
    {
        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Choji Kodachi\\Source\\Repos\\Payroll1\\Payroll\\Database\\PayrollDatabase.mdf\";Integrated Security=True";

        public string getAccountantID(string userName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT employeeID FROM accountantData WHERE userName=@userName;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@userName", userName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetString(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Exception: " + ex.ToString());
            }
            return "";
        }

        public bool AuthenticateEmployee(string userName, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT COUNT(*) FROM employeeData WHERE userName COLLATE SQL_Latin1_General_CP1_CS_AS = @userName AND password COLLATE SQL_Latin1_General_CP1_CS_AS = @password;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@password", password);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Exception: " + ex.ToString());
                return false;
            }
        }

        public bool AuthenticateAccountant(string userName, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT COUNT(*) FROM accountantData WHERE userName COLLATE SQL_Latin1_General_CP1_CS_AS = @userName AND password COLLATE SQL_Latin1_General_CP1_CS_AS = @password;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@password", password);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Exception: " + ex.ToString());
                return false;
            }
        }

        public string AuthenticateUser(string userName, string password)
        {
            if (AuthenticateEmployee(userName, password))
            {
                return "employee";
            }
            if (AuthenticateAccountant(userName, password))
            {
                return "accountant";
            }
            return null;
        }
    }
}