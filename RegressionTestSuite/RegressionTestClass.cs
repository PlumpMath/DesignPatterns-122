using FactoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegressionTestSuite
{
    [TestClass]
    public class RegressionTestClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsNotNull("Test");
        }

        [TestMethod]
        public void TestMethod2()
        {

            string test = null;
            Assert.IsNull(test);
        }


        [TestMethod]
        public void TestMethod3()
        {

            bool isvalid = true;
            //Assert.IsFalse(isvalid);
        }


        [TestMethod]
        public void FactoryPattern_FactoryCreator_GetFactory_HeroFactory()
        {
            FactoryCreator factory = new FactoryCreator();
            var result = factory.GetBike("hero");
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void FactoryPattern_FactoryCreator_GetFactory_HondaFactory()
        {
            FactoryCreator factory = new FactoryCreator();
            var result = factory.GetBike("honda");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void FactoryPattern_FactoryCreator_GetFactory_YamahaFactory()
        {
            FactoryCreator factory = new FactoryCreator();
            var result = factory.GetBike("yamaha");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [Ignore]
        public void FactoryPattern_FactoryCreator_GetFactory_InvalidFactory()
        {
            FactoryCreator factory = new FactoryCreator();
            var result = factory.GetBike("Test");
            Assert.IsNotNull(result);
        }
    }
}
