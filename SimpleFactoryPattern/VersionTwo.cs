using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 该版本通过继承实现
    /// </summary>
    class VersionTwo
    {
        public void Operation()
        {
            OperationTwo oper;
            Console.WriteLine("请输入数字A：");
            string strNumberA = Console.ReadLine();
            Console.WriteLine("请选择运算符号（+、-、*、/）");
            oper = OperationFactory.createOperation(Console.ReadLine());
            Console.WriteLine("请输入数字B：");
            string strNumberB = Console.ReadLine();

            oper.NumberA = Convert.ToDouble(strNumberA);
            oper.NumberB = Convert.ToDouble(strNumberB);

            double result = oper.GetResult();

            Console.WriteLine("结果是: " + result);
            Console.ReadKey();
        }
    }

    // 工厂类
    public class OperationFactory
    {
        public static OperationTwo createOperation(string operate)
        {
            OperationTwo oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
            }

            return oper;
        }
    }

    // Operation 类
    public class OperationTwo
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double NumberA
        {
            get { return _numberA; }
            set { this._numberA = value; }
        }

        public double NumberB
        {
            get { return _numberB; }
            set { this._numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    // 加减乘除类
    class OperationAdd : OperationTwo
    {
        public override double GetResult()
        {
            double result = 0;
            result = this.NumberA + this.NumberB;
            return result;
        }
    }

    class OperationSub : OperationTwo
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    class OperationMul : OperationTwo
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    class OperationDiv : OperationTwo
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA / NumberB;
            return result;
        }
    }


}
