namespace Phonebook
{
    partial class frmSearch
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
            this.cmd_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_search = new System.Windows.Forms.TextBox();
            this.cmd_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_search
            // 
            this.cmd_search.BackColor = System.Drawing.Color.CadetBlue;
            this.cmd_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_search.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_search.ForeColor = System.Drawing.Color.Cornsilk;
            this.cmd_search.Location = new System.Drawing.Point(220, 73);
            this.cmd_search.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_search.Name = "cmd_search";
            this.cmd_search.Size = new System.Drawing.Size(100, 28);
            this.cmd_search.TabIndex = 1;
            this.cmd_search.Text = "Search";
            this.cmd_search.UseVisualStyleBackColor = false;
            this.cmd_search.Click += new System.EventHandler(this.cmd_search_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(112, 41);
            this.text_search.Margin = new System.Windows.Forms.Padding(4);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(207, 22);
            this.text_search.TabIndex = 0;
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.BackColor = System.Drawing.Color.CadetBlue;
            this.cmd_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_cancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_cancel.ForeColor = System.Drawing.Color.Cornsilk;
            this.cmd_cancel.Location = new System.Drawing.Point(112, 73);
            this.cmd_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(100, 28);
            this.cmd_cancel.TabIndex = 4;
            this.cmd_cancel.Text = "Cancel";
            this.cmd_cancel.UseVisualStyleBackColor = false;
            this.cmd_cancel.Click += new System.EventHandler(this.cmd_cancel_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(419, 161);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHONEBOOK - SEARCH";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmd_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.Button cmd_cancel;
    }
}