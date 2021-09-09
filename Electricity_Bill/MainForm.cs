/*
 * This is the main form designed for this project
 * Code by Mehdi Noroozi
 * Date September 08, 2021
 * 
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Electricity_Bill_Classes;

namespace Electricity_Bill
{
    public partial class MainForm : Form
    {
        CustomersData customers;

        public MainForm()
        {
            InitializeComponent();
            customers = new CustomersData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox_NCustom.Text = customers.Customers.Count.ToString();
        }

        public Decimal SumKwh = 0m;
        public Decimal SumBill = 0m;
        public int count = 0;

        private void button_Add_Click(object sender, EventArgs e)
        {
            if  (Decimal.TryParse(textBox_KwhUsed.Text, out decimal kwh) && kwh >= 0 ) //Make sure kwh is decimal and positive
            {
                count =  customers.Add(/*accno, */ textBox_FName.Text, textBox_LName.Text, kwh);

                textBox_NCustom.Text = count.ToString();
                
                textBox_TotBill.Text = customers[count - 1].BillAmount().ToString();
               
                listBox_customer.Items.Add(customers[count - 1].GetDisplayText("\t")); 
                textBox_AccNo.Text = customers[count - 1].AccountNo.ToString();

                //Calculate total bill 
                SumBill = SumBill + customers[count - 1].BillAmount();


                //Calculate total Kwh
                SumKwh = SumKwh + customers[count - 1].KwhUsed;
                

            }
            else
            {
                MessageBox.Show("Invalid input for Kwh used ", "Data Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
 
        }



        //Calculate and display total Kwh and average bill
        private void button_summary_Click(object sender, EventArgs e)
        {
            Decimal AverageBill = Math.Round(SumBill / count, 2);
            
            textBox_Average.Text = AverageBill.ToString();

            textBox_totkwh.Text = SumKwh.ToString();
        }

        //Exit button
        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

    }
}
