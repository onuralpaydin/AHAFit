using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_Data
{
    public class MemberFood
    {
        public MemberFood()
        {
            this.CreateDateTime = DateTime.Now;
        }

        public MemberFood(DateTime CreateTime)
        {
            this.CreateDateTime = CreateTime;
        }

        public int MemberFoodId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int MemberId { get; set; }
        public int FoodId { get; set; }
        public Member Member { get; set; }
        public Food Food { get; set; }

    }
}
