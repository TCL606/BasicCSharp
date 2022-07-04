using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework1;
using System;

namespace Test_hw1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int temp;
            int readTimes = 0;
            int writeTimes = 0;
            int max = 15;
            ICountableVariable counting = new Counting();
            Random rand = new Random();
            for (int i = 0; i < 10001; i++)
            {
                int r = rand.Next(max);
                if (r % 2 == 0)
                {
                    temp = counting.Variable;
                    readTimes++;
                    if (temp != counting.Variable)
                        writeTimes++;
                    readTimes++;
                }
                if (r % 3 == 0)
                {
                    temp = counting.Variable;
                    readTimes++;
                    counting.Variable = 2 * r - 10;
                    if (temp != counting.Variable)
                        writeTimes++;
                    readTimes++;
                }
            }
            Assert.IsTrue(writeTimes == counting.WriteTimes && readTimes == counting.ReadTimes);
        }
    }
}