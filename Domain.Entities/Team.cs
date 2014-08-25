using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSchedule.Domain.Entities
{
    public class Team
    {
        public string Name { get; set; } //NOC,Support,...

        public Team(string name)
        {
            Name = name;
        }
    }
}
