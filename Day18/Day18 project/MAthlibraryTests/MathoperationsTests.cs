using Microsoft.VisualStudio.TestTools.UnitTesting;
using MAthlibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAthlibrary.Tests
{
    [TestClass()]
    public class MathoperationsTests
    {
        [TestMethod()]
        public void FindFactorialTest_zeroinput()
        {
            //arrange
            int n = 0;
            int expected = 1;
            //act
            int actual = Mathoperations.FindFactorial(n);
            //assert
            Assert.AreEqual(expected, actual);  
        }
        public void FindFactorialTest_Onetoseven()
        {
            //arrange
            int n = 5;
            int expected = 120;   
            //act
            int actual=Mathoperations.FindFactorial(n); 
            //assert
            Assert.AreEqual(expected , actual);
        }
        public void FindFactorialTest_graetertahn7()
        {
            //arrange
            int n = 9;
            int expected = -999;
            //act
            int actual=Mathoperations.FindFactorial(n);    
            //assert
            Assert.AreEqual(expected, actual);
        }
        public void FindFactorialTest_Lessthan0()
        {
            //arrange
            int n = -10;
            int expected = -9999;
            //act
            int actual= Mathoperations.FindFactorial(n);    
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}