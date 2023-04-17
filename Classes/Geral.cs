using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Phonebook.Classes;
using System.Windows.Forms;

namespace Phonebook
{
    public static class Geral
    {
        public static string version = "v 0.0.1";

        //contact list
        public static List<Contatos> CONTACT_LIST;

        public static void BuildContactList()
        {
            //method to load
            //check if list exists
            string folder_documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string name_list = folder_documents + "\\contact_list.txt";

            CONTACT_LIST = new List<Contatos>();

            if (File.Exists(name_list))
            {
                StreamReader contactlist = new StreamReader(name_list, Encoding.UTF8);
                
                while(!contactlist.EndOfStream)
                {
                    string nameAndNumber = contactlist.ReadLine();

                    string[] parts = nameAndNumber.Split(',');

                    if (parts.Length == 2)
                    {
                        //extract the name and number
                        string name = parts[0].Trim();
                        string number = parts[1].Trim();

                        //adding to the list
                        Contatos new_contact = new Contatos();
                        new_contact.name = name;
                        new_contact.number = number;
                        CONTACT_LIST.Add(new_contact);

                    }
                 
                }
                contactlist.Dispose();
            }
        }
        
        public static void SaveNewRegister(string name, string number)
        {
            //Save in List
            CONTACT_LIST.Add(new Contatos() { name = name, number = number });

            //list refresher
            TheBuilderOrRefresher();
        }

        //build/refresh the txt doc in folder
        public static void TheBuilderOrRefresher()
        {
            string folder_documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string name_list = folder_documents + @"\contact_list.txt";

            StreamWriter contactlist = new StreamWriter(name_list, false, Encoding.UTF8);
            foreach (Contatos contact in CONTACT_LIST)
            {
                contactlist.WriteLine($"{contact.name},{contact.number}");
            }

            contactlist.Dispose();
        }

    }
}
