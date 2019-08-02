using System;
using System.Diagnostics;
using COMP123_S2019_A5_SectionAExample;
using COMP123_S2019_A5_SectionAExample.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DollarComputersUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        SelectForm selectForm;

        [TestMethod]
        public void TestThatSelectFormHasLoadedDataSource()
        {
            // arrange
            

            // act
            selectForm = new SelectForm();
            //selectForm.ShowInTaskbar = false;
            //selectForm.ShowDialog();

            // assert
            Assert.IsTrue(selectForm.HasLoadedDataSource());
        }

        [TestMethod]
        public void TestThatSelectLabelDisplaysItemSelected()
        {
            // arrange
            
            string outputString;

            // act
            selectForm = new SelectForm();
            selectForm.ShowInTaskbar = false;
            selectForm.ShowDialog();
            outputString = selectForm.SelectLabel.Text;
            // assert
            Assert.AreEqual("Asus G71GX-RX05 $719.97", outputString);

        }
    }
}
