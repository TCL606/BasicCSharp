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
        // 需要实现：分别统计变量Variable被读取、被修改的次数，只允许修改Counting类中的代码
        // 要求：
        // 1. Variable 不能被外部程序赋值为负数。若被赋为负数，则将它代表的值置为0。
        // 2. ReadTimes 为 Variable 被外部程序读取的次数。
        // 3. WriteTimes 为 Variable 被外部程序修改的次数。
        //
        // 注意：是Variable被修改！！！
        // 如果Variable要被赋予的值与当前的值相同，这并不是被修改！
        // 如果Variable要被赋予的值与当前的值不同，则被修改。
        
        int variable = 0;
        int read_times = 0;
        int write_times = 0;

        public Counting()
        {
            read_times = 0;
            write_times = 0;
        }

        public int Variable
        {
            get
            {
                read_times++;
                return variable;
            }
            set
            {
                if (value != variable)
                {
                    int temp = variable;
                    variable = value >= 0 ? value : 0;
                    if( variable != temp )
                    {
                        write_times++;
                    }
                }
            }
        }
    
        public int ReadTimes { get => read_times; }
        public int WriteTimes { get => write_times; }
    
    }
}
