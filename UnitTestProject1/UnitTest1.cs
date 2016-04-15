using System;
using System.IO.MemoryMappedFiles;
using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public abstract class MappingTestBase
    {
        private static bool _classInitCalled;
        protected static Mapper MapperInstance;
        protected static ModelClass MappedEntity;

        [ClassInitialize]
        public void ClassInit(TestContext context)
        {
            MapperInstance = new Mapper();
            MappedEntity = new ModelClass();
            MapperInstance.MapData(MappedEntity);
            _classInitCalled = true;
        }

        [TestInitialize]
        public void TestInit()
        {
            if (!_classInitCalled)
            {
                ClassInit(null);
            }
        }
    }

    [TestClass]
    public class MappingTests : MappingTestBase
    {
        [TestMethod]
        public void Prop1_Test()
        {
            Assert.AreEqual(1, MappedEntity.Prop1);
        }

        [TestMethod]
        public void Prop2_Test()
        {
            Assert.AreEqual("Hey", MappedEntity.Prop2);
        }

        [TestMethod]
        public void Prop3_Test()
        {
            Assert.AreEqual("There", MappedEntity.Prop3);
        }

        [TestMethod]
        public void Prop4_Test()
        {
            Assert.AreEqual("Ther", MappedEntity.Prop4);
        }

    }
}
