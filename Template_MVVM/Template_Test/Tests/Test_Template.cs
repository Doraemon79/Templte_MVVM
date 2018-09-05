using Ninject.MockingKernel.Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Test.Tests
{
    public class Test_Template
    {
        private readonly MoqMockingKernel _kernel;
        public Test_Template()
        {
            _kernel = new MoqMockingKernel();
          //  _kernel.Bind<ICalculatorHelper>().To<CalculatorHelper>();
        }
        [SetUp]
        public void SetUp()
        {
            _kernel.Reset();
        }

        [Test]

        [TestCase(100, 50, 50)]
        [TestCase(100, 100, 0)]
        [TestCase(100, 0, 100)]
        public void Test_CalulculatePercentage(int part, int total, int res)
        {
            //setup the mock
            //var inputProcessor_Mock = _kernel.GetMock<IinputProcessor>();
            //var tupleProcessor_Mock = _kernel.GetMock<ITupleProcessor>();

            //var _calculatorHelper = _kernel.Get<ICalculatorHelper>();
            //var result = _calculatorHelper.CalulculatePercentage(part, total);
            //Assert.AreEqual(res, result);

        }
    }
}
