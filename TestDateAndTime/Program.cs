using System;

namespace TestDateAndTime
{

    class MainClass
    {

        static void PlayWithDateTime()
        {
            Console.WriteLine("Playing with de DateTime object:\n");

            DateTime birthday = new DateTime(2018, 03, 18);
            Console.WriteLine("Birthday: {0}", birthday);

            DateTime tomorrow = birthday.AddDays(1);
            Console.WriteLine(tomorrow);

            DateTime yesterday = birthday.AddDays(-1);
            Console.WriteLine(yesterday);

            var now = DateTime.Now;
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }

        static void PlayWithTimeSpan()
        {
            Console.WriteLine("Playing with the TimeSpan object:\n");

            TimeSpan timeSpan = new TimeSpan(1, 2, 30);
            Console.WriteLine("timespan object: {0}", timeSpan);
            Console.WriteLine("Minutes in timespan object: {0}", timeSpan.Minutes);
            Console.WriteLine("Total minutes in timespan object: {0}", timeSpan.TotalMinutes);

            TimeSpan timeSpan2 = TimeSpan.FromHours(2);
            Console.WriteLine(timeSpan2);

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMinutes(2);
            TimeSpan duration = end - start;

            Console.WriteLine("Duration: {0}", duration);
        }

        public static void Main(string[] args)
        {
            PlayWithDateTime();
            PlayWithTimeSpan();
        }
    }
}
