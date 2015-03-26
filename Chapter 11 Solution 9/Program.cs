using System;

namespace Chapter_11_Solution_9
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2014, 12, 24),
                new DateTime(2014, 12, 25),
                new DateTime(2015, 01, 01),
                new DateTime(2015, 01, 02),
                new DateTime(2015, 03, 02),
                new DateTime(2015, 03, 03),
                new DateTime(2015, 04, 10),
                new DateTime(2015, 04, 13),
                new DateTime(2015, 05, 01),
                new DateTime(2015, 05, 06),
                new DateTime(2015, 09, 21),
                new DateTime(2015, 09, 22),
                new DateTime(2015, 12, 24),
                new DateTime(2015, 12, 25),
            };

            DateTime[] workSaturdays = new DateTime[]
            {
                new DateTime(2015, 01, 24),
                new DateTime(2015, 03, 21),
                new DateTime(2015, 09, 12),
                new DateTime(2015, 12, 12),
            };

            int workingDays = 0;

            Console.Write("Enter end date (YYYY/MM/DD): ");
            DateTime endDate = System.Convert.ToDateTime(Console.ReadLine());
            DateTime now = DateTime.Now;

            do
            {
                now = now.AddDays(1);

                if((now.DayOfWeek >= DayOfWeek.Monday) && (now.DayOfWeek <= DayOfWeek.Friday))
                    workingDays++;

                foreach (var i in holidays)
                    if (i.Date == now.Date)
                        workingDays--;

                foreach (var i in workSaturdays)
                    if (i.Date == now.Date)
                        workingDays++;

            } while (now.Date != endDate.Date);

            Console.WriteLine("{0} working days.", workingDays);
        }
    }
}
