using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //string MyName = "Jane";
            //byte MyAge = 27;
            //bool HaveIApet = true;
            //double MyShoeSize = 37.5;

            //Console.WriteLine("My name is " + MyName);
            //Console.WriteLine("MyAge " + MyAge);
            //Console.WriteLine("Do I have a pet? " + HaveIApet);
            //Console.WriteLine("My shoe size is " + MyShoeSize);

            ////перечисление
            //DaysOfWeek MyFavoriteDay;

            //MyFavoriteDay = DaysOfWeek.Friday;

            //Console.WriteLine(MyFavoriteDay);
            //for (int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine("Iteration {0}", i);
            //    switch (Console.ReadLine())
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;

            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;

            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is cyan!");
            //            break;
            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is yellow!");
            //            break;
            //    }
            //}
            //Console.WriteLine("Введите своё имя");

            //var name = Console.ReadLine();

            //Console.WriteLine("Ваше имя по буквам: ");

            //for (int i= name.Length-1; i>=0; i--)
            //{
            //    Console.Write(name[i] + " ");
            //}


            //Console.ReadKey();

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int temp;
            for (int i =0 ; i< arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                { 
                    if(arr[i]>arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                

            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }


        }
    }
        enum DaysOfWeek : byte
        {
            Tuesday,
            Monday,
            Wednesday,
            Friday
        }
    }
    
   

