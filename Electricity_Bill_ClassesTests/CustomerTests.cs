/*
 * Created a unit test to check the methods defined in the Customer class.
 * 2 methods were tested.
 * Code by Mehdi Noroozi
 * Date September 08, 2021
 * 
 * */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Electricity_Bill_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill_Classes.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void BillAmountTest()
        {
            //Arrange
            Customer customers = new Customer();
            customers.AccountNo = 100;
            customers.FirstName = "Mehdi";
            customers.LastName = "Noroozi";
            customers.KwhUsed = 10m;
            
            //Act
            Decimal expected = 12.70m;
            Decimal actual = customers.BillAmount();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void GetDisplayTextTest()
        {
            //Arrange
            Customer customers = new Customer();
            customers.AccountNo = 100;
            customers.FirstName = "Mehdi";
            customers.LastName = "Noroozi";
            customers.KwhUsed = 10m;

            //Act
            string expected = "100	Mehdi	Noroozi	10	$12.70";
            string actual = customers.GetDisplayText("\t");

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}