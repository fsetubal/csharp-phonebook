namespace Phonebook
{
    partial class frmEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_save = new System.Windows.Forms.Button();
            this.edit_number = new System.Windows.Forms.TextBox();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(5, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cmd_save
            // 
            this.cmd_save.AccessibleName = "";
            this.cmd_save.BackColor = System.Drawing.Color.CadetBlue;
            this.cmd_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd_save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmd_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_save.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_save.ForeColor = System.Drawing.Color.Cornsilk;
            this.cmd_save.Location = new System.Drawing.Point(144, 55);
            this.cmd_save.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(141, 25);
            this.cmd_save.TabIndex = 14;
            this.cmd_save.Text = "Save";
            this.cmd_save.UseVisualStyleBackColor = false;
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // edit_number
            // 
            this.edit_number.BackColor = System.Drawing.Color.Azure;
            this.edit_number.Location = new System.Drawing.Point(82, 31);
            this.edit_number.Margin = new System.Windows.Forms.Padding(2);
            this.edit_number.Name = "edit_number";
            this.edit_number.Size = new System.Drawing.Size(203, 20);
            this.edit_number.TabIndex = 13;
            // 
            // edit_name
            // 
            this.edit_name.BackColor = System.Drawing.Color.Azure;
            this.edit_name.Location = new System.Drawing.Point(82, 9);
            this.edit_name.Margin = new System.Windows.Forms.Padding(2);
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(203, 20);
            this.edit_name.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(314, 99);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmd_save);
            this.Controls.Add(this.edit_number);
            this.Controls.Add(this.edit_name);
            this.Controls.Add(this.label1);
            this.Name = "frmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHONEBOOK - EDIT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_save;
        private System.Windows.Forms.TextBox edit_number;
        private System.Windows.Forms.TextBox edit_name;
        private System.Windows.Forms.Label label1;
    }
}