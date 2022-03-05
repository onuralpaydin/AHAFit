using System;
using AHAFit_Data;
using AHAFit_Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_BLL
{
    public class Onur
    {
        Context db = new Context();
        MemberFood memberFood = new MemberFood();
        Food food = new Food();


        //public List<Food> MostEatenFood(int memberId)
        //{
        //    List<MemberFood> memberFoodList = new List<MemberFood>();
        //    List<Food> foodList = new List<Food>();

        //    memberFoodList = db.MembersFoods.Where(x => x.MemberId == memberId).ToList();

        //    foreach (var item in memberFoodList)
        //    {
        //        foodList.Add(db.Foods.OrderByDescending(x => x.FoodId).Take(1).Where(x => x.FoodId == item.FoodId).FirstOrDefault());
        //    }

        //    return foodList;

        //}
        public Dictionary<string,int> MostEatenFood(int memberId)
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

        public List<MealFood> MealMostEatenFood(int memberId)
        {
            List<MemberFood> memberFoodList = new List<MemberFood>();
            List<MealFood> mealFoodList = new List<MealFood>();
            memberFoodList = db.MembersFoods.Where(x => x.MemberId == memberId).ToList();

            foreach (var item in memberFoodList)
            {
                mealFoodList.Add(db.MealsFoods.Where(x => x.MealId == item.MealId).FirstOrDefault());
            }

            return mealFoodList;
        }
    }
}
