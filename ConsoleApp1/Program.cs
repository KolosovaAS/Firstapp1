﻿using System;

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

            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            //int temp;
            //for (int i =0 ; i< arr.Length; i++)
            //{
            //    for (int j = i+1; j < arr.Length; j++)
            //    { 
            //        if(arr[i]>arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }

            //(string name, string family, string log, int lenlog, bool yespet, double agepet, double ageuser, string[] arrcolor) anketa;
            //for (int k = 0; k < 3; k++)
            //{
            //    Console.Write("Введите имя: ");
            //    anketa.name = Console.ReadLine();
            //    Console.Write("Введите фамилию: ");
            //    anketa.family = Console.ReadLine();
            //    Console.Write("Введите логин: ");
            //    anketa.log = Console.ReadLine();
            //    anketa.lenlog = anketa.log.Length;
            //    Console.WriteLine("Есть ли у вас животные? Да или Нет");
            //    var result = Console.ReadLine();
            //    if (result == "Да")
            //    { anketa.yespet = true; }
            //    else
            //    { anketa.yespet = false; }
            //    Console.WriteLine("Введите возраст пользователя");
            //    anketa.ageuser = double.Parse(Console.ReadLine());
            //    anketa.arrcolor = new string[3];

            //    Console.WriteLine("Введите три любимых цвета пользователя");
            //    for (int i = 0; i < anketa.arrcolor.Length; i++)
            //    {
            //        anketa.arrcolor[i] = Console.ReadLine();
            //    }

            //    Console.ReadKey();

            //}
            var array = GetArrayFromConsole(10);
            var sortedarray = SortArray(array);
            ShowArray(array, true);

        }
        static int[] GetArrayFromConsole(int num=10)
        {
            var result = new int[num];
            

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;

        }
            static int[] SortArray(int [] result)
            {
                int temp = 0;
                for (int k = 0; k < result.Length; k++)
                {
                    for (int l = k + 1; l < result.Length; l++)
                    {
                        if (result[k] > result[l])
                        {
                            temp = result[k];
                            result[k] = result[l];
                            result[l] = temp;
                        }
                    }
                }

            
            for (int n = 0; n < result.Length; n++)
            {
                Console.WriteLine(result[n]);
            }
            return result;
            }
        static void ShowArray (int [] array, bool sort=false)
        {
            var temp = array;
            if (sort)
            {
                temp = SortArray(array);
                foreach (var item in temp)
                { Console.WriteLine(temp); }
            }
        }
        static void ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;

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
}
       
    
    
   

