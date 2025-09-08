using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NazarovSV.Sprint0.Task3.V0.Lib;

namespace Tyuiu.NazarovSV.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckIfValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
