using System;
using System.Collections.Generic;
using System.Text;

namespace MaxIntegerUsingGenerics
{
    public class MaxNumberCheck
    {
        public static int MaxIntegerNumber(int firstValue, int SecondValue, int thirdValue)
        {
            if (firstValue.CompareTo(SecondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (SecondValue.CompareTo(thirdValue) > 0 && SecondValue.CompareTo(firstValue) > 0)
            {
                return SecondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(SecondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstValue,secondValue,thirdValue");
        }
        public static double MaxIntegerNumber(double firstValue, double SecondValue, double thirdValue)
        {
            if (firstValue.CompareTo(SecondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (SecondValue.CompareTo(thirdValue) > 0 && SecondValue.CompareTo(firstValue) > 0)
            {
                return SecondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(SecondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstValue,secondValue,thirdValue");
        }
        public static string MaxIntegerNumber(string firstString, string SecondString, string thirdString)
        {
            if (firstString.CompareTo(SecondString) > 0 && firstString.CompareTo(thirdString) > 0)
            {
                return firstString;
            }
            if (SecondString.CompareTo(thirdString) > 0 && SecondString.CompareTo(firstString) > 0)
            {
                return SecondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(SecondString) > 0)
            {
                return thirdString;
            }
            throw new Exception("firstValue,secondValue,thirdValue");
        }
    }
}
