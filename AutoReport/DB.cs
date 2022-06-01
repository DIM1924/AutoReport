using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoReport
{
    class DB
    {
        static SqliteConnection connection;
        static SqliteCommand command;
        static public bool Connect(string fileName)
        {
            try
            {
                connection = new SqliteConnection("Data Source=" + fileName + ";Version=3; FailIfMissing=False");
                connection.Open();
                return true;
            }
            catch (SqliteException ex)
            {
                Console.WriteLine($"Ошибка доступа к базе данных. Исключение: {ex.Message}");
                return false;
            }
        }
        public static void CheckConnect()
        {
            if (Connect("firstBase.sqlite"))
            {
                Console.WriteLine("Connected");
            }
           // command.CommandText = 
                
        }
    }
}

