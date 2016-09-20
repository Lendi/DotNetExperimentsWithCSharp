namespace HandsOnTransactions
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbRecieverAcc = new System.Windows.Forms.TextBox();
            this.tbAmt = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
            this.tbSenderAcc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RecieverAcc";
            // 
            // tbRecieverAcc
            // 
            this.tbRecieverAcc.Location = new System.Drawing.Point(125, 89);
            this.tbRecieverAcc.Name = "tbRecieverAcc";
            this.tbRecieverAcc.Size = new System.Drawing.Size(201, 20);
            this.tbRecieverAcc.TabIndex = 2;
            // 
            // tbAmt
            // 
            this.tbAmt.Location = new System.Drawing.Point(125, 142);
            this.tbAmt.Name = "tbAmt";
            this.tbAmt.Size = new System.Drawing.Size(201, 20);
            this.tbAmt.TabIndex = 4;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(35, 150);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 3;
            this.Amount.Text = "Amount";
            // 
            // tbSenderAcc
            // 
            this.tbSenderAcc.Location = new System.Drawing.Point(125, 37);
            this.tbSenderAcc.Name = "tbSenderAcc";
            this.tbSenderAcc.Size = new System.Drawing.Size(201, 20);
            this.tbSenderAcc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SenderAcc";
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(102, 206);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 7;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 427);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.tbSenderAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAmt);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.tbRecieverAcc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRecieverAcc;
        private System.Windows.Forms.TextBox tbAmt;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox tbSenderAcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProceed;
    }
}

