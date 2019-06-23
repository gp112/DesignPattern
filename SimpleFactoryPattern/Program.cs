using System;

namespace SimpleFactoryPattern
{
    /**
     * 该类实现两个数字之间的运算，主要为了展示简单工厂模式是如何一步一步实现的
     */
    class Program
    {
        static void Main(string[] args)
        {
            //VersionOne version1 = new VersionOne();
            //version1.GetResult();

            VersionTwo version2 = new VersionTwo();
            version2.Operation();
        }
    }
}
