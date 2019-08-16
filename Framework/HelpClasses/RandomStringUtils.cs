using System;
using System.Linq;
using System.Text;

namespace AutomationPractice
{
    public class RandomStringUtils
    {
        #region Tego nie uzylem, ale obczaic na przyszlosc
        //private static Random random = new Random();

        //public static string RandomString(int length)
        //{
        //    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
        //    return new string(Enumerable.Repeat(chars, length)
        //        .Select(s => s[random.Next(s.Length)]).ToArray());
        //}

        ////public String generateEmail(int length)
        ////{
        ////    String allowedChars = "abcdefghijklmnopqrstuvwxyz" +   //alphabets
        ////            "1234567890";   //numbers

        ////    String email = "";
        ////    String temp = RandomString.random(length, allowedChars);
        ////    email = temp.substring(0, temp.length() - 9) + "@test.org";
        ////    return email;
        ////}
        #endregion

        public static string RandomEmail()
        {
            RandomGenerator generator = new RandomGenerator();

            string str = generator.RandomString(10, false) + "@" + generator.RandomString(3, false) + ".com";

            return str;
        }
    }

    public class RandomGenerator
    {
        // Generate a random number between two numbers    
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // Generate a random string with a given size    
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        // Generate a random password    
        public string RandomPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
    }
}
