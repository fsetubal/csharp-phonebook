using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Phonebook.Classes;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Data;

namespace Phonebook
{
    public static class Geral
    {
        public static string version = "v 0.0.2";
        public static string data_folder;
        public static string database;


        public static void BuildPhonebookDatabase()
        {
            // Build Database folder/file
            string folder_documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string data_folder = folder_documents + @"\PhonebookSQL\";

            if (!Directory.Exists(data_folder))
            {
                Directory.CreateDirectory(data_folder);
            }

            database = data_folder + "database_phonebook.sdf";

            if (!File.Exists(database))
            {
                BuildDatabase();
            }
        }

        public static void BuildDatabase()
        {
            // Build database
            SqlCeEngine engine = new SqlCeEngine("Data source = " + database);
            engine.CreateDatabase();
            engine.Dispose();


            // Build database structure
            SqlCeConnection connection = new SqlCeConnection();
            connection.ConnectionString = "Data source = " + database;
            connection.Open();

            SqlCeCommand command = new SqlCeCommand();
            command.CommandText =
                "CREATE TABLE contacts(" +
                "id_contact             int not null primary key, " +
                "name                   nvarchar(50), " +
                "number                 nvarchar(15), " +
                "to_update              datetime)";
            command.Connection = connection;
            command.ExecuteNonQuery();

            connection.Dispose();
            command.Dispose();

        }

              
        

    }
}