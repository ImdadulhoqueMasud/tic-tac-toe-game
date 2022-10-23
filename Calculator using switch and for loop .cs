using System;

namespace Math;
class max
{
    static void Main(string[] args)
    {
        int secondNumber, firstNumber, result;
        Console.Write("Give 1st Number : ");
        firstNumber = Convert.ToInt32(Console.ReadLine());
       for (; ; ) { 
        Console.Write("Give 2nd Number : ");
        secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Select the operation : ");
        int selectNumber = Convert.ToInt32(Console.ReadLine());
        switch (selectNumber)
        {
            case 0:
                {
                    result = firstNumber + secondNumber;
                    Console.WriteLine(result);
                }
                break;
            case 1:
                {
                    result = firstNumber - secondNumber;
                    Console.WriteLine(result);
                }
                break;
            case 2:
                {
                    result = firstNumber * secondNumber;
                    Console.WriteLine(result);
                }
                break;
            case 3:
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine(result);
                }
                break;
            default:
                Console.WriteLine("END");
                break;
        }
        }
    }
}