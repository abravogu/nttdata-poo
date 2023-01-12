using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProyect.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProyect.Loops.Tests
{
    [TestClass()]
    public class PrintProductTests
    {

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            PrintProduct.CreateListProduct();
        }

        [TestMethod()]
        public void GetProductGraterThan30WithForTest()
        {
          /*  if (PrintProduct.products.Count == 0)
                PrintProduct.CreateListProduct();*/
         
            Assert.IsTrue(PrintProduct.GetProductGraterThan30WithFor().Count==2);
            Assert.IsTrue(PrintProduct.GetProductGraterThan30WithFor()[0].Name=="Aceite");
            Assert.IsTrue(PrintProduct.GetProductGraterThan30WithFor()[1].Name == "Juego");
        }

        [TestMethod()]
        public void GetProductGraterThan30WithForEachTest()
        {
            /*  if (PrintProduct.products.Count == 0)
                PrintProduct.CreateListProduct();*/
            Assert.IsTrue(PrintProduct.GetProductGraterThan30WithFor().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductGraterThan30WithForEach()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductGraterThan30WithForEach()[1].Name == "Juego");
        }

        [TestMethod()]
        public void GetProductGraterThan30WithWhileTest()
        {
            /*  if (PrintProduct.products.Count == 0)
                PrintProduct.CreateListProduct();*/
            Assert.IsTrue(PrintProduct.GetProductGraterThan30WithFor().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductGraterThan30WithWhile()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductGraterThan30WithWhile()[1].Name == "Juego");
        }

        [TestMethod()]
        public void GetProductGraterThan30WithLinQTest()
        {
            /*  if (PrintProduct.products.Count == 0)
                 PrintProduct.CreateListProduct();*/
            Assert.IsTrue(PrintProduct.GetProductGraterThan30WithFor().Count == 2);
            Assert.IsTrue(PrintProduct.GetProductGraterThan30WithLinQ()[0].Name == "Aceite");
            Assert.IsTrue(PrintProduct.GetProductGraterThan30WithLinQ()[1].Name == "Juego");
        }
    }
}