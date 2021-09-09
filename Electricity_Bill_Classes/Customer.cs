/*
 * Created a class called customer and defined all properties and relevant methods
 * Code by Mehdi Noroozi
 * Date September 08, 2021
 * 
 * */

using System;

namespace Electricity_Bill_Classes
{
    public class Customer
    {
        //Defined properties of the Customer class
        public int AccountNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Decimal KwhUsed { get; set; }
        //method to calculate total bill
        public Decimal BillAmount(Decimal AdminFee = 12m, Decimal KwhRate = 0.07m)
        {
            return (KwhUsed * KwhRate + AdminFee);
        }

        //method to display all customers data in the list box
        public string GetDisplayText(string sep)
        {
            return AccountNo + sep + FirstName + sep + LastName + sep + KwhUsed + sep + BillAmount().ToString("c");
        }
    }
}
