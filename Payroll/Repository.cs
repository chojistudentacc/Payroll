using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Payroll.Models;

namespace Payroll
{
    public class Repository
    {

        private readonly string connectionString =
        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Choji Kodachi\source\repos\Payroll\Payroll\Payroll.mdf"";Integrated Security=True";

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

        public string getAdminID(string userName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT adminID FROM adminData WHERE userName=@userName;";
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

        public bool IsAdminDataEmpty()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT COUNT(*) FROM adminData;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        int count = (int)command.ExecuteScalar();
                        return count == 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Exception: " + ex.ToString());
                return false;
            }
        }

        public string GetNextAdminID()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT adminID FROM adminData WHERE adminID LIKE 'ADMN-%';";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int maxNumber = 0;
                            while (reader.Read())
                            {
                                string adminID = reader.GetString(0);
                                if (adminID.StartsWith("ADMN-"))
                                {
                                    string numberPart = adminID.Substring(5);
                                    if (int.TryParse(numberPart, out int number))
                                    {
                                        if (number > maxNumber)
                                        {
                                            maxNumber = number;
                                        }
                                    }
                                }
                            }
                            return "ADMN-" + (maxNumber + 1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Exception: " + ex.ToString());
                return null;
            }
        }

        public string GetNextEmployeeID()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"SELECT ISNULL(MAX(CAST(SUBSTRING(employeeID, 5, LEN(employeeID)) AS INT)), 0) 
                           FROM employeeData 
                           WHERE employeeID LIKE 'EMP-%';";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        int maxNumber = (int)command.ExecuteScalar();
                        int nextNumber = maxNumber + 1;
                        return "EMP-" + nextNumber;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Exception: " + ex.ToString());
                return null;
            }
        }

        public string GetNextAccountantID()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"SELECT ISNULL(MAX(CAST(SUBSTRING(employeeID, 5, LEN(employeeID)) AS INT)), 0) 
                           FROM accountantData 
                           WHERE employeeID LIKE 'ACC-%';";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        int maxNumber = (int)command.ExecuteScalar();
                        int nextNumber = maxNumber + 1;
                        return "ACC-" + nextNumber;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Exception: " + ex.ToString());
                return null;
            }
        }


        public DataTable GetAllEmployee()
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"
                    SELECT 
                    employeeID,
                    email,
                    contactNum,
                    address,
                    lastName,
                    firstName,
                    middleName,
                    status
                    FROM employeeData;
                    ";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Exception: " + ex.ToString());
            }

            return table;
        }


        public DataTable GetAllAccountant()
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"
                    SELECT 
                    employeeID,
                    email,
                    contactNum,
                    address,
                    lastName,
                    firstName,
                    middleName,
                    status
                    FROM accountantData;
                    ";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Exception: " + ex.ToString());
            }

            return table;
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

        public bool AuthenticateAdmin(string userName, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT COUNT(*) FROM adminData WHERE userName COLLATE SQL_Latin1_General_CP1_CS_AS = @userName AND password COLLATE SQL_Latin1_General_CP1_CS_AS = @password;";
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
            if (AuthenticateAdmin(userName, password))
            {
                return "admin";
            }
            return null;
        }

        public bool AddEmployee(Employee emp)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"INSERT INTO employeeData (userName, password, employeeID, email, contactNum, address, lastName, firstName, middleName, status) VALUES (@userName, @password, @employeeID, @email, @contactNum, @address, @lastName, @firstName, @middleName, @status);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@userName", emp.UserName);
                        command.Parameters.AddWithValue("@password", emp.Password);
                        command.Parameters.AddWithValue("@employeeID", GetNextEmployeeID());
                        command.Parameters.AddWithValue("@email", emp.Email);
                        command.Parameters.AddWithValue("@contactNum", emp.ContactNum);
                        command.Parameters.AddWithValue("@address", emp.Address);
                        command.Parameters.AddWithValue("@lastName", emp.LastName);
                        command.Parameters.AddWithValue("@firstName", emp.FirstName);
                        command.Parameters.AddWithValue("@middleName", emp.MiddleName);
                        command.Parameters.AddWithValue("@status", emp.Status);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.ToString());
                return false;
            }
        }

        public bool AddAccountant(Accountant acc)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"INSERT INTO accountantData (userName, password, employeeID, email, contactNum, address, lastName, firstName, middleName, status) VALUES (@userName, @password, @employeeID, @email, @contactNum, @address, @lastName, @firstName, @middleName, @status);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@userName", acc.UserName);
                        command.Parameters.AddWithValue("@password", acc.Password);
                        command.Parameters.AddWithValue("@employeeID", GetNextAccountantID());
                        command.Parameters.AddWithValue("@email", acc.Email);
                        command.Parameters.AddWithValue("@contactNum", acc.ContactNum);
                        command.Parameters.AddWithValue("@address", acc.Address);
                        command.Parameters.AddWithValue("@lastName", acc.LastName);
                        command.Parameters.AddWithValue("@firstName", acc.FirstName);
                        command.Parameters.AddWithValue("@middleName", acc.MiddleName);
                        command.Parameters.AddWithValue("@status", acc.Status);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding accountant: " + ex.ToString());
                return false;
            }
        }


    }
}