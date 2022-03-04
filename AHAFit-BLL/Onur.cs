using System;
using AHAFit_Data;
using AHAFit_Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;

namespace AHAFit_BLL
{
    public class Onur
    {
        Context db = new Context();

        public List<Food> WeeklyHistoryLoader(int memberId)
        {
            
            List<MemberFood> memberFoodListWeek = new List<MemberFood>();
            List<Food> foodList = new List<Food>();

            for (int i = 0; i < 7; i++)
            {
                var baselineDate = DateTime.Now.AddHours(-24 * i);
                memberFoodListWeek = db.MembersFoods.Where(x => x.CreateDateTime >= baselineDate).ToList();
            }

           

           

            foreach (var item in memberFoodListWeek)
            {
                foodList.Add(db.Foods.FirstOrDefault(x => x.FoodId == item.FoodId));
            }

            return foodList;
        }


        public List<Food> MonthlyHistoryLoader(int memberId,int month)
        {
            List<MemberFood> memberFoodListMonth = new List<MemberFood>();
            List<Food> foodList = new List<Food>();

            memberFoodListMonth = db.MembersFoods.Where(x=>x.CreateDateTime.Month==month).ToList();
            foreach (var item in memberFoodListMonth)
            {
                foodList.Add(db.Foods.FirstOrDefault(x => x.FoodId == item.FoodId));
            }
            return foodList;


        }
    }
}
