// <copyright file="Program.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ItogovProject13
{
    /// <summary>
    /// Класс Program задание 1
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Определение коллекции List
        /// </summary>
        private static List<string> list = new List<string>();

        /// <summary>
        /// Определение коллекции LinkedList
        /// </summary>
        private static LinkedList<string> linkedlist = new LinkedList<string>();

        /// <summary>
        /// метод Main
        /// </summary>
        public static void Main()
        {
            try
            {
                string text = File.ReadAllText("c:/Users/User/Downloads/Text1.txt");

                var watchTwo = Stopwatch.StartNew();
                list.Add(text);
                Console.WriteLine($"Вставка в  List: {watchTwo.Elapsed.TotalMilliseconds}  мс");

                watchTwo = Stopwatch.StartNew();
                linkedlist.AddFirst(text);
                Console.WriteLine($"Вставка в  LinkedList: {watchTwo.Elapsed.TotalMilliseconds}  мс");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
