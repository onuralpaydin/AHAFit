using AHAFit_Data;
using AHAFit_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_BLL
{
    public class FoodMemberData
    {
        Context db = new Context();
        public double DailyCalorieCalculater(int memberId, DateTime selectedDay)
        {
            double totalCal = 0;
            foreach (var item in db.MembersFoods.ToList())
            {
                if (item.MemberId == memberId && item.CreateDateTime == selectedDay)
                {
                    totalCal += db.Foods.FirstOrDefault(x => x.FoodId == item.FoodId).Calorie;
                }
            }
            return totalCal;
        }
        public double DailyCalorieCalculaterAccordingToMeal(int memberId, DateTime selectedDay, string mealName)
        {
            double totalCal = 0;

            foreach (var item in db.MembersFoods.ToList())
            {
                if (item.MemberId == memberId && item.CreateDateTime == selectedDay && item.MealId == db.Meals.FirstOrDefault(x => x.Name == mealName).MealId)
                {
                    totalCal += db.Foods.FirstOrDefault(x => x.FoodId == item.FoodId).Calorie;
                }
            }

            if (totalCal <= 0)
                return 0;
            else
                return totalCal;
        }
        public double DailyCarbohydrate(int memberId, DateTime selectedDay)
        {
            double totalCarbohydrate = 0;
            foreach (var item in db.MembersFoods.ToList())
            {
                if (item.MemberId == memberId && item.CreateDateTime == selectedDay)
                {
                    totalCarbohydrate += db.Foods.FirstOrDefault(x => x.FoodId == item.FoodId).Carbohydrate;
                }
            }
            return totalCarbohydrate;
        }
        public double DailyProtein(int memberId, DateTime selectedDay)
        {
            double totalProtein = 0;
            foreach (var item in db.MembersFoods.ToList())
            {
                if (item.MemberId == memberId && item.CreateDateTime == selectedDay)
                {
                    totalProtein += db.Foods.FirstOrDefault(x => x.FoodId == item.FoodId).Protein;
                }
            }
            return totalProtein;
        }
        public double DailyFat(int memberId, DateTime selectedDay)
        {
            double totalFat = 0;
            foreach (var item in db.MembersFoods.ToList())
            {
                if (item.MemberId == memberId && item.CreateDateTime == selectedDay)
                {
                    totalFat += db.Foods.FirstOrDefault(x => x.FoodId == item.FoodId).Fat;
                }
            }
            return totalFat;
        }
        public List<Food> DailyFoods(int memberId, DateTime selectedDay)
        {
            List<Food> dailyFoodList = new List<Food>();

            foreach (var item in db.MembersFoods.ToList())
            {
                if (item.MemberId == memberId && item.CreateDateTime == selectedDay)
                {
                    dailyFoodList.Add(db.Foods.FirstOrDefault(x => x.FoodId == item.FoodId));
                }
            }

            return dailyFoodList;
        }
        public int DailyRemainWater(int memberId, DateTime selectedDay)
        {
            int totalGlass = 13;

            int waterId = db.Foods.FirstOrDefault(x => x.Name == "Water").FoodId;

            foreach (var item in db.MembersFoods.ToList())
            {
                if (item.MemberId == memberId && item.CreateDateTime == selectedDay && item.FoodId == waterId)
                {
                    totalGlass--;
                }
            }

            return totalGlass;
        }
        public double CalculateDailyCalorieNeed(int memberId)
        {
            var member = db.Members.FirstOrDefault(x => x.MemberId == memberId);
            double genderCalorie = 0;
            double activityCalorie = 0;

            if (member.Gender == "Female")
                genderCalorie = 655.1 + (9.563 * member.Weight) + (1.850 * member.Height) - (4.676 * (DateTime.Now.Year - member.BirthDate.Year));
            else if (member.Gender == "Male")
                genderCalorie = 66.47 + (13.75 * member.Weight) + (5.003 * member.Height) - (6.7555 * (DateTime.Now.Year - member.BirthDate.Year));

            if (member.ActivityLevel == ActivityLevel.Sedentary.ToString())
                activityCalorie = genderCalorie * 1.2;
            else if (member.ActivityLevel == ActivityLevel.LightlyActive.ToString())
                activityCalorie = genderCalorie * 1.375;
            else if (member.ActivityLevel == ActivityLevel.ModeratelyActive.ToString())
                activityCalorie = genderCalorie * 1.725;
            else if (member.ActivityLevel == ActivityLevel.VeryActive.ToString())
                activityCalorie = genderCalorie * 1.9;

            var goalName = db.Goals.FirstOrDefault(x => x.GoalId == member.GoalId).Name;

            if (goalName == "Lose Weight")
                return activityCalorie - 513;
            else if (goalName == "Gain Weight")
                return activityCalorie + 513;
            else if (goalName == "Maintain Your Weight")
                return activityCalorie;
            else
                return activityCalorie;
        }
        public void plusOneGlassOfWater(int memberId, DateTime selectedDay, string mealName)
        {
            MemberFood newMemberFood = new MemberFood();
            MealFood newMealFood = new MealFood();

            newMemberFood.CreateDateTime = selectedDay;
            newMemberFood.FoodId = db.Foods.FirstOrDefault(x => x.Name == "Water").FoodId;
            newMemberFood.MealId = db.Meals.FirstOrDefault(x => x.Name == mealName).MealId;
            newMemberFood.MemberId = memberId;

            newMealFood.CreateDateTime = selectedDay;
            newMealFood.MealId = newMemberFood.MealId;
            newMealFood.FoodId = newMemberFood.FoodId;

            db.MealsFoods.Add(newMealFood);
            db.MembersFoods.Add(newMemberFood);
            db.SaveChanges();
        }
        public void MemberFoodRemevoFromDB(DateTime createDate, int memberId, int foodId)
        {
            var mealId = db.MembersFoods.FirstOrDefault(x => x.MemberId == memberId && x.FoodId == foodId && x.CreateDateTime == createDate).MealId;

            var memberFoodGonnaDeleted = db.MembersFoods.FirstOrDefault(x => x.CreateDateTime == createDate && x.MemberId == memberId && x.MealId == mealId && x.FoodId == foodId);
            var mealFoodGonnaDeleted = db.MealsFoods.FirstOrDefault(x => x.CreateDateTime == createDate && x.FoodId == foodId && x.MealId == mealId);

            db.MembersFoods.Remove(memberFoodGonnaDeleted);
            db.MealsFoods.Remove(mealFoodGonnaDeleted);
            db.SaveChanges();
        }
        public void AddNewFoodToMember(int foodId, DateTime selectedDay, int memberId, int mealId)
        {
            MemberFood newMemberFood = new MemberFood(selectedDay);
            MealFood newMealFood = new MealFood(selectedDay);

            newMemberFood.MemberId = memberId;
            newMemberFood.FoodId = foodId;
            newMemberFood.MealId = mealId;

            newMealFood.MealId = mealId;
            newMealFood.FoodId = foodId;

            db.MembersFoods.Add(newMemberFood);
            db.MealsFoods.Add(newMealFood);

            db.SaveChanges();
        }

        //KONTROL
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
        public List<Food> MonthlyHistoryLoader(int memberId, int month)
        {
            List<MemberFood> memberFoodListMonth = new List<MemberFood>();
            List<Food> foodList = new List<Food>();

            memberFoodListMonth = db.MembersFoods.Where(x => x.CreateDateTime.Month == month).ToList();
            foreach (var item in memberFoodListMonth)
            {
                foodList.Add(db.Foods.FirstOrDefault(x => x.FoodId == item.FoodId));
            }
            return foodList;


        }
    }
}
