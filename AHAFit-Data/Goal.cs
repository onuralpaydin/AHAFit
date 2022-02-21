using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_Data
{
    public class Goal
    {
        public int GoalId { get; set; }
        public string Name { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}
