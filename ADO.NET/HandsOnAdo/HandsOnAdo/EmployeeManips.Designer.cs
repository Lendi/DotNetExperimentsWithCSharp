namespace HandsOnAdo
{
    partial class EmployeeManips
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
            this.tbempid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbempname = new System.Windows.Forms.TextBox();
            this.cbdesig = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbsalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpjoindate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbdeptid = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmpId";
            // 
            // tbempid
            // 
            this.tbempid.Location = new System.Drawing.Point(125, 38);
            this.tbempid.Name = "tbempid";
            this.tbempid.Size = new System.Drawing.Size(100, 20);
            this.tbempid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "EmpName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Designation";
            // 
            // tbempname
            // 
            this.tbempname.Location = new System.Drawing.Point(125, 80);
            this.tbempname.Name = "tbempname";
            this.tbempname.Size = new System.Drawing.Size(100, 20);
            this.tbempname.TabIndex = 4;
            // 
            // cbdesig
            // 
            this.cbdesig.FormattingEnabled = true;
            this.cbdesig.Items.AddRange(new object[] {
            "Teamleader",
            "Project Manager",
            "HR",
            "Admin\t",
            "Developer"});
            this.cbdesig.Location = new System.Drawing.Point(125, 118);
            this.cbdesig.Name = "cbdesig";
            this.cbdesig.Size = new System.Drawing.Size(121, 21);
            this.cbdesig.TabIndex = 5;
            this.cbdesig.SelectedIndexChanged += new System.EventHandler(this.cbdesig_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salary";
            // 
            // tbsalary
            // 
            this.tbsalary.Location = new System.Drawing.Point(125, 157);
            this.tbsalary.Name = "tbsalary";
            this.tbsalary.Size = new System.Drawing.Size(100, 20);
            this.tbsalary.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "JoinDate";
            // 
            // dtpjoindate
            // 
            this.dtpjoindate.Location = new System.Drawing.Point(125, 192);
            this.dtpjoindate.Name = "dtpjoindate";
            this.dtpjoindate.Size = new System.Drawing.Size(200, 20);
            this.dtpjoindate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "DeptId";
            // 
            // cbdeptid
            // 
            this.cbdeptid.FormattingEnabled = true;
            this.cbdeptid.Location = new System.Drawing.Point(125, 225);
            this.cbdeptid.Name = "cbdeptid";
            this.cbdeptid.Size = new System.Drawing.Size(121, 21);
            this.cbdeptid.TabIndex = 11;
            this.cbdeptid.SelectedIndexChanged += new System.EventHandler(this.cbdeptid_SelectedIndexChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(43, 283);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(289, 78);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 13;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(150, 283);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(260, 283);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // EmployeeManips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 465);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbdeptid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpjoindate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbsalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbdesig);
            this.Controls.Add(this.tbempname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbempid);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeManips";
            this.Text = "EmployeeManips";
            this.Load += new System.EventHandler(this.EmployeeManips_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbempid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbempname;
        private System.Windows.Forms.ComboBox cbdesig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbsalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpjoindate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbdeptid;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
    }
}