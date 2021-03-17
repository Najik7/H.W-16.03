using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace H.W_16._03
{
    class Program
    {
        private static string spl;

        static void Main(string[] args)
        {
            //1
            string word = "hello";
            string newWord = string.Join(" ", word.Select(x => (x == 'a') ? '1' : (x == 'e') ? '2' : (x == 'i') ? '3' : (x == 'o') ? '4' : (x == 'u') ? '5' : x));

            foreach (var item in newWord)
            {
                Console.Write(item);
            }
            Console.WriteLine($"\n");

            //2
            string text = "h3 th2r2";
            string NText = string.Join("", text.Select(x => (x == '1') ? 'a' : (x == '2') ? 'e' : (x == '3') ? 'i' : (x == 4) ? 'o' : (x == 5) ? 'u' : x));
            foreach (var item in NText)
            {
                Console.Write(item);
            }
            Console.WriteLine($"\n");


            //3
            //spl = string.Join(null, Regex.Split(word, "[^0-9-*-/-+-]"));
            //spl.Split('*');
            //Console.Write(spl);
            //Console.WriteLine();



            //4
            //string[] Sumbol = new string[] { "+", "-", "*", "/" };
            //var TextQuery = new string((from ch in Console.ReadLine()
            //                            where Char.IsDigit(ch) || ch == '+' || ch == '-' || ch == '*' || ch == '/'
            //                            select ch).ToArray());
            //string sumbol = Sumbol.FirstOrDefault(S => TextQuery.Contains(S));
            //int Arg1 = int.Parse(new string(TextQuery.TakeWhile(ch => ch.ToString() != sumbol).ToArray()));
            //int Arg2 = int.Parse(new string(TextQuery.Reverse().TakeWhile(s => s.ToString() != sumbol).Reverse().ToArray()));
            //int result = 0;
            //switch (sumbol)
            //{
            //    case "+":
            //        {
            //            result = Arg1 + Arg2;
            //        }
            //        break;
            //    case "-":
            //        {
            //            result = Arg1 - Arg2;
            //        }
            //        break;
            //    case "*":
            //        {
            //            result = Arg1 * Arg2;
            //        }
            //        break;
            //    case "/":
            //        {
            //            result = Arg1 / Arg2;
            //        }
            //        break;
            //}
            //Console.WriteLine(result.ToString());






        }
    }
}
