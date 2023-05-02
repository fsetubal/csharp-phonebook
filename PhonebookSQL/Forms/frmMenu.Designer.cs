namespace Phonebook
{
    partial class frmMenu
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
            this.cmd_insert = new System.Windows.Forms.Button();
            this.cmd_search = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(-1, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "UNISANTOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmd_insert
            // 
            this.cmd_insert.AccessibleName = "";
            this.cmd_insert.BackColor = System.Drawing.Color.CadetBlue;
            this.cmd_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd_insert.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_insert.Location = new System.Drawing.Point(71, 144);
            this.cmd_insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_insert.Name = "cmd_insert";
            this.cmd_insert.Size = new System.Drawing.Size(183, 32);
            this.cmd_insert.TabIndex = 3;
            this.cmd_insert.Text = "INSERT/EDIT";
            this.cmd_insert.UseVisualStyleBackColor = false;
            this.cmd_insert.Click += new System.EventHandler(this.cmd_insert_Click);
            // 
            // cmd_search
            // 
            this.cmd_search.AccessibleName = "";
            this.cmd_search.BackColor = System.Drawing.Color.CadetBlue;
            this.cmd_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmd_search.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_search.Location = new System.Drawing.Point(71, 182);
            this.cmd_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmd_search.Name = "cmd_search";
            this.cmd_search.Size = new System.Drawing.Size(183, 32);
            this.cmd_search.TabIndex = 4;
            this.cmd_search.Text = "SEARCH";
            this.cmd_search.UseVisualStyleBackColor = false;
            this.cmd_search.Click += new System.EventHandler(this.cmd_search_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "cmd_exit";
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(71, 220);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_version
            // 
            this.label_version.BackColor = System.Drawing.Color.Transparent;
            this.label_version.Font = new System.Drawing.Font("Javanese Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_version.Location = new System.Drawing.Point(71, 267);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(183, 32);
            this.label_version.TabIndex = 6;
            this.label_version.Text = "Program version";
            this.label_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(325, 362);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmd_search);
            this.Controls.Add(this.cmd_insert);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHONEBOOK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmd_insert;
        private System.Windows.Forms.Button cmd_search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_version;
    }
}

