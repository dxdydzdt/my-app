using System;
using my_app.Date;

namespace my_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Date.Date date = Date.Date.getInstance();

            Console.WriteLine(date.getCurrentDate(null));
        }
    }
}
