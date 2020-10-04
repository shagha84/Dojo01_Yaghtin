using System;
using System.Linq;

namespace Dojo01_Yaghtin
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0 || args.FirstOrDefault() == "obj")
            {
                TestWithObject();
            }
            else if (args.FirstOrDefault() == "string")
            {
                TestWithString();
            }
            else if (args.FirstOrDefault() == "int")
            {
                TestWithInt();
            }

            Console.WriteLine();
            Console.WriteLine("Press return to close the application.");
            Console.ReadLine();
        }


        static void TestWithInt()
        {
            Stapel<int> test = new Stapel<int>();

            test.Push(2);
            test.Push(3);
            Console.WriteLine("read: '{0}'", test.Peek());
            test.Push(4);

            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: '{0}'", test.Peek());
            Console.WriteLine("{0} removed", test.Pop());
        }

        static void TestWithString()
        {
            Stapel<string> test = new Stapel<string>();

            test.Push("E1");
            test.Push("E2");
            Console.WriteLine("read: '{0}'", test.Peek());
            test.Push("E3");

            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: '{0}'", test.Peek());
            Console.WriteLine("{0} removed", test.Pop());

        }

        static void TestWithObject()
        {
            Stapel<TestObject> test = new Stapel<TestObject>();

            test.Push(new TestObject(35, "Shagha"));
            Console.WriteLine("read: '{0}'", test.Peek());
            test.Push(new TestObject(44, "Isabella"));
            Console.WriteLine("read: '{0}'", test.Peek());
            test.Push(new TestObject(33, "Diba"));
            Console.WriteLine("read: '{0}'", test.Peek());
            test.Push(new TestObject(21, "Sara"));
            Console.WriteLine("read: '{0}'", test.Peek());

            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: '{0}'", test.Peek());
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: '{0}'", test.Peek());
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: '{0}'", test.Peek());
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: '{0}'", test.Peek());

        }
    }
}