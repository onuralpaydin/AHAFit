using AHAFit_Data;
using AHAFit_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_BLL
{
    public class MealFoodData
    {
        Context db = new Context();
        public void AddNewFood(string name, double calorie, double carbohydrate, double protein, double fat, string photoUrl, string foodType)
        {
            Food newFood = new Food();

            newFood.Name = name;
            newFood.Calorie = calorie;
            newFood.Carbohydrate = carbohydrate;
            newFood.Protein = protein;
            newFood.Fat = fat;
            newFood.PhotoURL = photoUrl;
            newFood.FoodType = foodType;

            db.Foods.Add(newFood);
            db.SaveChanges();
        }
        public List<Food> FindTheFood(string foodName)
        {
            List<Food> foodList = new List<Food>();

            foreach (var food in db.Foods.ToList())
            {
                if (food.Name.Contains(foodName))
                {
                    foodList.Add(food);
                }

            }

            return foodList;
        }
        public string FindFoodImageUrl(int foodId)
        {
            if (db.Foods.FirstOrDefault(x => x.FoodId == foodId) == null)
            {
                return "";
            }

            return db.Foods.FirstOrDefault(x => x.FoodId == foodId).PhotoURL;
        }
        public List<string> GetMeals()
        {
            List<string> meals = new List<string>();
            foreach (var item in db.Meals.ToList())
            {
                meals.Add(item.Name);
            }

            return meals;
        }
        public int FindMealId(string mealName)
        {
            return db.Meals.FirstOrDefault(x => x.Name == mealName).MealId;
        }
        public void FoodDelete(int foodId)
        {
            db.Foods.Remove(db.Foods.FirstOrDefault(x => x.FoodId == foodId));
            db.SaveChanges();
        }
        public Dictionary<string, int> MostEatenFood(int memberId, int daysBack, int mealId, string foodType)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<string, int> dict2 = new Dictionary<string, int>();
            List<int> foodIds = new List<int>();
            List<MemberFood> membersFoods = new List<MemberFood>();
            List<MemberFood> membersFoods2 = new List<MemberFood>();

            if (daysBack == 0 && mealId == 0 && foodType == "All Types")
            {
                membersFoods = db.MembersFoods.Where(x => x.MemberId == memberId).ToList();
                HelperMethod(1, membersFoods, membersFoods2, foodType);

            }
            else if (daysBack == 0 && mealId != 0 && foodType != "All Types")
            {
                membersFoods = db.MembersFoods.Where(x => x.MemberId == memberId && x.MealId == mealId).ToList();
                HelperMethod(2, membersFoods, membersFoods2, foodType);
            }
            else if (daysBack == 0 && mealId == 0 && foodType != "All Types")
            {
                membersFoods = db.MembersFoods.Where(x => x.MemberId == memberId).ToList();
                HelperMethod(2, membersFoods, membersFoods2, foodType);
            }
            else if (daysBack == 0 && mealId != 0 && foodType == "All Types")
            {
                membersFoods = db.MembersFoods.Where(x => x.MemberId == memberId && x.MealId == mealId).ToList();
                HelperMethod(1, membersFoods, membersFoods2, foodType);
            }
            else if (daysBack != 0 && mealId == 0 && foodType != "All Types")
            {
                membersFoods = db.MembersFoods.Where(x => x.MemberId == memberId && x.CreateDateTime >= System.Data.Entity.DbFunctions.AddDays(DateTime.Now, -daysBack)).ToList();
                HelperMethod(2, membersFoods, membersFoods2, foodType);
            }
            else if (daysBack != 0 && mealId == 0 && foodType == "All Types")
            {
                membersFoods = db.MembersFoods.Where(x => x.MemberId == memberId && x.CreateDateTime >= System.Data.Entity.DbFunctions.AddDays(DateTime.Now, -daysBack)).ToList();
                HelperMethod(1, membersFoods, membersFoods2, foodType);
            }
            else if (daysBack != 0 && mealId != 0 && foodType == "All Types")
            {
                membersFoods = db.MembersFoods.Where(x => x.MemberId == memberId && x.CreateDateTime >= System.Data.Entity.DbFunctions.AddDays(DateTime.Now, -daysBack) && x.MealId == mealId).ToList();
                HelperMethod(1, membersFoods, membersFoods2, foodType);
            }
            else
            {
                membersFoods = db.MembersFoods.Where(x => x.MemberId == memberId && x.CreateDateTime >= System.Data.Entity.DbFunctions.AddDays(DateTime.Now, -daysBack) && x.MealId == mealId).ToList();
                HelperMethod(2, membersFoods, membersFoods2, foodType);
            }

            foreach (var memberFood in membersFoods2)
            {
                foodIds.Add(memberFood.FoodId);
            }

            if (membersFoods2.Count != 0)
            {
                var mostFoodId = foodIds.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
                var mostFoodCount = db.MembersFoods.Where(x => x.MemberId == memberId && x.FoodId == mostFoodId).Count();
                var foodName = db.Foods.FirstOrDefault(x => x.FoodId == mostFoodId).Name;
                var totalCal = 0.0;
                foreach (var foodId in foodIds)
                {
                    totalCal += db.Foods.FirstOrDefault(x => x.FoodId == foodId).Calorie;
                }

                dict.Add(foodName, mostFoodCount);
                dict.Add("Total Cal", (int)totalCal);
                return dict;
            }
            else
            {
                dict2.Add("0", 0);
                return dict2;
            }

        }
        public void HelperMethod(int selection, List<MemberFood> membersFoods, List<MemberFood> membersFoods2, string foodType)
        {
            if (selection == 1)
            {
                foreach (var food in membersFoods)
                {
                    membersFoods2.Add(food);
                }
            }
            else if (selection == 2)
            {
                foreach (var food in membersFoods)
                {
                    if (db.Foods.Any(x => x.FoodId == food.FoodId && x.FoodType == foodType))
                        membersFoods2.Add(food);
                }
            }
        }
        public string FindFoodImageUrlviaName(string foodName)
        {
            if (db.Foods.FirstOrDefault(x => x.Name == foodName) == null)
            {
                return "";
            }

            return db.Foods.FirstOrDefault(x => x.Name == foodName).PhotoURL;
        }
    }
}
