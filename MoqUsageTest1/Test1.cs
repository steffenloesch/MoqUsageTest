using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace MoqUsageTest1
{
    class Test1
    {
        public static void RunTest()
        {
            Console.WriteLine("Test");
            //This works now.
            var fooMock = Mock.Of<IFoo>(); 
        }

    }

    interface IFoo
    {
        int FooInt();
    }
}
