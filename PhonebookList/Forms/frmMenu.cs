using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            //load contactlist
            Geral.BuildContactList();

            //show program version
            label_version.Text = Geral.version;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //exit button
            if (MessageBox.Show("Are you sure?", "E X I T", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) 
                return;

            Application.Exit();
        }

        private void cmd_insert_Click(object sender, EventArgs e)
        {
            //open insert/edit screen

            frmInsertEdit formulario = new frmInsertEdit();
            formulario.ShowDialog();
        }

        private void cmd_search_Click(object sender, EventArgs e)
        {
            //open search screen
            frmSearch search_tool = new frmSearch();
            search_tool.ShowDialog();

            //close search screen
            if (search_tool.cancel) return;

            //open results list
            frmResults search_results = new frmResults(search_tool.text);
            search_results.ShowDialog();
        }
    }
}
