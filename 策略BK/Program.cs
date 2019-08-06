using System;

namespace 策略BK
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;

            // 由于实例化不同的策略，所以最终在调用 context.ContextInterface(); 时，所获得的结果就不尽相同
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
        }

        
    }

    // 抽象算法接口
    abstract class Strategy
    {
        // 算法方法
        public abstract void Algorithmlnterface();
    }

    // 具体算法A
    class ConcreteStrategyA : Strategy
    {
        public override void Algorithmlnterface()
        {
            Console.WriteLine("算法A 的实现");
        }
    }

    // 具体算法B
    class ConcreteStrategyB : Strategy
    {
        public override void Algorithmlnterface()
        {
            Console.WriteLine("算法B 的实现");
        }
    }

    // 具体算法 C
    class ConcreteStrategyC : Strategy
    {
        public override void Algorithmlnterface()
        {
            Console.WriteLine("算法C 的实现");
        }
    }

    // 上下文
    class Context
    {
        Strategy strategy;
        // 初始化时，传入具体的策略对象
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        // 上下文
        public void ContextInterface()
        {
            // 根据具体的策略对象，调用其算法的方法
            strategy.Algorithmlnterface();
        }
    }
}
