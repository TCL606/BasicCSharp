using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Program
    {
        public static void Main(string[] args)  // 该程序用于Debug
        {
            int temp = 0;
            ICountableVariable counting = new Counting();
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    counting.Variable = 1;
                }
                if (i == 6 || i == 7)
                {
                    counting.Variable = -i;
                }
                if (i % 5 == 0)
                {
                    temp = counting.Variable;
                }
            }
            Console.WriteLine($"Variable被读取了{counting.ReadTimes}次；" +
                              $"Variable被修改了{counting.WriteTimes}次；" +
                              $"局部变量temp最终为{temp}");

            // 理论输出：Variable被读取了2次；Variable被修改了3次；局部变量temp最终为1
        }
    }

    public interface ICountableVariable
    {
        public int Variable { get; set; }
        public int ReadTimes { get; }
        public int WriteTimes { get; }
    }

    public class Counting : ICountableVariable
    {
        private int variable;
        private int readTimes;
        private int writeTimes;
        public int Variable
        {
            get
            {
                readTimes++;
                return variable;
            }
            set
            {
                if(!(variable == value||(variable == 0 && value < 0)))
                {
                    writeTimes++;
                }
                variable = value>=0? value:0;
            }
        }
        public int ReadTimes { get { return readTimes; } }
        public int WriteTimes { get { return writeTimes; } }
    }
}
