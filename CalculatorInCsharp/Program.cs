using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInCsharp
{
}
    class Program
    {
        static void Main(string[] args)
        {
           Beginning:
            int firstnumber;
            int secondnumber;
            string opeation;
            string exitorreturn;

            Console.WriteLine("CALCULATOR CRATING BY HASSAN ARSHAD");

            //firt number enter krwany k lye
            Console.Write("Enter First Number: \t");
            firstnumber = Convert.ToInt32(Console.ReadLine()); // ye lazmi convert hoga q k string sy int ma change krna ha

            //ye already string ma ha so isko convert krny ki zrort ni
            Console.Write("Select an Operation: \t");
            opeation = Console.ReadLine();
            //isko b firstnumber ki trah convert kr k likhna ha
            Console.Write("Enter Second Number: \t");
            secondnumber = Convert.ToInt32(Console.ReadLine());

            switch (opeation)
            {


                case "+":
                    Console.WriteLine("The Result is=\t" + (firstnumber + secondnumber));
                    Console.WriteLine();
                    Console.WriteLine("Exit / Return");
                    exitorreturn = Console.ReadLine();
                    switch (exitorreturn)
                    {
                    //return r exit k lye

                    case "Return":
                            Console.Clear();
                        goto Beginning;
                    default:
                        break;
                    }
                break;

                // - k lye
            case "-":
                Console.WriteLine("The Result is=\t" + (firstnumber - secondnumber));
                Console.WriteLine();
                Console.WriteLine("Exit / Return");
                exitorreturn = Console.ReadLine();
            switch (exitorreturn){
                    //return r exit k lye
                    case "Return":
                        Console.Clear();
                        goto Beginning;
                    default:
                        break;
                }
                break;
            case "*":
                Console.WriteLine("The Result is=\t" + (firstnumber * secondnumber));
                Console.WriteLine();
                Console.WriteLine("Exit / Return");
                exitorreturn = Console.ReadLine();
                switch (exitorreturn)
                {
                    //return r exit k lye
                    case "Return":
                        Console.Clear();
                        goto Beginning;
                    default:
                        break;
                }
                break;
            case "/":
                Console.WriteLine("The Result is=\t" + (firstnumber / secondnumber));
                Console.WriteLine();
                Console.WriteLine("Exit / Return");
                exitorreturn = Console.ReadLine();
                switch (exitorreturn)
                {
                    //return r exit k lye
                    case "Return":
                        Console.Clear();
                        goto Beginning;
                    default:
                        break;
                }
                break;
            case "%":
                Console.WriteLine("The Result is=\t" + (firstnumber & secondnumber));
                Console.WriteLine();
                Console.WriteLine("Exit / Return");
                exitorreturn = Console.ReadLine();
                switch (exitorreturn)
                {
                    //return r exit k lye
                    case "Return":
                        Console.Clear();
                        goto Beginning;
                    default:
                        break;
                }
                break;
            default:
                Console.WriteLine("You Have Selecte Incorrect Operation !");
                break;
        }



            Console.ReadKey(); // screen pr display ko rokny k lye

        }
    }

