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
using Phonebook.Classes;

namespace Phonebook
{
    public partial class frmResults : Form
    {
        string text;
        public frmResults(string text)
        {
            InitializeComponent();
            this.text = text;
        }

        public int DataGridWidth(int percentage)
        {
            int datagrid_width = grid_search_results.Width - 20;
            int result = (datagrid_width * percentage) / 100;
            return result;
        }

        private void BuildSearchDataGrid()
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source = " + Geral.database);
            connection.Open();

            SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT * FROM contacts WHERE name LIKE" +
                                                            " '%" + text + "%' OR number LIKE '%" + text + "%'", connection);
            DataTable date = new DataTable();
            adapter.Fill(date);

            grid_search_results.DataSource = date;

            contacts_search_count.Text = "Contacts: " + grid_search_results.Rows.Count.ToString();

            grid_search_results.Columns["id_contact"].Visible = false;
            grid_search_results.Columns["to_update"].Visible = false;

            grid_search_results.Columns["name"].Width = DataGridWidth(60);
            grid_search_results.Columns["number"].Width = DataGridWidth(40);

            connection.Dispose();
        }

        private void frmResults_Load(object sender, EventArgs e)
        {
            BuildSearchDataGrid();
        }

        private void cmd_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_newSearch_Click(object sender, EventArgs e)
        {
            // Open search screen
            frmSearch search_tool = new frmSearch();
            search_tool.ShowDialog();

            // Close search screen
            if (search_tool.cancel) return;

            text = search_tool.textSearch;
            BuildSearchDataGrid();
        }

    }
}
