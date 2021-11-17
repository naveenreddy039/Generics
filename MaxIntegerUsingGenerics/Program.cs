using System;

namespace MaxIntegerUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first max number:");
            int output = MaxNumberCheck.MaxIntegerNumber(22, 33, 11);
            Console.WriteLine(output);

            Console.WriteLine("second max floatNumber:");
            double output2 = MaxNumberCheck.MaxIntegerNumber(11.1, 22.2, 33.3);
            Console.WriteLine(output2);

            Console.WriteLine("first max string:");
            string output3 = MaxNumberCheck.MaxIntegerNumber("hello","reddy","naveen");
            Console.WriteLine(output3);
        }
    }
}
