using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Phonebook.Classes;

namespace Phonebook
{
    
    public partial class frmEdit : Form
    {
        private int indice;
        public bool cancel { get; set; }
        public frmEdit(int indice, string name, string number)
        {
            InitializeComponent();
            this.indice = indice;
            this.edit_name.Text = name;
            this.edit_number.Text = number;
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            //error message if any field is empty
            if (edit_name.Text == "" || edit_number.Text == "")
            {
                MessageBox.Show("Fill the fields to continue");
                return;
            }

            // Use indice to match contact in Geral.CONTACT_LIST
            Contatos selectedContact = Geral.CONTACT_LIST[indice];

            // Editing contact by text boxes
            selectedContact.name = edit_name.Text;
            selectedContact.number = edit_number.Text;

            // Refresh txt doc
            Geral.TheBuilderOrRefresher();

            // Get back to Insert/Edit screen
            cancel = true;
            this.Close();



        }
    }
}
