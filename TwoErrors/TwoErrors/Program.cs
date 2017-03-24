using System;
using static System.Console;

namespace TwoErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 13 denom = 0, result;
            int[] arryay = { 22, 33, 44, };

            try
            {
                result = array[num]; //IndexOutOfRange
                result = num / denom;  //DivideByZeroException
            }

            catch (DivideByZeroException error)
            {
                WriteLine("In first catch block:");
                WriteLine(error.Message);
            }
            catch (IndexOutOfRangeException error)
            {
                WriteLine("In second catch block:");
                WriteLine(error.Message);
            }
        }      
    }
}
