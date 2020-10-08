﻿using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> chemicalElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();

                foreach (var item in elements)
                {
                    chemicalElements.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", chemicalElements));
        }
    }
}
