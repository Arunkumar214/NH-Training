using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArunKLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArunKLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_0_input()
        {
            //Arrange 
            int input = 0;
            int expected = 1;


            //Act
            int actual = Algebra.Factorial(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_Greaterthan7_input()
        {
            //Arrange 
            int input = 8;
            int expected = -999;


            //Act
            int actual = Algebra.Factorial(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_Lessthan0_input()
        {
            //Arrange 
            int input = -6;
            int expected = -9999;


            //Act
            int actual = Algebra.Factorial(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_Fact_input()
        {
            //Arrange 
            int input = 5;
            int expected = 120;


            //Act
            int actual = Algebra.Factorial(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PalindromeTest()
        {
            //Arrange
            int n = 121;
            string expected = "Palindrome";
            //Act
            string actual = Algebra.Palindrome(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PalindromeTest_Wrong()
        {
            //Arrange
            int n = 443;
            string expected = "Not a Palindrome";
            //Act
            string actual = Algebra.Palindrome(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}