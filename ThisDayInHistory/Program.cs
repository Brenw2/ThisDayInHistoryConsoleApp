using System;

namespace ThisDayInHistory
{
    class Program
    {
        static void Main(string[] args)
        {
           var client = new TwitterApiClient();

           var model = client.GetTodaysHistoricalEvents().Result;
            foreach (var events in model.Data.Events)
            {
               Console.WriteLine("Year: " + events.Year + " What Happened: "+ events.Text); 
            }

            Console.ReadKey();
        }
    }
}
