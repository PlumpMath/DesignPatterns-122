using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryPattern;

namespace DesignPattern.Test
{
    [TestClass]
    public class UnitTest1
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
    }
}
