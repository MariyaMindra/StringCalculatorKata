using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string query)
        {
            if (query == "") return 0;
            string[] numbers;
            char delimiter;
            if (query.StartsWith("//"))
            {
                delimiter = query.ToCharArray()[2];
                query = query.Substring(4);
            }
            else delimiter = ',';
            Console.WriteLine(query);
            numbers = query.Split(delimiter, '\n');
            if (numbers.Any(n => Convert.ToInt32(n) < 0)) throw new ArgumentException("negatives not allowed"); 
            int result = numbers.Where(n=>n!="").Select(n => Convert.ToInt32(n)).Sum();
            return result;

            
        }
        //private static string[] Parser(string query)
        //{
        //    Regex reg = new Regex("^//.");
        //    if (reg.Match(query).Success)
        //    {
                
        //    }
        //}
    }
}
