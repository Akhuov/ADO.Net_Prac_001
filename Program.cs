using System.Configuration;
using ADO.Net.Models;
using ADO.Net.Services;
//using System.Data.SqlClient;

var strOfCon = ConfigurationManager.ConnectionStrings["config_01"].ConnectionString;//Connection String
//using (SqlConnection connect = new SqlConnection(strOfCon))
//{
//    try
//    {
//        connect.Open();
//        Console.WriteLine(strOfCon);
//        Console.WriteLine("\n\n");

//        string query = "Select * from Fruits";

//        SqlCommand cmd = new SqlCommand(query, connect);

//        using (SqlDataReader reader = cmd.ExecuteReader())
//        {
//            int c = 0;

//            while (reader.Read())
//            {
//                c = reader.FieldCount;
//                for (int i = 0; i < c; i++)
//                {
//                    Console.Write(reader[i] + "\t");
//                }

//                Console.WriteLine();

//            }

//            Console.WriteLine("\n\n" + c);
//        }
//    }
//    catch (Exception exeption)
//    {
//        Console.WriteLine(exeption.Message);
//    }
//}


//using ADO.Net.Services;
//using System.Configuration;

//var strOfCon = ConfigurationManager.ConnectionStrings["config_01"].ConnectionString;//Connection String
//Console.WriteLine(strOfCon+"\n\n");


//Console.WriteLine($"TableName: SqlConnection");
//var create_table_dto = Console.ReadLine().Split();
//try
//{
//    DataBase.CreateTable(create_table_dto[0], strOfCon);
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//string[] words = { "Gaudeamus", "igitur", "Juvenes", "dum", "sumus" };
//var sentence = words.Aggregate("Text:", (first, next) => $"{first} {next}");

//Console.WriteLine(sentence);\



//Console.WriteLine("Select (1)\twhere by  ??  value ");

//List<string> By = Console.ReadLine().Split(" ").ToList();

//string tableName = "Fruits";
//string dataBase = "BootCamp_N7";
//DataBase.GetBy(tableName, dataBase, By);

//var list = new List<Fruits>()
//{
//    new Fruits{id = 6,Name = "AAA",Count = 23,Price = 1000},
//    new Fruits{id = 7,Name = "BBB",Count = 33,Price = 3000},
//    new Fruits{id = 8,Name = "CCC",Count = 15,Price = 5000},
//    new Fruits{id = 9,Name = "DDD",Count = 2,Price = 2000},
//    new Fruits{id = 10,Name = "RRR",Count = 52,Price = 32000},
//    new Fruits{id = 11,Name = "SSS",Count = 9,Price = 123000},
//};

//DataBase.AddRows(tableName, dataBase, list);

