﻿using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int Num = int.Parse(Console.ReadLine());
        int SecNum = Num;
        if (Num % 3 == 0)
        {
            int CounterOfDegree = 0;
            while ((Num % 3 == 0) && (Num != 1))
            {
                Num = Num / 3;
                Console.WriteLine(Num);
                CounterOfDegree += 1;
            }
            if (Num % 3 == 1 && Math.Pow(3, CounterOfDegree) == SecNum)
            {
                Console.WriteLine("Degree of 3");
            }
            else
            {
                Console.WriteLine("Not a degree of 3");
            }
        }
        else
        {
            Console.WriteLine("Not degree of 3");
        }
    }
}


//Другой вариант решения
//int num = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < num; i++)
//{
//    double degree = Math.Pow(3, i);
//    if (degree > num)
//    {
//        Console.WriteLine("Нет.");
//        break;
//    }
//    else if (num == degree)
//    {
//        Console.WriteLine("Да."); 
//        break;
//    }
//}