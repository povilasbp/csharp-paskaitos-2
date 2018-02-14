using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _08_01_pirma_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            string conection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Povilas\Desktop\Kaunas Coding School\csharp paskaitos 2\Antra dalis\08_01 pirma uzduotis\KCS.mdf;Integrated Security=True";
            SqlConnection sql = new SqlConnection(conection_string);
            sql.Open();
                Console.WriteLine("Prisijungiau");
                //------------------------------------------------------------------------
                string query1 = "INSERT INTO studentai(name, surname, phone, email) VALUES('Tomas', 'Jonaitis', 862014563, 'tomux69@one.lt')";
                using (SqlCommand com = new SqlCommand(query1, sql))
                {
                    com.Parameters.AddWithValue("@Id", 124);
                    com.Parameters.AddWithValue("@Login_Name", "Kazkas");
                    sql.Open();
                    int rezult = com.ExecuteNonQuery();
                    if (rezult < 0)
                    {
                        Console.WriteLine("Error inserting data into
                        Database!");
}
                }
            //--------------------------------------------------------------
            }
            catch(Exception ex)
            {
                Console.WriteLine("Neprisijungiau");
            }
        }
    }
}
