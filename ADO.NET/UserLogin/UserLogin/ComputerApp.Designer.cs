namespace UserLogin
{
    partial class ComputerApp
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
            this.tbcustomername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbti3 = new System.Windows.Forms.RadioButton();
            this.rbti5 = new System.Windows.Forms.RadioButton();
            this.rbti7 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbspeakers = new System.Windows.Forms.CheckBox();
            this.cbpendrive = new System.Windows.Forms.CheckBox();
            this.cbkeyboard = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbamount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbcash = new System.Windows.Forms.RadioButton();
            this.rbcard = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter customer name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbcustomername
            // 
            this.tbcustomername.Location = new System.Drawing.Point(257, 28);
            this.tbcustomername.Name = "tbcustomername";
            this.tbcustomername.Size = new System.Drawing.Size(171, 20);
            this.tbcustomername.TabIndex = 1;
            this.tbcustomername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbti7);
            this.groupBox1.Controls.Add(this.rbti5);
            this.groupBox1.Controls.Add(this.rbti3);
            this.groupBox1.Location = new System.Drawing.Point(13, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processor";
            // 
            // rbti3
            // 
            this.rbti3.AutoSize = true;
            this.rbti3.Location = new System.Drawing.Point(12, 30);
            this.rbti3.Name = "rbti3";
            this.rbti3.Size = new System.Drawing.Size(33, 17);
            this.rbti3.TabIndex = 0;
            this.rbti3.TabStop = true;
            this.rbti3.Text = "i3";
            this.rbti3.UseVisualStyleBackColor = true;
            this.rbti3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbti5
            // 
            this.rbti5.AutoSize = true;
            this.rbti5.Location = new System.Drawing.Point(12, 53);
            this.rbti5.Name = "rbti5";
            this.rbti5.Size = new System.Drawing.Size(33, 17);
            this.rbti5.TabIndex = 1;
            this.rbti5.TabStop = true;
            this.rbti5.Text = "i5";
            this.rbti5.UseVisualStyleBackColor = true;
            this.rbti5.CheckedChanged += new System.EventHandler(this.rbti5_CheckedChanged);
            // 
            // rbti7
            // 
            this.rbti7.AutoSize = true;
            this.rbti7.Location = new System.Drawing.Point(12, 76);
            this.rbti7.Name = "rbti7";
            this.rbti7.Size = new System.Drawing.Size(33, 17);
            this.rbti7.TabIndex = 2;
            this.rbti7.TabStop = true;
            this.rbti7.Text = "i7";
            this.rbti7.UseVisualStyleBackColor = true;
            this.rbti7.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbkeyboard);
            this.panel1.Controls.Add(this.cbpendrive);
            this.panel1.Controls.Add(this.cbspeakers);
            this.panel1.Location = new System.Drawing.Point(319, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 108);
            this.panel1.TabIndex = 3;
            // 
            // cbspeakers
            // 
            this.cbspeakers.AutoSize = true;
            this.cbspeakers.Location = new System.Drawing.Point(12, 12);
            this.cbspeakers.Name = "cbspeakers";
            this.cbspeakers.Size = new System.Drawing.Size(71, 17);
            this.cbspeakers.TabIndex = 0;
            this.cbspeakers.Text = "Speakers";
            this.cbspeakers.UseVisualStyleBackColor = true;
            this.cbspeakers.CheckedChanged += new System.EventHandler(this.cbspeakers_CheckedChanged);
            // 
            // cbpendrive
            // 
            this.cbpendrive.AutoSize = true;
            this.cbpendrive.Location = new System.Drawing.Point(12, 35);
            this.cbpendrive.Name = "cbpendrive";
            this.cbpendrive.Size = new System.Drawing.Size(68, 17);
            this.cbpendrive.TabIndex = 1;
            this.cbpendrive.Text = "Pendrive";
            this.cbpendrive.UseVisualStyleBackColor = true;
            this.cbpendrive.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbkeyboard
            // 
            this.cbkeyboard.AutoSize = true;
            this.cbkeyboard.Location = new System.Drawing.Point(12, 58);
            this.cbkeyboard.Name = "cbkeyboard";
            this.cbkeyboard.Size = new System.Drawing.Size(71, 17);
            this.cbkeyboard.TabIndex = 2;
            this.cbkeyboard.Text = "Keyboard";
            this.cbkeyboard.UseVisualStyleBackColor = true;
            this.cbkeyboard.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbamount
            // 
            this.tbamount.Location = new System.Drawing.Point(278, 198);
            this.tbamount.Name = "tbamount";
            this.tbamount.ReadOnly = true;
            this.tbamount.Size = new System.Drawing.Size(178, 20);
            this.tbamount.TabIndex = 5;
            this.tbamount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbcard);
            this.groupBox2.Controls.Add(this.rbcash);
            this.groupBox2.Location = new System.Drawing.Point(13, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(257, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 100);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Card Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Card Holder Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(126, 49);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(192, 20);
            this.textBox4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbcash
            // 
            this.rbcash.AutoSize = true;
            this.rbcash.Location = new System.Drawing.Point(12, 20);
            this.rbcash.Name = "rbcash";
            this.rbcash.Size = new System.Drawing.Size(49, 17);
            this.rbcash.TabIndex = 0;
            this.rbcash.TabStop = true;
            this.rbcash.Text = "Cash";
            this.rbcash.UseVisualStyleBackColor = true;
            this.rbcash.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // rbcard
            // 
            this.rbcard.AutoSize = true;
            this.rbcard.Location = new System.Drawing.Point(12, 49);
            this.rbcard.Name = "rbcard";
            this.rbcard.Size = new System.Drawing.Size(47, 17);
            this.rbcard.TabIndex = 1;
            this.rbcard.TabStop = true;
            this.rbcard.Text = "Card";
            this.rbcard.UseVisualStyleBackColor = true;
            this.rbcard.CheckedChanged += new System.EventHandler(this.rbcard_CheckedChanged);
            // 
            // ComputerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbcustomername);
            this.Controls.Add(this.label1);
            this.Name = "ComputerApp";
            this.Text = "ComputerApp";
            this.Load += new System.EventHandler(this.ComputerApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbcustomername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbti3;
        private System.Windows.Forms.RadioButton rbti7;
        private System.Windows.Forms.RadioButton rbti5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbkeyboard;
        private System.Windows.Forms.CheckBox cbpendrive;
        private System.Windows.Forms.CheckBox cbspeakers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbamount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbcard;
        private System.Windows.Forms.RadioButton rbcash;
    }
}