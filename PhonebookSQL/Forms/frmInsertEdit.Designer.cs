namespace Phonebook
{
    partial class frmInsertEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_exit = new System.Windows.Forms.Button();
            this.cmd_delete = new System.Windows.Forms.Button();
            this.cmd_edit = new System.Windows.Forms.Button();
            this.contacts_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_results = new System.Windows.Forms.DataGridView();
            this.cmd_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_results)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // text_name
            // 
            this.text_name.BackColor = System.Drawing.Color.Azure;
            this.text_name.Location = new System.Drawing.Point(115, 12);
            this.text_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_name.MaxLength = 50;
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(376, 22);
            this.text_name.TabIndex = 0;
            // 
            // text_number
            // 
            this.text_number.BackColor = System.Drawing.Color.Azure;
            this.text_number.Location = new System.Drawing.Point(115, 39);
            this.text_number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_number.MaxLength = 15;
            this.text_number.Name = "text_number";
            this.text_number.Size = new System.Drawing.Size(242, 22);
            this.text_number.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cmd_exit
            // 
            this.cmd_exit.AccessibleName = "cmd_exit";
            this.cmd_exit.BackColor = System.Drawing.Color.CadetBlue;
            this.cmd_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd_exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmd_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_exit.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_exit.ForeColor = System.Drawing.Color.Cornsilk;
            this.cmd_exit.Location = new System.Drawing.Point(513, 446);
            this.cmd_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_exit.Name = "cmd_exit";
            this.cmd_exit.Size = new System.Drawing.Size(128, 27);
            this.cmd_exit.TabIndex = 3;
            this.cmd_exit.Text = "Close";
            this.cmd_exit.UseVisualStyleBackColor = false;
            this.cmd_exit.Click += new System.EventHandler(this.cmd_exit_Click);
            // 
            // cmd_delete
            // 
            this.cmd_delete.AccessibleName = "cmd_exit";
            this.cmd_delete.BackColor = System.Drawing.Color.CadetBlue;
            this.cmd_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd_delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmd_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_delete.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_delete.ForeColor = System.Drawing.Color.Cornsilk;
            this.cmd_delete.Location = new System.Drawing.Point(379, 446);
            this.cmd_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(128, 27);
            this.cmd_delete.TabIndex = 4;
            this.cmd_delete.Text = "Delete";
            this.cmd_delete.UseVisualStyleBackColor = false;
            this.cmd_delete.Click += new System.EventHandler(this.cmd_delete_Click);
            // 
            // cmd_edit
            // 
            this.cmd_edit.AccessibleName = "cmd_exit";
            this.cmd_edit.BackColor = System.Drawing.Color.CadetBlue;
            this.cmd_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd_edit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmd_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_edit.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_edit.ForeColor = System.Drawing.Color.Cornsilk;
            this.cmd_edit.Location = new System.Drawing.Point(245, 446);
            this.cmd_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_edit.Name = "cmd_edit";
            this.cmd_edit.Size = new System.Drawing.Size(128, 27);
            this.cmd_edit.TabIndex = 5;
            this.cmd_edit.Text = "Edit";
            this.cmd_edit.UseVisualStyleBackColor = false;
            this.cmd_edit.Click += new System.EventHandler(this.cmd_edit_Click);
            // 
            // contacts_count
            // 
            this.contacts_count.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacts_count.ForeColor = System.Drawing.Color.Cornsilk;
            this.contacts_count.Location = new System.Drawing.Point(112, 399);
            this.contacts_count.Name = "contacts_count";
            this.contacts_count.Size = new System.Drawing.Size(136, 23);
            this.contacts_count.TabIndex = 10;
            this.contacts_count.Text = "contact count";
            this.contacts_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(112, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Registered contacts list:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // grid_results
            // 
            this.grid_results.AllowUserToAddRows = false;
            this.grid_results.AllowUserToDeleteRows = false;
            this.grid_results.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grid_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_results.Location = new System.Drawing.Point(115, 105);
            this.grid_results.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid_results.MultiSelect = false;
            this.grid_results.Name = "grid_results";
            this.grid_results.ReadOnly = true;
            this.grid_results.RowHeadersVisible = false;
            this.grid_results.RowHeadersWidth = 51;
            this.grid_results.RowTemplate.Height = 24;
            this.grid_results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_results.Size = new System.Drawing.Size(533, 292);
            this.grid_results.TabIndex = 12;
            this.grid_results.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_results_CellClick);
            // 
            // cmd_save
            // 
            this.cmd_save.AccessibleName = "cmd_exit";
            this.cmd_save.BackColor = System.Drawing.Color.CadetBlue;
            this.cmd_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd_save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmd_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_save.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_save.ForeColor = System.Drawing.Color.Cornsilk;
            this.cmd_save.Location = new System.Drawing.Point(363, 39);
            this.cmd_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(128, 27);
            this.cmd_save.TabIndex = 13;
            this.cmd_save.Text = "Save";
            this.cmd_save.UseVisualStyleBackColor = false;
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // frmInsertEdit
            // 
            this.AcceptButton = this.cmd_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(684, 501);
            this.Controls.Add(this.cmd_save);
            this.Controls.Add(this.grid_results);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contacts_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_number);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.cmd_edit);
            this.Controls.Add(this.cmd_delete);
            this.Controls.Add(this.cmd_exit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsertEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHONEBOOK - INSERT/EDIT";
            this.Load += new System.EventHandler(this.fmrInsertEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_exit;
        private System.Windows.Forms.Button cmd_delete;
        private System.Windows.Forms.Button cmd_edit;
        private System.Windows.Forms.Label contacts_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grid_results;
        private System.Windows.Forms.Button cmd_save;
    }
}