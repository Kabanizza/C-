using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Globalization;
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


        // int number = 0;
        // int count = 0;
        // System.Console.WriteLine("Wite yoor number and i show you is sum odd numbers: ");
        // number = Convert.ToInt32(Console.ReadLine());
        // for(int i = 0; i <= number; i++)
        // {
        //     if(i %2 != 0)
        //     {
        //         System.Console.WriteLine(i);
        //         count += i;
        //     }
        // }
        // System.Console.WriteLine(count);
        // }
        

        // int number =0;
        // System.Console.WriteLine("write your number and i show you all numbers which are devided: ");
        // number = Convert.ToInt32(Console.ReadLine());
        // for(int i = 0;i <= number; i++)
        // {
        //     if (i % 7 == 0 && i % 3  != 0)
        //     {System.Console.WriteLine((i));

        //     }
        // }

        // int i = 0;
        // int number = 0;
        // double counter = 0;
        // System.Console.WriteLine("Please, write your number:) ");
        // number = Convert.ToInt32(Console.ReadLine());
        
        // for(i = 0; i <= number; i++)
        // {
        //     counter = Math.Pow(i, 2);
        //         System.Console.WriteLine($"{number}^2 = {counter}");
        // }

        // int i = 0;
        
        // int number = 0;
        // System.Console.WriteLine("write your number: ");
        // number = Convert.ToInt32(Console.ReadLine());
        // for(i = 1; i <=number; i++)
        // {
        //     if(number % i == 0)
        //     {
        //         Console.WriteLine(i);
        //     }
            
        //     }
            
        // }

        // int i = 0;
        // int number = 0;
        // int counter = 0;
        // System.Console.WriteLine("Write your number: ");
        // number = Convert.ToInt32(Console.ReadLine());
        // for(i = number-1; i >= 0; i--)
        // {
        //     Console.WriteLine(i);
        // }
        

        // int number = 0;
        // double counter = 0;
        // int i = 0;
        // System.Console.WriteLine("Write your number: ");
        // number = Convert.ToInt32(Console.ReadLine());
        // while(i <= number)
        // {
        //     counter = Math.Pow(2,i);
        //     if(counter <= number)
        //     {
        //         Console.WriteLine(counter);
        //     }
        //     i++;
            
        // }


        // int counter = 0;
        // int count = 0;
        // int number = Convert.ToInt32(Console.ReadLine());
        // if(number == 0)
        // {
        //     counter = 1;
        // }
        // else{
        //     for(counter = 1; counter <= number; counter++)
        // {
        //     number /=10;
            
        // }
        // }
        // count = counter;
        // System.Console.WriteLine("Количество цифр: " + count);
       

                    // Amstrong Number
    //    int AmstrongNumber = 0;
    //     int number = 0;
    //     int sum = 0;
    //     int counter = 0;
    //     System.Console.WriteLine("Write your number and i will do the math whether it is number, number of Amstrong or not: ");
    //     number = Convert.ToInt32(Console.ReadLine());
    //     int savenumber = number;
    //     int fornumber = number;
    //     for(int i = number; i > 0; counter++)
    //         {
    //             i /= 10;
    //         }
            
    //         System.Console.WriteLine(counter);
            
    //     while(number > 0)
    //     {
            
            
           
    //       AmstrongNumber = number % 10; 
    //       sum += (int)Math.Pow(AmstrongNumber,counter);
          

    //       number /=10;

         
    //     }
       
    //     if(sum == savenumber)
    //     {
    //         System.Console.WriteLine($"{sum} is an Amstrong number ");
    //     }
    //     else {
    //         System.Console.WriteLine($"{sum} is not an Amstrong number");
    //     }
        


        // int UserNumber = 0;
        //  System.Console.WriteLine("write your number and i will check all the deviders: ");
        //  UserNumber = Convert.ToInt32(Console.ReadLine());
        //  for(int i = 1; i <= UserNumber; i++)
        //  {
        //     if(UserNumber %i == 0)
        //     {
        //         System.Console.Write(" " + i);
        //     }
        //  }


        // int NumberUser = 0;
        // bool TorF = true;
        // int counter = 0;
        // System.Console.WriteLine("Write youre number and i will check to see if it is number simple or not: ");
        // NumberUser = Convert.ToInt32(Console.ReadLine());
        // for(int i = 2; i < NumberUser; i++)
        // {
            
        //     if(NumberUser % i == 0 )
        //     {z
                
        //         TorF = false;
        //         break;
                
        //     }
            
            
        // }
        // if(TorF)
        // {
        //     System.Console.WriteLine($"{NumberUser} it is a simpl");

        // }

        // else{
        //     System.Console.WriteLine($"{NumberUser} it is not a simpl");
        // }
        

        // int number = 0;
        // int numbertwo = 0;
        // int count = 0;
        // number = Convert.ToInt32(Console.ReadLine());

        
        // for(int i = number; i > 0; i /= 10)
        //     {
        //         numbertwo= i % 10;
        //         System.Console.Write(numbertwo);
        //     }
            


                    //Faktorial
            // int NumberFromUser = 0;
            // System.Console.WriteLine("Wrtite: ");
            // double count = 1;
            
            // NumberFromUser = Convert.ToInt32(Console.ReadLine());

            // for(int i = 1; i <= NumberFromUser; i++)
            // {
            //   count *= i; 
             
            // }
            // System.Console.WriteLine(count);


            // int NumberFromUser = 0;
            // int sum = 0;
            // int counter = 0;
            // System.Console.WriteLine("Write number: ");
            // NumberFromUser = Convert.ToInt32(Console.ReadLine());
            // for(int i = NumberFromUser; i > 0; i /= 10)
            // {
            //     counter = i % 10;
            //     sum += counter;
                
            // }
            // System.Console.WriteLine(sum);

            // int SizeOFArray = 0;
            // System.Console.WriteLine("Write your size of Array: ");
            // SizeOFArray = int.Parse(Console.ReadLine());
            // int[] Array = new int[5];

            // for(int j = 0; j < Array.Length; j++)
            // {
            //     System.Console.Write($"Write your number int this {j} index:\t ");
            //     Array[j] = int.Parse(Console.ReadLine());
            // } 

            // for(int i = 0; i < Array.Length; i++)
            //     {
            //         System.Console.WriteLine(Array[i]);
            //     }          

            // int SizeArray = 0;
            // System.Console.Write("Write you size of Array: ");
            // SizeArray = Convert.ToInt32(Console.ReadLine());
            // int[] MyArray = new int[SizeArray];
            // int max = 0;
            // System.Console.WriteLine($"Fill in your number Array: ");
            // for(int i = 0; i < MyArray.Length; i++)
            // {
                
            //     MyArray[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // for(int j = 0; j < MyArray.Length; j++)
            // {
            //     if(max < MyArray[j]){
            //         max = MyArray[j];
            //     }
            // }
            
            // System.Console.WriteLine(max);
            

            // System.Console.Write("Write size of Array: ");
            // int SizeArray = 0;
            // SizeArray = Convert.ToInt32(Console.ReadLine());
            // int[] RandomArray = new int [SizeArray];
            // Random numbers = new Random();
            // int counter = 0;
            // for(int i = 0; i < RandomArray.Length; i++)
            // {
                
            //     RandomArray[i] = numbers.Next(10);
            // }
            
            // for(int j = 0; j < RandomArray.Length; j++)
            // {
            //     counter += RandomArray[j];
            //     System.Console.Write(" " + RandomArray[j]);
            // }
            // System.Console.WriteLine("\n" + counter);



            // System.Console.Write("Write size of Array: ");
            // int SizeArray = Convert.ToInt32(Console.ReadLine());
            // int[] ArrayNum = new int[SizeArray];
            // int count = 0;
            // for(int i = 0; i < ArrayNum.Length; i++)
            // {
            //     ArrayNum[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // for(int j = 0; j < ArrayNum.Length; j++)
            // {
            //     if(ArrayNum[j] % 2 == 0)
            //     {
            //         count++;
            //     }
            // }
            // System.Console.WriteLine(count);


