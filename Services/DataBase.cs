using ADO.Net.Models;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace ADO.Net.Services;

internal class DataBase
{
    public static void CreateTable(string tableName, string connectionString)
    {
        using (var connect = new SqlConnection())
        {
            try
            {
                connect.ConnectionString = connectionString;
                connect.Open();

                string query = $@"create table {tableName} (Id int not null,
                                                            Name varchar(30),
                                                            Age int not null)";

                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Table Created");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }


    public static void GetBy(string tableName, string Database, List<string> by)
    {
        using (var connect = new SqlConnection())
        {
            try
            {
                connect.ConnectionString = $"Server=WIN-F7NIMF7A3VO;Database={Database};Trusted_Connection=True;Pooling = True;";
                connect.Open();
                int n;
                char? tirnoq = int.TryParse(by[3], out n) ? null : '\'';



                string query = $"select {by[0]} From {tableName} where {tableName + "." + by[1] + by[2]} {tirnoq}{by[3]}{tirnoq}";

                SqlCommand cmd = new SqlCommand(query, connect);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader[i] + "\t\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }



    public static void AddRows(string tableName, string Database, List<Fruits> listOfFruits)
    {

        using (var connect = new SqlConnection())
        {
            connect.ConnectionString = $"Server=WIN-F7NIMF7A3VO;Database={Database};Trusted_Connection=True;Pooling = True;";
            connect.Open();
            string insertQuery = "";

            for (int i = 0; i < listOfFruits.Count; i++)
            {
                if (i == 0)
                {
                    insertQuery += @$"Insert into {tableName}(Name,Count,Price)
                                    Values('{listOfFruits[i].Name}'
                                        ,{listOfFruits[i].Count}
                                        ,{listOfFruits[i].Price})";
                }
                else
                {
                    insertQuery += @$",('{listOfFruits[i].Name}'
                                        ,{listOfFruits[i].Count}
                                        ,{listOfFruits[i].Price})";
                }
                if (i == listOfFruits.Count - 1)
                {
                    insertQuery += ";";
                }
            }

            SqlCommand cmd = new SqlCommand(insertQuery, connect);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Rows Added");
        }
    }

    public static void DeleteById(int id, string strOfCon)
    {
        using (var connect = new SqlConnection()) {
            try
            {
                connect.Open();
                Console.WriteLine(strOfCon);
                Console.WriteLine("\n\n");

                string query = $"Delete from Fruits where Fruits.Id = {id}";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
            }
            catch (Exception exeption)
            {
                Console.WriteLine(exeption.Message);
            }
        }
    }
}
