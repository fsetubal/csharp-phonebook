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
    public partial class frmSearch : Form
    {
        
        public bool cancel {  get; set; }
        public string textSearch { get; set; }
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {

        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

        private void cmd_search_Click(object sender, EventArgs e)
        {
            
            if (text_search.Text == "")
            {
                MessageBox.Show("Need some info to search.");
                return;
            }
            else
            {
                textSearch = text_search.Text;
            }

            this.Close();

        }
    }
}
