using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace CustomerApp.Data.Repository
{
    class DbContext
    {

        public int Execute(string cmdText, Dictionary<string, object> parameters)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-V4D0GAH\MSSQLSERVER01;Initial Catalog=demo;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();

            try
            {
                connection.Open();
                cmd.CommandText = cmdText;
                if (parameters != null)
                {
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }
                cmd.Connection = connection;
                int r = cmd.ExecuteNonQuery(); 

                return r;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                cmd.Dispose();
            }
            return 0;
        }
    }
}
