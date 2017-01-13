using FactoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace DesignPatternTest
{
    [TestClass]
    public class UnitTestClass
    {
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
