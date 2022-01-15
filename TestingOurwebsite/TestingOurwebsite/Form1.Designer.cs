
namespace TestingOurwebsite
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
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NameCard = new System.Windows.Forms.TextBox();
            this.CardNumber = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.TextBox();
            this.CVV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(169, 20);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(431, 20);
            this.Username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(169, 68);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(431, 20);
            this.Password.TabIndex = 3;
            this.Password.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LoginBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.Location = new System.Drawing.Point(12, 525);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(829, 57);
            this.LoginBTN.TabIndex = 4;
            this.LoginBTN.Text = "Test";
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 47);
            this.label3.TabIndex = 5;
            this.label3.Text = "Payment Method";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name on Card:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Card Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Expiry Month:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "Expiry Year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = "CVV:";
            // 
            // NameCard
            // 
            this.NameCard.Location = new System.Drawing.Point(219, 201);
            this.NameCard.Name = "NameCard";
            this.NameCard.Size = new System.Drawing.Size(381, 20);
            this.NameCard.TabIndex = 11;
            // 
            // CardNumber
            // 
            this.CardNumber.Location = new System.Drawing.Point(219, 260);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(381, 20);
            this.CardNumber.TabIndex = 12;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(219, 320);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(381, 20);
            this.Year.TabIndex = 13;
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(219, 388);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(381, 20);
            this.Month.TabIndex = 14;
            // 
            // CVV
            // 
            this.CVV.Location = new System.Drawing.Point(219, 468);
            this.CVV.Name = "CVV";
            this.CVV.Size = new System.Drawing.Size(381, 20);
            this.CVV.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(853, 594);
            this.Controls.Add(this.CVV);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.CardNumber);
            this.Controls.Add(this.NameCard);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Name = "Form1";
            this.Text = "SeleniumTesting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NameCard;
        private System.Windows.Forms.TextBox CardNumber;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Month;
        private System.Windows.Forms.TextBox CVV;
    }
}

