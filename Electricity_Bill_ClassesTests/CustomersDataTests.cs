/*
 * Created a unit test to check the methods defined in the CustomerData class.
 * One methods was tested
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
    public class CustomersDataTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            CustomersData customers = new CustomersData();

            //Act
            int expected = 1;
            int actual = customers.Add( "Mehdi", "Noroozi", 150m);

            //Assert
            Assert.AreEqual(expected, actual);

        }



    }
}