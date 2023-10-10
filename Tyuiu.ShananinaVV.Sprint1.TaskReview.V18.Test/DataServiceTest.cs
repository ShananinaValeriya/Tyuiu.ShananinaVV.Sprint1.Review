using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint1.TaskReview.V18.Lib;

namespace Tyuiu.ShananinaVV.Sprint1.TaskReview.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 2.274;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
