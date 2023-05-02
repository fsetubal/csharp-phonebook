namespace Phonebook
{
    partial class frmResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_newSearch = new System.Windows.Forms.Button();
            this.cmd_close = new System.Windows.Forms.Button();
            this.contacts_count = new System.Windows.Forms.Label();
            this.contacts_count_label = new System.Windows.Forms.Label();
            this.results_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmd_newSearch
            // 
            this.cmd_newSearch.AccessibleName = "cmd_exit";
            this.cmd_newSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.cmd_newSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd_newSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmd_newSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_newSearch.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_newSearch.ForeColor = System.Drawing.Color.Cornsilk;
            this.cmd_newSearch.Location = new System.Drawing.Point(234, 99);
            this.cmd_newSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_newSearch.Name = "cmd_newSearch";
            this.cmd_newSearch.Size = new System.Drawing.Size(96, 22);
            this.cmd_newSearch.TabIndex = 6;
            this.cmd_newSearch.Text = "New search";
            this.cmd_newSearch.UseVisualStyleBackColor = false;
            this.cmd_newSearch.Click += new System.EventHandler(this.cmd_newSearch_Click);
            // 
            // cmd_close
            // 
            this.cmd_close.AccessibleName = "cmd_exit";
            this.cmd_close.BackColor = System.Drawing.Color.CadetBlue;
            this.cmd_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_close.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_close.ForeColor = System.Drawing.Color.Cornsilk;
            this.cmd_close.Location = new System.Drawing.Point(134, 99);
            this.cmd_close.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_close.Name = "cmd_close";
            this.cmd_close.Size = new System.Drawing.Size(96, 22);
            this.cmd_close.TabIndex = 7;
            this.cmd_close.Text = "Close";
            this.cmd_close.UseVisualStyleBackColor = false;
            this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
            // 
            // contacts_count
            // 
            this.contacts_count.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacts_count.ForeColor = System.Drawing.Color.Cornsilk;
            this.contacts_count.Location = new System.Drawing.Point(72, 97);
            this.contacts_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contacts_count.Name = "contacts_count";
            this.contacts_count.Size = new System.Drawing.Size(28, 19);
            this.contacts_count.TabIndex = 12;
            this.contacts_count.Text = "0";
            this.contacts_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contacts_count_label
            // 
            this.contacts_count_label.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacts_count_label.ForeColor = System.Drawing.Color.Cornsilk;
            this.contacts_count_label.Location = new System.Drawing.Point(11, 97);
            this.contacts_count_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contacts_count_label.Name = "contacts_count_label";
            this.contacts_count_label.Size = new System.Drawing.Size(57, 19);
            this.contacts_count_label.TabIndex = 11;
            this.contacts_count_label.Text = "Contacts:";
            this.contacts_count_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // results_list
            // 
            this.results_list.FormattingEnabled = true;
            this.results_list.Location = new System.Drawing.Point(12, 12);
            this.results_list.Name = "results_list";
            this.results_list.Size = new System.Drawing.Size(318, 82);
            this.results_list.TabIndex = 13;
            // 
            // frmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(344, 134);
            this.Controls.Add(this.results_list);
            this.Controls.Add(this.contacts_count);
            this.Controls.Add(this.contacts_count_label);
            this.Controls.Add(this.cmd_close);
            this.Controls.Add(this.cmd_newSearch);
            this.MinimizeBox = false;
            this.Name = "frmResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHONEBOOK - RESULTS";
            this.Load += new System.EventHandler(this.frmResults_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_newSearch;
        private System.Windows.Forms.Button cmd_close;
        private System.Windows.Forms.Label contacts_count;
        private System.Windows.Forms.Label contacts_count_label;
        private System.Windows.Forms.ListBox results_list;
    }
}