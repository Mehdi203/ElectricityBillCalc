/*
 * Created a class called CustomerData and defined a list to include all customers data input by the user
 * Code by Mehdi Noroozi
 * Date September 08, 2021
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill_Classes
{
    public class CustomersData
    {
        private List<Customer> _customers;

        //constructor
        public CustomersData()
        {
            _customers = new List<Customer>();
        }

        //Read-Only property
        public List<Customer> Customers
        { get
            {
                return _customers;
            }
                
        }

        // public List<Customer> Customers => _customers;

        public int Add(Customer cust)
        {
            cust.AccountNo = (_customers.Count + 100);
            _customers.Add(cust);
            return _customers.Count;
        }


        public int Add(/*int AccNo, */ string FName, string LName, Decimal KwhUsed)
        {
            _customers.Add(new Customer()
            {
                AccountNo = (_customers.Count + 100) /*AccountNo = AccNo */, FirstName = FName, LastName = LName, KwhUsed = KwhUsed 
            });

            return _customers.Count;
        }

        //class indexer
        public Customer this[int index]
        {
            get { return _customers[index]; }
        }

        public int Remove(Customer cust)
        {
            _customers.Remove(cust);
            return _customers.Count;
        }

    }
}
