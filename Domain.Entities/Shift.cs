using System;
using System.Collections.Generic;


namespace ShiftSchedule.Domain.Entities
{
    enum ShiftDesc
    {
        Morning = 0,
        Evening = 1,
        Night = 2
    }

    public class Shift
    {
        private string Name; //Morning,Evening or other (
        private DayOfWeek Day;
        private TimeSpan Started { get; set; }
        private TimeSpan Ended { get; set; }

        public Shift(string name, DayOfWeek day, TimeSpan started, TimeSpan ended)
        {
            Name = name;
            Day = day;
            Started = started;
            Ended = ended;
        }

        public TimeSpan GetDuration()
        {
            return (Ended.Subtract(Started));
        }
    }
}

    
