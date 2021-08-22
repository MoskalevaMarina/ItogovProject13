// <copyright file="Program.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task2
{
    /// <summary>
    /// Класс Program задание 2
    /// </summary>
    public class Program
    {
        /// <summary>
        /// метод Main
        /// </summary>
        public static void Main()
        {
            try
            {
                string text = File.ReadAllText("c:/Users/User/Downloads/Text1.txt");

                var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

                char[] delimiters = new char[] { ' ', '\r', '\n' };

                List<string> words = noPunctuationText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                words.Sort();

                Dictionary<string, int> dictionary = new Dictionary<string, int>();

                int i = 1, kol = 1;
                while (i < words.Count)
                {
                    if (words[i - 1] == words[i])
                    {
                        kol++;
                    }
                    else
                    {
                        dictionary.Add(words[i - 1], kol);
                        kol = 1;
                    }

                    i++;
                }

                var dictionarysort = dictionary.OrderByDescending(u => u.Value);

                Console.WriteLine("10 слов, чаще всего встречающиеся в тексте: ");
                int j = 0;
                foreach (var item in dictionarysort)
                {
                    Console.WriteLine(item.Key + " - количество повторений в тексте " + item.Value);
                    j++;
                    if (j == 10)
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
