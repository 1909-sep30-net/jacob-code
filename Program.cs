using System;

namespace HelloRevature
{
    public struct TestStruct
    {
        int x;

        public void init(int y = 0)
        {
            x = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestStruct f = new TestStruct();
            f.init();
            string b = "1";
            int a = int.Parse(b);
            Console.WriteLine(b);
        }
    }
}
