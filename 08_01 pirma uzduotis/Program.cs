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
            string conection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Povilas\Desktop\Kaunas Coding School\csharp paskaitos 2\Antra dalis\08_01 pirma uzduotis\KCS.mdf;Integrated Security=True";
            SqlConnection sql = new SqlConnection(conection_string);
            try
            {
                sql.Open();
                Console.WriteLine("Prisijungiau");
                //------------------------------------------------------------------------

                //--------------------------------------------------------------
            }
            catch (Exception ex)
            {
                Console.WriteLine("Neprisijungiau");
            }
            sql.Close();
            //string query_add = "INSERT INTO studentai(name, surname, phone, email) VALUES(@Name,@surname,@phone,@email)";
            //using (SqlCommand cmd = new SqlCommand(query_add, sql))
            //{
            //    List<string> varduSar = new List<string>() { "Povilas", "Linas", "Rokas", "Mindaugas", "Rokas", "Kazys" };
            //    List<string> pavardziuSar = new List<string>() { "Jonaitis", "Petraitis", "Povilaitis", "Mindaugautis", "Kubilius", "Adamkus", "Trampas" };

            //Random rng = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //int vardoIndex = rng.Next(varduSar.Count);
            //int pavardesIndex = rng.Next(pavardziuSar.Count);
            //cmd.Parameters.AddWithValue("@Name", varduSar[vardoIndex]);
            //cmd.Parameters.AddWithValue("@surname", pavardziuSar[pavardesIndex]);
            //cmd.Parameters.AddWithValue("@phone", 86000000);
            //cmd.Parameters.AddWithValue("@email", ((varduSar[vardoIndex]).ToString()+"@gmail.com"));
            //sql.Open();
            //cmd.ExecuteNonQuery();
            //sql.Close();
            //}
            //}

            // 1.4 uzduotis
            //string query_add_address = "INSERT INTO student_adress(student_id, country, city, street, post_code) VALUES(@student_id, @country, @city, @street, @post_code)";

            //int kiek_studentu_ivesti;
            //int id;
            //string salis;
            //string miestas;
            //string gatve;
            //int pasto_kodas;

            //Console.WriteLine("Kiek studentu adresu norite prideti?");
            //Console.Write("Iveskite: ");
            //kiek_studentu_ivesti = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < kiek_studentu_ivesti; i++)
            //{
            //    using (SqlCommand cmd1 = new SqlCommand(query_add_address, sql))
            //    {
            //        Console.Write("Iveskite studento id: ");
            //        id = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("Iveskite sali: ");
            //        salis = Console.ReadLine();
            //        Console.Write("Iveskite miesta: ");
            //        miestas = Console.ReadLine();
            //        Console.Write("Iveskite gatve: ");
            //        gatve = Console.ReadLine();
            //        Console.Write("Iveskite pasto koda: ");
            //        pasto_kodas = Convert.ToInt32(Console.ReadLine());
            //        cmd1.Parameters.AddWithValue("@student_id", id);
            //        cmd1.Parameters.AddWithValue("@country", salis);
            //        cmd1.Parameters.AddWithValue("@city", miestas);
            //        cmd1.Parameters.AddWithValue("@street", gatve);
            //        cmd1.Parameters.AddWithValue("@post_code", pasto_kodas);
            //        sql.Open();
            //        cmd1.ExecuteNonQuery();
            //        sql.Close();
            //        Console.WriteLine("Pridejau duomenis");
            //    }
            //}

            // 1.6 uzduotis

            //string querry_sort = @"SELECT * FROM studentai ORDER BY Name ASC";
            //using (SqlCommand cmd2 = new SqlCommand(querry_sort, sql))
            //{
            //    sql.Open();
            //    SqlDataReader reader = cmd2.ExecuteReader();
            //    while(reader.Read())
            //    {
            //        Console.WriteLine("{0,-10}{1,-10}",reader["Name"].ToString(), reader["surname"].ToString());
            //    }
            //    sql.Close();
            //}


            // 1.7 uzduotis

            //string querry_sort_as = @"SELECT * FROM studentai WHERE (Name LIKE '%as' AND surname LIKE '%as') ORDER BY Name ASC";
            //using (SqlCommand cmd3 = new SqlCommand(querry_sort_as, sql))
            //{
            //    sql.Open();
            //    SqlDataReader reader1 = cmd3.ExecuteReader();
            //    while (reader1.Read())
            //    {
            //        Console.WriteLine("{0,-10}{1,-10}", reader1["Name"].ToString(), reader1["surname"].ToString());
            //    }
            //    sql.Close();
            //}

            // 1.8 uzduotis

            //string querry_kur_gyvena_kaune = @"SELECT * FROM student_adress WHERE city = 'Kaunas'";
            //using (SqlCommand cmd4 = new SqlCommand(querry_kur_gyvena_kaune, sql))
            //{
            //    sql.Open();
            //    SqlDataReader reader2 = cmd4.ExecuteReader();
            //    while(reader2.Read())
            //    {
            //        Console.WriteLine(reader2["city"].ToString() + " " + reader2["street"].ToString() + " " + reader2["post_code"].ToString());
            //    }
            //    sql.Close();
            //}

            // 1.9 uzduotis

            //string querry_postcode_ne_null = @"SELECT * FROM student_adress WHERE post_code != ''";
            //using (SqlCommand cmd5 = new SqlCommand(querry_postcode_ne_null, sql))
            //{
            //    sql.Open();
            //    SqlDataReader reader3 = cmd5.ExecuteReader();
            //    while(reader3.Read())
            //    {
            //        Console.WriteLine(reader3["student_id"].ToString() + " " + reader3["post_code"].ToString());
            //    }
            //    sql.Close();
            //}

            // 1.11 uzduotis

            //string querry_kiek_10 = @"SELECT COUNT(mark) FROM student_marks WHERE(mark = 10)";
            //using (SqlCommand cmd6 = new SqlCommand(querry_kiek_10, sql))
            //{
            //    sql.Open();
            //    SqlDataReader reader4 = cmd6.ExecuteReader();
            //    while(reader4.Read())
            //    {
            //        Console.WriteLine(reader4[0].ToString());
            //    }
            //    sql.Close();
            //}

            // 1.12 uzduotis

            //string querry_pazymiai_didesni_nei6 = @"SELECT * FROM student_marks WHERE(mark > 6)";
            //using (SqlCommand cmd7 = new SqlCommand(querry_pazymiai_didesni_nei6, sql))
            //{
            //    sql.Open();
            //    SqlDataReader reader5 = cmd7.ExecuteReader();
            //    while(reader5.Read())
            //    {
            //        Console.WriteLine(reader5["mark"].ToString() + " " + reader5["title"].ToString());
            //    }
            //    sql.Close();
            //}

            // 1.13 uzduotis

            //string querry_update_miesta = @"UPDATE student_adress SET street = 'Kaunas' WHERE city in ('Vilnius','Kaunas')";
            //using (SqlCommand cmd8 = new SqlCommand(querry_update_miesta, sql))
            //{
            //    sql.Open();
            //    SqlDataReader reader6 = cmd8.ExecuteReader();
            //    while(reader6.Read())
            //    {
            //        Console.WriteLine(reader6["city"].ToString() + " " + reader6["street"].ToString());
            //    }
            //    sql.Close();
            //}

            // 1.14 uzduotis

            string querry_left_join = @"SELECT * FROM studentai LEFT JOIN student_adress on student_adress.student_id";
            using (SqlCommand cmd9 = new SqlCommand(querry_left_join, sql))
            {
                sql.Open();
                SqlDataReader reader7 = cmd9.ExecuteReader();
                while(reader7.Read())
                {
                    Console.WriteLine(reader7["city"].ToString() + " " + reader7["street"].ToString());
                }
                sql.Close();
            }
        }
    }
}




//string query1 = "INSERT INTO studentai(name, surname, phone, email) VALUES('Tomuuukas', 'Jonaitis', 862014563, 'tomux69@one.lt')";
//                using (SqlCommand com = new SqlCommand(query1, sql))
//                {
//                    com.Parameters.AddWithValue("@Id", 124);
//                    com.Parameters.AddWithValue("@Login_Name", "Kazkas");
//                    //sql.Open();
//                    int rezult = com.ExecuteNonQuery();
//                    if (rezult< 0)
//                    {
//                        Console.WriteLine("Error inserting data into Database!");
//                    }
//                }