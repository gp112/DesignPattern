using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 该版本将运算类封装,不考虑输入错误的情况
    /// </summary>
    public class VersionOne
    {
        public void GetResult()
        {
            try
            {
                Console.WriteLine("请输入数字A：");
                string strNumberA = Console.ReadLine();
                Console.WriteLine("请选择运算符号（+、-、*、/）");
                string strOperate = Console.ReadLine();
                Console.WriteLine("请输入数字B：");
                string strNumberB = Console.ReadLine();
                string strResult = "";
                strResult = Convert.ToString(OperationVerOne.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), strOperate));
                Console.WriteLine("结果是：" + strResult);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("您输入的有错" + e.Message);
            }
        }
    }

    public class OperationVerOne
    {
        public static double GetResult(double numberA, double numberB, string operate)
        {
            double result = 0d;
            switch (operate)
            {
                case "+":
                    result = numberA + numberB;
                    break;
                case "-":
                    result = numberA - numberB;
                    break;
                case "*":
                    result = numberA * numberB;
                    break;
                case "/":
                    result = numberA / numberB;
                    break;
            }

            return result;
        }
    }
}
