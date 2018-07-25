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
            //The line below gives error "The name 'Mock' does not exist in the current context"
            //var fooMock = Mock.Of<IFoo>(); 
        }

    }

    interface IFoo
    {
        int FooInt();
    }
}
