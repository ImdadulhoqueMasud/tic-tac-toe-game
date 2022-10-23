using System;
namespace Task1
{
    class AddTwoNumber
    {
        static void Main()
        { 
            Console.Write("1st Numer :");
            double fistNumer = Convert.ToDouble( Console.ReadLine());
            Console.Write("2nd Numer :");
            double secendNumber=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Show the\n1st Number:" + fistNumer+ "\n2nd Numer: " +secendNumber);
            int convertFisrtNmber = Convert.ToInt32(fistNumer);
            Console.WriteLine("convert the input number: ");
            Console.WriteLine("convert 1st input: " +convertFisrtNmber);
           int convertSecendNmber = Convert.ToInt32(secendNumber);
            Console.WriteLine("convert 2nd input: " + convertSecendNmber);
            Console.WriteLine("add to number : ");
            int result = (convertFisrtNmber + convertSecendNmber);
             Console.WriteLine(convertFisrtNmber + "+"+ convertSecendNmber + "=" + result);
        }
    }
}
