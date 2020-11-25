using System;

namespace my_app
{
    public class Program
    {
        public static string GetCurrentDate(string? format)
        {
            return DateTime.Now.ToString(format);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(GetCurrentDate(null));
        }
    }
}
