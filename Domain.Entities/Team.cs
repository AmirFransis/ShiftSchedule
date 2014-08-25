using System;


namespace ShiftSchedule.Domain.Entities
{
    public class Team
    {
        public string Name { get; set; } //NOC,Support,...

        public Team(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
