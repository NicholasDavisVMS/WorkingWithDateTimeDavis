using System;

namespace WorkingWithDateTimeDavis
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Often you will be working with dates and times in your applications

            //The below date time will be the current date and time, which you can 
            //turn into a string
            DateTime myValue = DateTime.now;
            //Console.WriteLine(myValue.ToString());
            //Below will just return current date, not time, is localized
            //Console.WriteLine(myValue.ToShortDateTime());
            //Below will give just the time
            //Console.WriteLine(myValue.ToShortTimeString());
            //Below will give a nicely worded current date
            //Console.WriteLine(myValue.ToLongDateString());
            //Below will give the long time, with seconds
            //Console.WriteLine(myValue.ToLongTimeString());

            //Can also modify dates by using 'date math': add or subtract any part of the date
            //There are AddDays AddHours AddMilliseconds AddMinutes AddMonths, etc.
            //Below will add 3 days to date time
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //You can chain multiple methods to save considerable amount of typing
            //Console.WriteLine(myValue.AddHours(3).ToShortTimeString());
            //To subtracts days, etc. just use a negative number
            //Console.WriteLine(myValue.AddDays(-3).ToShortDateString());

            //Helper Methods that will help you retreive certain parts of dates or times
            //Below will retrieve just the month, helpful when trying to do complex time chuncks
            //There are a lot of things you can pull out of a datetime!!!
            //Console.WriteLine(myValue.Month.ToString());

            //You can pass in data into the datetime for a specific date: year, month, day
            //will print out correctly in a datetime if inputed correctly
            //DateTime myBirthday = new DateTime(1969, 12, 7);
            //Console.WriteLine(myBirthday.ToShortDateString());

            //Time is how to find difference/length between two dates in days
            DateTime myBirthday = DateTime.Parse("12/7/1969");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            //Note there is a lot not covered, what was were common usages of datetimes
            Console.ReadLine();                           
        }
    }
}
