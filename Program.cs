using System;
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



            int[,] doublee = new int[,]
            {
                {2,5,7},
                {8,4,6},
                {5,9,1}
            
            };
            //for(int i = 0; i < 3; i++)
            //{
            
                //for(int j = 0; j < 3; j++)
                //{
                  //  Console.Write(doublee[i,j] + "\t");
                //}
                //Console.WriteLine();
            //}
            foreach(int i in doublee)
            {
                System.Console.WriteLine(i + "\t");

            }

        }
    }
}