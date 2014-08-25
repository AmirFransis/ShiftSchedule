using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Services;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string intervalString, format;
            TimeSpan interval;
            CultureInfo culture;

            // Parse hour:minute value with "g" specifier current culture.
            intervalString = "17:14";
            format = "g";
            culture = CultureInfo.CurrentCulture;

            System.Console.WriteLine("Whats up Martin how many domains you handle?");
            int numOfDomains = Convert.ToInt32(Console.ReadLine());
            List<Team> domains = new List<Team>();
            int shifts_per_day = 0;
            List<Shift> shifts = new List<Shift>();
            for (int i = 0; i < numOfDomains; i++)
            {
                System.Console.WriteLine("Please enter domain {0} is name",i+1);
                string domain_name = System.Console.ReadLine();
                domains.Add(new Team(domain_name));
                System.Console.WriteLine("Please enter how many shift per day for domain: {0} is name",domains[i].Name);
                shifts_per_day = Convert.ToInt32(Console.ReadLine());
                //shifts_per_day.Add(shiftPerDay);
                for (int j = 0; j < shifts_per_day; j++)
                {
                    System.Console.WriteLine("Please enter when shift {0} started",j+1);
                    string started_shift = System.Console.ReadLine();
                    System.Console.WriteLine("Please enter when shift {0} ended",j+1);
                    string ended_shift = System.Console.ReadLine();
                    shifts.Add(new Shift("shift " + j + " ", DayOfWeek.Sunday, TimeSpan.ParseExact(started_shift, format, culture), TimeSpan.ParseExact(ended_shift, format, culture)));
                }
                
            }

            int numOfSchedule = shifts_per_day * domains.Count * 7;
            List<Schedule> schedules = new List<Schedule>();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < domains.Count; j++)
                {
                    for (int k = 0; k < shifts_per_day; k++)
                    {
                        schedules.Add(new Schedule(shifts[k], domains[j], new List<Employee>()));
                    }
                }
                
            }
            System.Console.ReadLine();


        }
    }
}
