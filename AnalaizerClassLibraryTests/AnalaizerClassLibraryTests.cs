using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalaizerClassLibrary;
using System;

namespace AnalaizerClassTests
{
    [TestClass]
    public class ReplaceUnaryPlusMinusTest
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"C:\Users\User\Documents\Calculator\AnalaizerClassLibraryTests\TestData.xml", "Test", DataAccessMethod.Sequential)]

        [TestMethod]

        public void InputString_ReplaceUnaryPlusMinusTest_ChangedString()
        {

            // arrange
            string input = (string)TestContext.DataRow["input"];
            string expected = (string)(TestContext.DataRow["expected"]);

            // act
            string result;

            // assert
            try
            {
                result = AnalaizerClass.ReplaceUnaryPlusMinus(input);
                Assert.AreEqual(expected, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
