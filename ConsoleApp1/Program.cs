using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------//

            ////چاپ اعداد ۱ تا ۱۰۰ با حلقه فور
            //for (int counter = 0; counter < 1000; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            ////چاپ اعداد ۱ تا ۱۰۰ با حلقه وایل
            //int counter = 0;
            //while (counter<1000)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}
            //-------------------------------------------------------------------------//

            //فاکتوریل ۵
            //var factoriel5 = 1;
            //int counter = 1;
            //while (counter <= 5)
            //{

            //    factoriel5 *= counter;
            //    counter++;
            //    Console.WriteLine(factoriel5);
            //}

            //-------------------------------------------------------------------------//

            ////گرفتن عدد از کاربر و حساب کردن فاکتوریل ان عدد

            //Console.WriteLine("Enter Number : ");
            //var factorialn = 1;
            //var counter = 1;
            //var inputNumber = Convert.ToInt32(Console.ReadLine());
            //while (counter <= inputNumber)
            //{
            //    factorialn *= counter;
            //    counter++;
            //}
            //Console.WriteLine(factorialn);

            //-------------------------------------------------------------------------//

            ////ابتدا از کاربر تعداد دفعات جساب کردن فاکتوریل اعداد را گرفته و اعدادی که کاربر وارد میکند را فاکتوریل انها را حساب میکند با حلقه وایل

            //Console.WriteLine("How many times should I repeat? : ");
            //var maincounter = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //for (int j = 0; j < maincounter; j++)
            //{
            //    Console.WriteLine("Enter Number to calc factorial : ");
            //    var factorialn = 1;
            //    var counter = 1;
            //    var inputNumber = Convert.ToInt32(Console.ReadLine());
            //    while (counter <= inputNumber)
            //    {
            //        factorialn *= counter;
            //        counter++;
            //    }
            //    Console.WriteLine(factorialn);
            //}

            //-------------------------------------------------------------------------//


            ////ابتدا از کاربر تعداد دفعات جساب کردن فاکتوریل اعداد را گرفته و اعدادی که کاربر وارد میکند را فاکتوریل انها را حساب میکند با حلقه دو وایل

            //Console.WriteLine("Enter Count Of Factorial To Calc Factorial : ");
            //var mainCounterInputNumber = int.Parse(Console.ReadLine());
            //int mainCounter = 1;

            //do
            //{

            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine($"Enter Number {mainCounter} to calc factorial : ");
            //    var inputNumberToCalcFactorial = Convert.ToUInt32(Console.ReadLine());
            //    var factorial = 1;
            //    var counter = 1;
            //    while (counter <= inputNumberToCalcFactorial)
            //    {
            //        factorial *= counter;
            //        counter++;
            //    }
            //    Console.WriteLine(factorial);
            //    mainCounter++;


            //} while (mainCounter <= mainCounterInputNumber);

            //-------------------------------------------------------------------------//

            //// از کاربر میپرسد عدد .ارد کنید برای حساب کرد فاکتوریل و اگر نمیخواهید \"exit\" را وارد کنید 

            //Console.WriteLine("Enter Count Of Factorial To Calc Factorial : ");
            //Console.WriteLine("Enter \"exit\" if you don't want to continue");
            //var userInput = Console.ReadLine();

            //if (userInput == "exit")
            //{
            //    return;
            //}
            //else
            //{
            //    var inputNumberToCalcFactorial = Convert.ToUInt32(Console.ReadLine());
            //    var factorial = 1;
            //    var counter = 1;
            //    while (counter <= inputNumberToCalcFactorial)
            //    {
            //        factorial *= counter;
            //        counter++;
            //    }
            //    Console.WriteLine(factorial);
            //}

            //-------------------------------------------------------------------------//

            ////چاپ اعداد اول 

            //Console.WriteLine("2 Is Prim\n3 Is Prim\n5 Is Prim");
            //for (int number = 2; number < 50; number++)
            //{
            //    if ((number % (number / 2) != 0) && (number % 3 != 0) && (number % 5 != 0))
            //    {
            //        Console.WriteLine(number + " " + "Is Prim" );
            //    }
            //}
            //-------------------------------------------------------------------
            //var f = factoriel(5);
            //Console.WriteLine(f);

            //static int factoriel(int number)
            //{
            //    var inputNumberToCalcFactorial = Convert.ToUInt32(Console.ReadLine());
            //    var factorial = 1;
            //    var counter = 1;
            //    while (counter <= inputNumberToCalcFactorial)
            //    {
            //        factorial *= counter;
            //        counter++;
            //    }
            //    Console.WriteLine(factorial);
            //    mainCounter++;
            //}
            //return factoriel;

        }

    }
}

