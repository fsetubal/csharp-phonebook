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
            this.grid_search_results = new System.Windows.Forms.DataGridView();
            this.contacts_search_count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_search_results)).BeginInit();
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
            this.cmd_newSearch.Location = new System.Drawing.Point(284, 256);
            this.cmd_newSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_newSearch.Name = "cmd_newSearch";
            this.cmd_newSearch.Size = new System.Drawing.Size(128, 27);
            this.cmd_newSearch.TabIndex = 6;
            this.cmd_newSearch.Text = "New search";
            this.cmd_newSearch.UseVisualStyleBackColor = false;
            this.cmd_newSearch.Click += new System.EventHandler(this.cmd_newSearch_Click);
            // 
            // grid_search_results
            // 
            this.grid_search_results.AllowUserToAddRows = false;
            this.grid_search_results.AllowUserToDeleteRows = false;
            this.grid_search_results.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grid_search_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_search_results.Location = new System.Drawing.Point(12, 11);
            this.grid_search_results.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid_search_results.MultiSelect = false;
            this.grid_search_results.Name = "grid_search_results";
            this.grid_search_results.ReadOnly = true;
            this.grid_search_results.RowHeadersVisible = false;
            this.grid_search_results.RowHeadersWidth = 51;
            this.grid_search_results.RowTemplate.Height = 24;
            this.grid_search_results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_search_results.Size = new System.Drawing.Size(400, 227);
            this.grid_search_results.TabIndex = 13;
            // 
            // contacts_search_count
            // 
            this.contacts_search_count.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacts_search_count.ForeColor = System.Drawing.Color.Cornsilk;
            this.contacts_search_count.Location = new System.Drawing.Point(12, 240);
            this.contacts_search_count.Name = "contacts_search_count";
            this.contacts_search_count.Size = new System.Drawing.Size(137, 23);
            this.contacts_search_count.TabIndex = 12;
            this.contacts_search_count.Text = "contacts count";
            this.contacts_search_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(428, 294);
            this.Controls.Add(this.grid_search_results);
            this.Controls.Add(this.contacts_search_count);
            this.Controls.Add(this.cmd_newSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHONEBOOK - RESULTS";
            this.Load += new System.EventHandler(this.frmResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_search_results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_newSearch;
        private System.Windows.Forms.DataGridView grid_search_results;
        private System.Windows.Forms.Label contacts_search_count;
    }
}