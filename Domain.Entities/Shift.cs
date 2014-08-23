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
     
    }
}
