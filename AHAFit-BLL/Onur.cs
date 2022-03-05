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
        public Dictionary<string, int> MostEatenFood(int memberId)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<int> foodIds = new List<int>();
            foreach (var memberFood in db.MembersFoods.Where(x => x.MemberId == memberId).ToList())
            {
                foodIds.Add(memberFood.FoodId);
            }
            var mostFoodId = foodIds.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
            var mostFoodCount = db.MembersFoods.Where(x => x.MemberId == memberId && x.FoodId == mostFoodId).Count();
            var foodName = db.Foods.FirstOrDefault(x => x.FoodId == mostFoodId).Name;
            dict.Add(foodName, mostFoodCount);
            return dict;
        }

        public Dictionary<string, int> MostEatenFoodBreakfast(int memberId)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<int> foodIds = new List<int>();
            foreach (var memberFood in db.MembersFoods.Where(x => x.MemberId == memberId && x.MealId == 1).ToList())
            {
                foodIds.Add(memberFood.FoodId);
            }
            var mostFoodId = foodIds.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
            var mostFoodCount = db.MembersFoods.Where(x => x.MemberId == memberId && x.FoodId == mostFoodId).Count();
            var foodName = db.Foods.FirstOrDefault(x => x.FoodId == mostFoodId).Name;
            dict.Add(foodName, mostFoodCount);
            return dict;
        }
        public Dictionary<string, int> MostEatenFoodLunch(int memberId)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<int> foodIds = new List<int>();
            foreach (var memberFood in db.MembersFoods.Where(x => x.MemberId == memberId && x.MealId == 2).ToList())
            {
                foodIds.Add(memberFood.FoodId);
            }
            var mostFoodId = foodIds.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
            var mostFoodCount = db.MembersFoods.Where(x => x.MemberId == memberId && x.FoodId == mostFoodId).Count();
            var foodName = db.Foods.FirstOrDefault(x => x.FoodId == mostFoodId).Name;
            dict.Add(foodName, mostFoodCount);
            return dict;
        }

        public Dictionary<string, int> MostEatenFoodDinner(int memberId)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<int> foodIds = new List<int>();
            foreach (var memberFood in db.MembersFoods.Where(x => x.MemberId == memberId && x.MealId == 3).ToList())
            {
                foodIds.Add(memberFood.FoodId);
            }
            var mostFoodId = foodIds.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
            var mostFoodCount = db.MembersFoods.Where(x => x.MemberId == memberId && x.FoodId == mostFoodId).Count();
            var foodName = db.Foods.FirstOrDefault(x => x.FoodId == mostFoodId).Name;
            dict.Add(foodName, mostFoodCount);
            return dict;
        }


    }
}
