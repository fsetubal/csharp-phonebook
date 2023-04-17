using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phonebook.Classes;

namespace Phonebook
{
    public partial class frmResults : Form
    {
        string text;
        public frmResults(string text)
        {
            InitializeComponent();

            //define search text
            this.text = text.ToUpper();
        }

        //execute search and build the list with results
        public void ExecuteSearchAndBuildList()
        {
            List<Contatos> search_result_list = new List<Contatos>();

            foreach (Contatos contact in Geral.CONTACT_LIST)
            {
                if (contact.name.ToUpper().Contains(text) ||
                    contact.number.ToUpper().Contains(text))
                {
                    search_result_list.Add(contact);
                }
                else
                {
                    MessageBox.Show("Not in the list. Try new search or close.");
                }

            }

            //show results in list
            results_list.Items.Clear();

            foreach (Contatos contact in search_result_list)
            {
                results_list.Items.Add($"{contact.name}     {contact.number}");
            }

            contacts_count.Text = results_list.Items.Count.ToString();
        }

        private void frmResults_Load(object sender, EventArgs e)
        {            
            ExecuteSearchAndBuildList();
        }

        private void cmd_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_newSearch_Click(object sender, EventArgs e)
        {
            //open search screen
            frmSearch search_tool = new frmSearch();
            search_tool.ShowDialog();

            //close search screen
            if (search_tool.cancel) return;

            text = search_tool.text.ToUpper();
            ExecuteSearchAndBuildList();
        }
    }
}
