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
        //control propertie

        public bool cancel {  get; set; }
        public string text { get; set; }
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
            //search info/close window
            if (text_search.Text == "") return;
            text = text_search.Text;
            cancel = false;
            this.Close();

        }
    }
}
