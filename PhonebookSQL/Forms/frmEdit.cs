using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
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
        private int id_contact;
        public frmEdit(int id_contact)
        {
            InitializeComponent();
            this.id_contact = id_contact;

            LoadContact();
        }

        private void LoadContact()
        {            
            SqlCeConnection connection = new SqlCeConnection("Data source = " + Geral.database);
            connection.Open();

            SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT * FROM contacts WHERE id_contact = " + id_contact, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);

            connection.Dispose();

            edit_name.Text = data.Rows[0]["name"].ToString();
            edit_number.Text = data.Rows[0]["number"].ToString();           
        }


        private void cmd_save_Click(object sender, EventArgs e)
        {
            #region VERIFICATIONS     


            // Check if there're empty fields
            if (edit_name.Text == "" || edit_number.Text == "")
            {
                MessageBox.Show("Fill in the fields before save.");
                return;
            }

            #endregion

            // Database connection
            SqlCeConnection connection = new SqlCeConnection("Data source = " + Geral.database);
            connection.Open();

            #region EDIT CONTACT

            SqlCeCommand command = new SqlCeCommand();
            command.Connection = connection;

            command.Parameters.AddWithValue("@id_contact", id_contact);
            command.Parameters.AddWithValue("@name", edit_name.Text);
            command.Parameters.AddWithValue("@number", edit_number.Text);
            command.Parameters.AddWithValue("@to_update", DateTime.Now);

            // Avoid duplicate contact

            SqlCeDataAdapter adapter = new SqlCeDataAdapter();
            DataTable data = new DataTable();
            command.CommandText = "SELECT * FROM contacts WHERE number = @number AND id_contact <> @id_contact";
            adapter.SelectCommand = command;
            adapter.Fill(data);

            if (data.Rows.Count != 0)
            {
                if (MessageBox.Show("Already been a contact with this number." + Environment.NewLine +
                                    "Continue and change this contact number?",
                                    "WARNING", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

            }

            command.CommandText = "UPDATE contacts SET " +
                                  "name = @name, " +
                                  "number = @number, " +
                                  "to_update = @to_update " +
                                  "WHERE id_contact = @id_contact";

            command.ExecuteNonQuery();

            #endregion

            this.Close();
        }
    }
}
