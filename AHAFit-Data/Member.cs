using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_Data
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public decimal Weight { get; set; }
        public string Gender { get; set; }
        public int Height { get; set; }
        public DateTime BirthDate { get; set; }
        public int GoalId { get; set; }
        public Goal Goal { get; set; }
        public List<MemberFood> MemberFoods { get; set; }

    }
}