//             4. Найти минимальный элемент и его индекс
// Создай программу, которая находит минимальный элемент массива и выводит его индекс.

                // System.Console.Write("Write your size of array: ");
                // int SizeOFArray = Convert.ToInt32(Console.ReadLine()); 
                // int[] ArrayNum = new int[SizeOFArray];
                // Random random = new Random();
                
                // int max = 0;
                // for(int i = 0; i < ArrayNum.Length; i++)
                // {
                //     ArrayNum[i] = Convert.ToInt32(Console.ReadLine());
                // }
                // for(int j = 0; j < ArrayNum.Length; j++)
                // {
                //     System.Console.WriteLine(ArrayNum[j]);
                //    if(max < ArrayNum[j])
                //    {
                //     max = ArrayNum[j];
                //    }
                //    int SaveArray = ArrayNum[j];
                // }
                // int min = ArrayNum[0];
                // int Index = 0;
                // for(int l = 0; l < ArrayNum.Length; l++)
                // {
                //     if(min > ArrayNum[l])
                //     {
                //         Index = l;
                //         min = ArrayNum[l];
                //     }
                // }
                // System.Console.WriteLine("min element: " + min + "Index: " + Index);
                // System.Console.WriteLine("max elemenets: " + max);


               // Обратить порядок элементов массива
                //Напиши программу, которая меняет порядок всех элементов в массиве на обратный (реверс массива).
                // System.Console.WriteLine("Write number for size of Array: ");
                // int SizeOfArray = Convert.ToInt32(Console.ReadLine());
                // int[] MyArray = new int[SizeOfArray];
                // System.Console.Write("Write numbers of Array: ");
                // for(int i = 0; i < MyArray.Length; i++)
                // {
                //     MyArray[i] = Convert.ToInt32(Console.ReadLine());
                // }
                // System.Console.WriteLine("______________________________-");
                // for (int i = 0; i < MyArray.Length / 2; i++)
                //     {
                //     int temp = MyArray[i]; // Сохраняем текущее значение во временную переменную
                //     MyArray[i] = MyArray[MyArray.Length - 1 - i]; // Меняем местами с элементом с конца
                //     MyArray[MyArray.Length - 1 - i] = temp; // Присваиваем сохранённое значение в конец
                //     }


                // for(int j = 0; j < MyArray.Length; j++)
                // {
                //     System.Console.WriteLine(MyArray[j]);
                // }
                 

                 //Проверить, является ли массив палиндромом

                // System.Console.Write("Write your size of massiv; ");
                //  int SizeArray = Convert.ToInt32(Console.ReadLine());
                //  int[] MyArray = new int[SizeArray];
                //  int[] CoppyArray = new int[SizeArray];
                //  System.Console.WriteLine("Write numbers of ur array: ");
                //  for(int i = 0; i < MyArray.Length; i++)
                //  {
                //     MyArray[i] = Convert.ToInt32(Console.ReadLine());

                //  }

                 
                //  for(int q = 0; q < MyArray.Length; q++)
                //  {
                //     CoppyArray[q] = MyArray[q];
                //  }

                //   for(int j = 0; j < MyArray.Length / 2; j++)
                //   {
                //     int temp = MyArray[j];                          // Revers of Array
                //     MyArray[j] = MyArray[MyArray.Length - 1 - j];
                //     MyArray[MyArray.Length - 1 - j] = temp;
                //   }
                //     System.Console.WriteLine("The first Array: ");
                //   foreach(int The_First in CoppyArray)
                //   {
                //     System.Console.Write(" " + The_First);
                //   }
                //     System.Console.WriteLine("\nThe second Array: ");
                //   foreach(int The_Second in MyArray)
                //   {
                //     System.Console.Write(" " + The_Second);
                //   }

                //     int number = 0;
                //   for(int e = 0; e < MyArray.Length; e++)
                //   {

                  
                //     if(MyArray[e] == CoppyArray[e])
                //     {
                //         number = 1;
                //     }
                //     else{
                //         number = 2;
                //     }

                //   }
                //   if(number == 1)
                //   {
                //     System.Console.WriteLine("\nArray is palindrom");
                //   }
                //   if(number == 2)
                //   {
                //     System.Console.WriteLine("\nArray is not palindrom");

                //   }


                // Переместить нули в конец массива


                // int SizeOfArray;
                // int ccounter = 0;
                // Console.Write("Write size of array: ");
                // int[] MyArray = new int[SizeOfArray = Convert.ToInt32(Console.ReadLine())];
                // System.Console.WriteLine("Write number of Array: ");
                // for(int i = 0; i < MyArray.Length; i++)
                // {
                //     ccounter++;
                //     System.Console.Write($"Write the {ccounter} number: ");
                //     MyArray[i] = Convert.ToInt32(Console.ReadLine());
                    
                // }
                // int counterOfArray = 0;
                // for(int i = 0; i < MyArray.Length; i++)
                // {
                //     if(MyArray[i] != 0)
                //     {
                //         MyArray[counterOfArray] = MyArray[i];
                //         counterOfArray++;
                //     }
                // }
                // for(int i = counterOfArray; i < MyArray.Length; i++)
                // {
                //     MyArray[i] = 0;
                // }
                // foreach(int i in MyArray)
                // {
                //     System.Console.Write(i + " ");
                // }

                //  Сдвиг элементов массива на заданное количество позиций
                 
            //     int SizeOFArray;
            //     System.Console.Write("Write your array size: ");
            //     int[] MyArray = new int[SizeOFArray = Convert.ToInt32(Console.ReadLine())];
            //     System.Console.WriteLine("Write your shift: ");
            //     int Shift = Convert.ToInt32(Console.ReadLine());
            //     System.Console.WriteLine("Write the numbers of your array: ");
            //     for(int i = 0; i < MyArray.Length; i++)
            //     {
            //         MyArray[i] = Convert.ToInt32(Console.ReadLine());
            //     }
                
            //     for(int i = 0; i < MyArray.Length / 2; i++)
            //     {
            //       int temp = MyArray[i];
            //       MyArray[i] = MyArray[MyArray.Length - 1 - i];
            //      MyArray[MyArray.Length - 1 - i] = temp;
            //     }
            //     for(int j = 0; j < (MyArray.Length - Shift) / 2; j++)
            //     {
            //         int temp = MyArray[j];
            //         MyArray[j] = MyArray[(MyArray.Length - Shift) - 1 -j];
            //         MyArray[(MyArray.Length - Shift) - 1 - j] = temp;
            //     }

            //     for(int k = 0; k < Shift / 2; k++)
            //     {
            //         int temp = MyArray[MyArray.Length - Shift + k];
            //         MyArray[MyArray.Length - Shift + k] = MyArray[MyArray.Length - 1 - k];
            //         MyArray[MyArray.Length - 1 - k] = temp;

            //     }



            // foreach(int i in MyArray)
            //     {
            //         System.Console.Write(" " + i);
            //     }


            int sum = 0;
            int[] Myarray = new int[5]{1, 2, 3, 4, 5};
            foreach(int i in Myarray)
            {
                sum = sum + i;
            }
            System.Console.WriteLine(sum);
            System.Console.WriteLine("Hello");

             
                 
            
        
    }

        

    }}

        
      