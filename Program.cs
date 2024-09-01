using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Back_to_the_future_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int[] massiv = new int[10];
            //    Random random = new Random ();
            //    int sum =0;
            //    for(int i = 0; i<massiv.Length; i++)
            //    {
            //      massiv[i] = Convert.ToInt32(random.Next(1,10));
            //      System.Console.WriteLine("Numbers of massiv: " + massiv[i]);

            //         sum += massiv[i];
            // }
            // Console.Write("Sum: " + sum);



            // int[,] doublee = new int[,]
            // {
            //     {2,5,7},
            //     {8,4,6},
            //     {5,9,1}

            // };
            //for(int i = 0; i < 3; i++)
            //{

            //for(int j = 0; j < 3; j++)
            //{
            //  Console.Write(doublee[i,j] + "\t");
            //}
            //Console.WriteLine();
            //}
            // foreach(int i in doublee)
            // {
            //     Console.WriteLine(i + "\t");

            // }
            //Вывод приветсвия "Hello world" на экран
            // Console.WriteLine("Hello world");


                // Задание 2: Создай программу, которая запрашивает у пользователя его имя и возраст, 
                //а затем выводит приветствие с именем и возрастом пользователя.

                // string name;
                // byte age ;
                // System.Console.WriteLine("Write your name:");
                // name = Console.ReadLine();
                // System.Console.WriteLine("Write youre age: ");
                // age = Convert.ToByte(Console.ReadLine());
                // System.Console.WriteLine($"Your name: {name} and your age: {age}");


               // Задание 3: Реализуй программу, которая вычисляет сумму двух чисел, введённых пользователем.
               

            // double number1 = 0, number2 = 0;
            // System.Console.WriteLine("Write first number: ");
            // number1 = Convert.ToDouble(Console.ReadLine());
            // System.Console.WriteLine("Write the second number: ");
            // number2 = Double.Parse(Console.ReadLine());
            // double sum = number1 + number2;
            // Console.WriteLine($"sum of two nambers: {sum}");

            // byte datatype1 = 255;
            // sbyte datatype2 = 127;
            // short datatype3 = 32767;
            // ushort datatype4 = 65535;
            // int datatype5 = 2147483647;
            // uint datatype6 = 4294967295;
            // long datatype7 = 9223372036854775807;
            // ulong datatype8 = 18446744073709551615;
            // float datatype9 = 5.2f;
            // double datatype10 = 10000;
            // decimal datatype11 = 3.3m;
            // char datatype12 = 'r';
            // string datatype13 = "Symbols";
            // object datatype14 = 12;
            // object datatype15 = 1.5;
            // object datatype16 = "Any Types";
            // bool datatype17 = true;
            //  object[] alltypes = {datatype1, datatype2, datatype3, datatype4, datatype5, datatype6, datatype7, datatype8, datatype8, datatype9, datatype10, datatype11, datatype12, datatype13, datatype14, datatype15, datatype16, datatype17};
            //  foreach(var i in alltypes)
            //  {
            //     Print(i);
            //  }

            // int degree = 0;
            // int farenG = 0;

            // Print($"Write your degreed C0: )");
            // degree = Convert.ToInt32(Console.ReadLine());
            // farenG = (degree * 9/5) + 32;
            // Print($"Youre degree in Farengate: {farenG}F");
            

            // System.Console.WriteLine("Write your number so i can tell you if it's even or odd: ");
            // int number = Convert.ToInt32(Console.ReadLine());
            // if(number % 2 == 0)
            // {
            //     System.Console.WriteLine($"You number {number} is even");
            // }
            // else{
            //     System.Console.WriteLine($"You number {number} is odd");
            // }
                

            // System.Console.WriteLine("Write your year: ");
            // int year = Convert.ToInt32(Console.ReadLine());
            // if(year % 400 == 0 && year % 100 == 0 && year % 4 == 0)
            // {
            //     System.Console.WriteLine($"{year} Your year is Leap!");
            // }
            // else{
            //     System.Console.WriteLine($"{year} Is not Leap year!");
            // }


            // System.Console.WriteLine("Write your first number: ");
            //     int the_first = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine("Write your second number: ");
            //     int the_second = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine("Write your third number: ");
            //     int the_third = Convert.ToInt32(Console.ReadLine());

            // if(the_first > the_second && the_first > the_third)
            // {
            //  Print($"The largest number is {the_first}");
            // }
            // else if(the_second > the_first && the_second > the_third)
            // {
            //     System.Console.WriteLine($"The largest number is {the_second}");
            // }    
            // else{
            //     Print($"The largest number is {the_third}");
            // }
        

            
            //  for(int i = 0; i <= 100; i++)
            //  {
            //     Print(i);
            //  }


        //     System.Console.WriteLine("Write your number: ");
        //     byte table = Convert.ToByte(Console.ReadLine());
            
        //     if(table == 1)
        //     {
        //         for(int i = 1; i <= 10; i++)
        //         {
        //             int one = 1;
        //             System.Console.WriteLine($"{one}X{i}: " + one * i);

        //         }
        //     }
        //     else if(table == 2)
        //     {
        //         for(int i = 1; i <= 10; i++)
        //         {
        //             int two = 2;
        //             Print($"{two}X{i}: " + two * i);
        //         }       
        //     }

        //    else if(table == 3)
        //     {
        //         for(int i = 1; i <= 10; i++)
        //         {
        //             int three = 3;
        //             Print($"{three}X{i}: " + three * i);
        //         }       
        //     }
        //     else if(table == 4)
        //     {
        //         for(int i = 1; i <= 10; i++)
        //         {
        //             int four = 2;
        //             Print($"{four}X{i}: " + four * i);
        //         }       
        //     }
        //     else if(table == 5)
        //     {
        //         for(int i = 1; i <= 10; i++)
        //         {
        //             int five = 5;
        //             Print($"{five}X{i}: " + five * i);
        //         }       
        //     }
        //     else if(table == 6)
        //     {
        //         for(int i = 1; i <= 10; i++)
        //         {
        //             int six = 6;
        //             Print($"{six}X{i}: " + six * i);
        //         }       
        //     }
        //     else if(table == 7)
        //     {
        //         for(int i = 1; i <= 10; i++)
        //         {
        //             int seven = 7;
        //             Print($"{seven}X{i}: " + seven * i);
        //         }       
        //     }
        //     else if(table == 8)
        //     {
        //         for(int i = 1; i <= 10; i++)
        //         {
        //             int eight = 8;
        //             Print($"{eight}X{i}: " + eight * i);
        //         }       
        //     }
        //     else if(table == 9)
        //     {
        //         for(int i = 1; i <= 10; i++)
        //         {
        //             int nine = 9;
        //             Print($"{nine}X{i}: " + nine * i);
        //         }       
        //     }
        // }
        //  public static void Print(object print)
        //  {
        //          System.Console.WriteLine(print);
        //  }

        // int i = 1;
        // int fact = 1;
        //     Console.WriteLine("Write your NUMBER: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // while(i <= number)
        // {
        //     fact *= i;
        //     i++;
        // }
        // System.Console.WriteLine(fact);
        

        // int counter = 0;
        // int number = 0;
        // System.Console.WriteLine("Write youre number: ");
        // number =  Convert.ToInt32(Console.ReadLine());
        // for(int i = 0; i <= number; i++)
        // {
        //     counter += i;
            
        // }
        // System.Console.WriteLine(counter);

        // int number = 0;
        // int counter = 1;
        // System.Console.WriteLine("Write your number: ");
        // number = Convert.ToInt32(Console.ReadLine());
        // for(int i = 1; i <=number; i++)
        // {
        //     counter *= i;

        // }
        // System.Console.WriteLine($"Your factorial: "+ counter);

        // int number = 0;
        // System.Console.WriteLine("Write your number to show all odd numbers: ");
        // number = Convert.ToInt32(Console.ReadLine());
        // if (number%2 == 0)
        // {
        //     for(int i = 1; i <= number; i++)
        //     {
        //         if(i % 2 == 0)
        //         System.Console.WriteLine(i);
        //     }

        // }
        // else{
        //     for(int i = 1; i <= number; i++)
        //     {
        //         if(i % 2 != 0)
        //         System.Console.WriteLine(i);
        //     }
        // }


        // int number = 0;
        // System.Console.WriteLine("Write your number: ");
        // number = Convert.ToInt32(Console.ReadLine());
        // switch (number)
        // {
        //     case 1:
        //     for(int i = 1; i <= 10; i++)
        //     {
            
        //        Console.WriteLine($"{number} * {i} = {i * number}");

        //     }
        //     break;
        //     case 2:
        //     for(int i = 1; i <= 10; i++)
            

        //     {
        //        Console.WriteLine($"{number} * {i} = {i * number}");
        //     }

        //     break;
            
        //     case 3:
        //     for(int i = 1; i <= 10; i++)
            

        //     {
        //        Console.WriteLine($"{number} * {i} = {i * number}");
        //     }

        //     break;
        //     case 4:
        //     for(int i = 1; i <= 10; i++)
            

        //     {
        //        Console.WriteLine($"{number} * {i} = {i * number}");
        //     }

        //     break;
        //     case 5:
        //     for(int i = 1; i <= 10; i++)
            

        //     {
        //        Console.WriteLine($"{number} * {i} = {i * number}");
        //     }

        //     break;
        //     case 6:
        //     for(int i = 1; i <= 10; i++)
            

        //     {
        //        Console.WriteLine($"{number} * {i} = {i * number}");
        //     }

        //     break;
        //     case 7:
        //     for(int i = 1; i <= 10; i++)
            

        //     {
        //        Console.WriteLine($"{number} * {i} = {i * number}");
        //     }

        //     break;
        //     case 8:
        //     for(int i = 1; i <= 10; i++)
            

        //     {
        //        Console.WriteLine($"{number} * {i} = {i * number}");
        //     }

        //     break;
        //     case 9:
        //     for(int i = 1; i <= 10; i++)
            

        //     {
        //        Console.WriteLine($"{number} * {i} = {i * number}");
        //     }

        //     break;
        //     case 10:
        //     for(int i = 1; i <= 10; i++)
            

        //     {
        //        Console.WriteLine($"{number} * {i} = {i * number}");
        //     }

        //     break;
        //     }
        
        }
        
    }
}
        