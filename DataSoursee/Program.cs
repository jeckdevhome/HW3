using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataSoursee
{
    class Program
    {
        static void Main(string[] args)
        {
            string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\source\repos\HomeWork\DataSoursee\AotoReteil.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(sqlcon);
            string query = "SELECT * FROM CARS";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int category = (int)reader[0];
                string brand = reader[1].ToString();
                string model = reader[2].ToString();
                Console.WriteLine("in db: {0}, {1}, {2}", category, brand, model);
            }
            sqlConnection.Close();

            string query2 = "insert into cars values('Susuki', '4x4', 'Parketnik', 1.9, 'Old', 'Patrol')";
            using (SqlCommand command1 = new SqlCommand(query2, sqlConnection))
            {
                sqlConnection.Open();
                command1.ExecuteNonQuery();
            }
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                int category = (int)reader[0];
                string brand = reader[1].ToString();
                string model = reader[2].ToString();

                Console.WriteLine("in db: {0}, {1}, {2}", category, brand, model);
            }
            sqlConnection.Close();
            Console.ReadLine();
        }
    }
}
