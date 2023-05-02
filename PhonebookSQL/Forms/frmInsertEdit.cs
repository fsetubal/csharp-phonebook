using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using Phonebook.Classes;

namespace Phonebook
{
    public partial class frmInsertEdit : Form
    {
        int id_contact;
        bool edit;
        public frmInsertEdit(int id_contact = -1)
        {
            InitializeComponent();
            this.id_contact = id_contact;            
        }

        private void fmrInsertEdit_Load(object sender, EventArgs e)
        {
            BuildDataGriedView();
        }

        public int DataGridWidth(int percentage)
        {
            int datagrid_width = grid_results.Width - 20;
            int result = (datagrid_width * percentage) / 100;
            return result;
        }

        public void BuildDataGriedView()
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source = " + Geral.database);
            connection.Open();

            SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT * FROM contacts", connection);
            DataTable date = new DataTable();
            adapter.Fill(date);

            grid_results.DataSource = date;

            contacts_count.Text = "Contacts: " + grid_results.Rows.Count.ToString();

            grid_results.Columns["id_contact"].Visible = false;
            grid_results.Columns["to_update"].Visible = false;

            grid_results.Columns["name"].Width = DataGridWidth(60);
            grid_results.Columns["number"].Width = DataGridWidth(40);

            cmd_delete.Enabled = false;
            cmd_edit.Enabled = false;
        }

        public void SaveNewRegister()
        {
            // Save new contact in database

            #region VERIFICATIONS     


            // Check if there're empty fields
            if (text_name.Text == "" || text_number.Text == "")
            {
                MessageBox.Show("Fill in the fields before save.");
                return;
            }

            #endregion

            // Database connection
            SqlCeConnection connection = new SqlCeConnection("Data source = " + Geral.database);
            connection.Open();

            #region NEW CONTACT
            if (!edit)
            {
                // Locate available primary key
                SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT MAX(id_contact) AS max_id FROM contacts", connection);
                DataTable data = new DataTable();
                adapter.Fill(data);

                // Check if value is null
                if (DBNull.Value.Equals(data.Rows[0][0]))
                {
                    id_contact = 0;
                }
                else
                {
                    id_contact = Convert.ToInt16(data.Rows[0][0]) + 1;
                }

                // Save new contact in database
                SqlCeCommand command = new SqlCeCommand();
                command.Connection = connection;

                command.Parameters.AddWithValue("@id_contact", id_contact);
                command.Parameters.AddWithValue("@name", text_name.Text);
                command.Parameters.AddWithValue("@number", text_number.Text);
                command.Parameters.AddWithValue("@to_update", DateTime.Now);

                // Avoid duplicate contacts
                adapter = new SqlCeDataAdapter();
                data = new DataTable();
                command.CommandText = "SELECT * FROM contacts WHERE number = @number";
                adapter.SelectCommand = command;
                adapter.Fill(data);

                if (data.Rows.Count != 0)
                {
                    if (MessageBox.Show("Already been a contact with this number." + Environment.NewLine + "Continue and change this contact number?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }

                }

                command.CommandText = "INSERT INTO contacts VALUES(" +
                    "@id_contact, @name, @number, @to_update)";

                command.ExecuteNonQuery();
                command.Dispose();
                connection.Dispose();

                MessageBox.Show("Contact successfully added.");

                // Update DataGridView
                BuildDataGriedView();

                text_name.Text = "";
                text_number.Text = "";
                text_name.Focus();

            }
            #endregion
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SaveNewRegister();
        }

        private void grid_results_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_contact = Convert.ToInt16(grid_results.Rows[e.RowIndex].Cells["id_contact"].Value);
            cmd_delete.Enabled = true;
            cmd_edit.Enabled = true;
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            SqlCeConnection connection = new SqlCeConnection("Data source = " + Geral.database);
            connection.Open();

            SqlCeCommand command = new SqlCeCommand("DELETE FROM contacts WHERE id_contact = " + id_contact, connection);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Dispose();

            // Update DataGridView
            BuildDataGriedView();
        }

        private void cmd_edit_Click(object sender, EventArgs e)
        {
            // Open edition form
            frmEdit f = new frmEdit(id_contact);
            f.ShowDialog();

            // Update DataGridView
            BuildDataGriedView();
        }

        private void cmd_exit_Click(object sender, EventArgs e)
        {
            // Exit insert/edit screen
            this.Close();
        }
        
    }
}
