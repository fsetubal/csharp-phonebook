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
    public partial class frmInsertEdit : Form
    {
        int indice;
        public frmInsertEdit()
        {
            InitializeComponent();
            BuildList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exit insert/edit screen
            this.Close();
        }

        private void fmrInsertEdit_Load(object sender, EventArgs e)
        {

        }

        //build/refresh the list on software
        private void BuildList()
        {
            //add to list registered contacts
            contact_list.Items.Clear();

            foreach(Contatos contact in Geral.CONTACT_LIST)
            {
                contact_list.Items.Add($"{contact.name}     ({contact.number})");
            }

            //count number of contacts added
            contacts_count.Text = contact_list.Items.Count.ToString();

            //disable delete and edit buttons
            cmd_delete.Enabled = false;
            cmd_edit.Enabled = false;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            //check if there're empty fields
            if (text_name.Text == "" || text_number.Text == "")
            {
                MessageBox.Show("Fill in the fields before save.");
                return; 
            }

            //check for duplicate registers
            foreach (Contatos contact in Geral.CONTACT_LIST)
            {
                if (contact.name == text_name.Text && contact.number == text_number.Text)
                {
                    MessageBox.Show("Already in list!");
                    return;
                   
                }
            }


            //save info in list
            Geral.SaveNewRegister(text_name.Text, text_number.Text);

            //refresh list
            BuildList();

            //clear fields
            text_name.Clear();
            text_number.Clear();
            text_name.Focus();

        }

        private void contact_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select contact

            //check if indice = -1
            if (contact_list.SelectedIndex == -1) return;

            //select indice of list
            indice = contact_list.SelectedIndex;
            cmd_edit.Enabled = true;
            cmd_delete.Enabled = true;
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            //delete register
            Geral.CONTACT_LIST.RemoveAt(indice);

            //refresh txt doc
            Geral.TheBuilderOrRefresher();

            //refresh list in software
            BuildList();

        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            Contatos selectedContact = Geral.CONTACT_LIST[indice];
            string name = selectedContact.name;
            string number = selectedContact.number;

            //open edit screen
            frmEdit edit_contact = new frmEdit(indice, name, number);
            edit_contact.ShowDialog();

            if (edit_contact.cancel)
            {
                BuildList();
            }
        }
    }
}
