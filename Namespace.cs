using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Namespace1
{
    internal class Class
    {
        public static void Method()
        {
            Console.WriteLine("It is Namespce1");
        }
    }
}

namespace Namespace2
{
    internal class Class
    {
        public static void Method()
        {
            Console.WriteLine("It is Namespce2");
        }
    }
}
namespace Namespace3
{
    namespace Namespace4
    {
        internal class Class
        {
            public static void Method()
            {
                Console.WriteLine("It is Namespce2");
            }
        }

    }
}
namespace MainNamespace
{
    internal class Class1
    {
        public static void Main()
        {
            Namespace1.Class.Method();
            Namespace2.Class.Method();
            Namespace3.Namespace4.Class.Method();
        }
    }
}
