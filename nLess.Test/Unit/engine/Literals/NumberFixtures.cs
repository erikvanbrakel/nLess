﻿using nless.Core.engine;
using NUnit.Framework;

namespace nLess.Test.Unit.engine.Literals
{
    [TestFixture]
    public class NumberFixture
    {
        [Test]
        public void CanOperateOnNumber()
        {
            var number = new Number("%", 100);
            number += 100;
            Assert.AreEqual("200%", number.ToCss());
        }
    }
}
