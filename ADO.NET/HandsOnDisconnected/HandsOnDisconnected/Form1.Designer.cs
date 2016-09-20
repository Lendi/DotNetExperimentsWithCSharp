namespace HandsOnDisconnected
{
    partial class Form1
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
            this.cbdeptid = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpjoindate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbsalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbdesig = new System.Windows.Forms.ComboBox();
            this.tbempname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbempid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbdeptid
            // 
            this.cbdeptid.FormattingEnabled = true;
            this.cbdeptid.Location = new System.Drawing.Point(124, 229);
            this.cbdeptid.Name = "cbdeptid";
            this.cbdeptid.Size = new System.Drawing.Size(121, 21);
            this.cbdeptid.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "DeptId";
            // 
            // dtpjoindate
            // 
            this.dtpjoindate.Location = new System.Drawing.Point(124, 196);
            this.dtpjoindate.Name = "dtpjoindate";
            this.dtpjoindate.Size = new System.Drawing.Size(200, 20);
            this.dtpjoindate.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "JoinDate";
            // 
            // tbsalary
            // 
            this.tbsalary.Location = new System.Drawing.Point(124, 161);
            this.tbsalary.Name = "tbsalary";
            this.tbsalary.Size = new System.Drawing.Size(100, 20);
            this.tbsalary.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Salary";
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
            this.cbdesig.Location = new System.Drawing.Point(124, 122);
            this.cbdesig.Name = "cbdesig";
            this.cbdesig.Size = new System.Drawing.Size(121, 21);
            this.cbdesig.TabIndex = 21;
            // 
            // tbempname
            // 
            this.tbempname.Location = new System.Drawing.Point(124, 84);
            this.tbempname.Name = "tbempname";
            this.tbempname.Size = new System.Drawing.Size(100, 20);
            this.tbempname.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Designation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "EmpName";
            // 
            // tbempid
            // 
            this.tbempid.Location = new System.Drawing.Point(124, 42);
            this.tbempid.Name = "tbempid";
            this.tbempid.Size = new System.Drawing.Size(100, 20);
            this.tbempid.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "EmpId";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(149, 304);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(41, 304);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 29;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 490);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbdeptid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpjoindate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbsalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbdesig;
        private System.Windows.Forms.TextBox tbempname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbempid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;


    }
}

