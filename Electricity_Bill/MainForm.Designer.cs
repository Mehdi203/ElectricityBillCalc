
namespace Electricity_Bill
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_AccNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_FName = new System.Windows.Forms.TextBox();
            this.textBox_LName = new System.Windows.Forms.TextBox();
            this.textBox_KwhUsed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TotBill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_NCustom = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.listBox_customer = new System.Windows.Forms.ListBox();
            this.textBox_Average = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_totkwh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_summary = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_AccNo
            // 
            this.textBox_AccNo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_AccNo.Location = new System.Drawing.Point(224, 49);
            this.textBox_AccNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_AccNo.Name = "textBox_AccNo";
            this.textBox_AccNo.ReadOnly = true;
            this.textBox_AccNo.Size = new System.Drawing.Size(127, 29);
            this.textBox_AccNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account No.";
            // 
            // textBox_FName
            // 
            this.textBox_FName.Location = new System.Drawing.Point(224, 126);
            this.textBox_FName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_FName.Name = "textBox_FName";
            this.textBox_FName.Size = new System.Drawing.Size(127, 29);
            this.textBox_FName.TabIndex = 2;
            // 
            // textBox_LName
            // 
            this.textBox_LName.Location = new System.Drawing.Point(224, 206);
            this.textBox_LName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_LName.Name = "textBox_LName";
            this.textBox_LName.Size = new System.Drawing.Size(127, 29);
            this.textBox_LName.TabIndex = 3;
            // 
            // textBox_KwhUsed
            // 
            this.textBox_KwhUsed.Location = new System.Drawing.Point(224, 286);
            this.textBox_KwhUsed.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_KwhUsed.Name = "textBox_KwhUsed";
            this.textBox_KwhUsed.Size = new System.Drawing.Size(127, 29);
            this.textBox_KwhUsed.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "KWH Used";
            // 
            // textBox_TotBill
            // 
            this.textBox_TotBill.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_TotBill.Location = new System.Drawing.Point(224, 369);
            this.textBox_TotBill.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TotBill.Name = "textBox_TotBill";
            this.textBox_TotBill.ReadOnly = true;
            this.textBox_TotBill.Size = new System.Drawing.Size(127, 29);
            this.textBox_TotBill.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 369);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Bill";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 449);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "No. of Customers";
            // 
            // textBox_NCustom
            // 
            this.textBox_NCustom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_NCustom.Location = new System.Drawing.Point(224, 452);
            this.textBox_NCustom.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_NCustom.Name = "textBox_NCustom";
            this.textBox_NCustom.ReadOnly = true;
            this.textBox_NCustom.Size = new System.Drawing.Size(127, 29);
            this.textBox_NCustom.TabIndex = 12;
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.DarkGreen;
            this.button_Add.Location = new System.Drawing.Point(112, 541);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(105, 47);
            this.button_Add.TabIndex = 13;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // listBox_customer
            // 
            this.listBox_customer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox_customer.FormattingEnabled = true;
            this.listBox_customer.ItemHeight = 21;
            this.listBox_customer.Location = new System.Drawing.Point(474, 49);
            this.listBox_customer.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_customer.Name = "listBox_customer";
            this.listBox_customer.Size = new System.Drawing.Size(424, 340);
            this.listBox_customer.TabIndex = 14;
            // 
            // textBox_Average
            // 
            this.textBox_Average.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_Average.Location = new System.Drawing.Point(126, 141);
            this.textBox_Average.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Average.Name = "textBox_Average";
            this.textBox_Average.ReadOnly = true;
            this.textBox_Average.Size = new System.Drawing.Size(127, 29);
            this.textBox_Average.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Average Bill";
            // 
            // textBox_totkwh
            // 
            this.textBox_totkwh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_totkwh.Location = new System.Drawing.Point(126, 94);
            this.textBox_totkwh.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_totkwh.Name = "textBox_totkwh";
            this.textBox_totkwh.ReadOnly = true;
            this.textBox_totkwh.Size = new System.Drawing.Size(127, 29);
            this.textBox_totkwh.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Kwh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Account No.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(580, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(664, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "Last Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(753, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "KWH Used";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(837, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 21);
            this.label13.TabIndex = 23;
            this.label13.Text = "Total Bill";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(901, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "Exit";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_summary
            // 
            this.button_summary.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_summary.Location = new System.Drawing.Point(126, 27);
            this.button_summary.Name = "button_summary";
            this.button_summary.Size = new System.Drawing.Size(126, 41);
            this.button_summary.TabIndex = 26;
            this.button_summary.Text = "Calculate";
            this.button_summary.UseVisualStyleBackColor = false;
            this.button_summary.Click += new System.EventHandler(this.button_summary_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.button_summary);
            this.groupBox1.Controls.Add(this.textBox_totkwh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_Average);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(509, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 187);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1017, 630);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox_customer);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_NCustom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_TotBill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_KwhUsed);
            this.Controls.Add(this.textBox_LName);
            this.Controls.Add(this.textBox_FName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_AccNo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Customer Data";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_AccNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_FName;
        private System.Windows.Forms.TextBox textBox_LName;
        private System.Windows.Forms.TextBox textBox_KwhUsed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TotBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_NCustom;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ListBox listBox_customer;
        private System.Windows.Forms.TextBox textBox_Average;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_totkwh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_summary;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

