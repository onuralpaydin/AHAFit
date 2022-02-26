using AHAFit_Data;
using AHAFit_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_BLL
{
    public class Huseyin
    {

        public static void MealAndGoalDataLoad()
        {
            Context db = new Context();
            if (!db.Meals.Any())
            {
                db.Meals.AddRange(new List<Meal> {
                    new Meal() { Name = "Breakfast"},
                    new Meal() { Name = "Lunch"},
                    new Meal() { Name = "Dinner"},
                });

                db.SaveChanges();
            }

            if (!db.Goals.Any())
            {
                db.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Goals', RESEED, 0)");
                db.Goals.AddRange(new List<Goal> {
                    new Goal() { Name = "Lose Weight"},
                    new Goal() { Name = "Gain Weight"},
                    new Goal() { Name = "Maintain Your Weight"},
                });
                db.SaveChanges();
            }
        }
        public static List<string> GetMeals()
        {
            Context db = new Context();
            List<string> meals = new List<string>();
            foreach (var item in db.Meals.ToList())
            {
                meals.Add(item.Name);
            }

            return meals;
        }
        public static void AutoAdminMember()
        {
            Context db = new Context();
            Member newMember = new Member();
            newMember.Email = "admin@admin.com";
            newMember.Name = "admin";
            newMember.Surname = "admin";
            newMember.Password = "admin";
            newMember.Weight = 91.50;
            newMember.Gender = "Male";
            newMember.Height = 185;
            newMember.ActivityLevel = ActivityLevel.ModeratelyActive.ToString();
            newMember.BirthDate = new DateTime(2002, 5, 1);
            newMember.GoalId = 1;

            if(!db.Members.Any(x=>x.Email == newMember.Email))
            {
                db.Members.Add(newMember);
                db.SaveChanges();
            }
           
        }
        public static void AddWaterToFoods()
        {
            Context db = new Context();

            if (!db.Foods.Any(x => x.Name == "Water"))
            {
                Food water = new Food();
                water.Name = "Water";
                water.Calorie = 0;
                water.Carbohydrate = 0;
                water.Protein = 0;
                water.Fat = 0;
                water.PhotoURL = "asda";
                db.Foods.Add(water);
                db.SaveChanges();
            }

        }
        public static bool MemberLoginControl(string email, string password)
        {
            Context db = new Context();
            if(!db.Members.Any(x=>x.Email == email))
            {
                return false;

            }else if(db.Members.FirstOrDefault(x=>x.Email == email).Password != password)
            {
                return false;
            }else
            {
                return true;
            }
        }
        public static int MemberIdFounder(string email)
        {
            Context db = new Context();
            return db.Members.FirstOrDefault(x => x.Email == email).MemberId;

        }
        public static double DailyCalorieCalculater(int memberId, DateTime selectedDay)
        {
            Context db = new Context();
            double totalCal = 0;
            foreach (var item in db.MembersFoods.ToList())
            {
                if(item.MemberId == memberId && item.CreateDateTime == selectedDay)
                {
                    totalCal += db.Foods.FirstOrDefault(x => x.FoodId == item.FoodId).Calorie;
                }
            }

            return totalCal;
        }
        public static double DailyCalorieCalculaterAccordingToMeal(int memberId, DateTime selectedDay, string mealName)
        {
            Context db = new Context();
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
        public static double DailyCarbohydrate(int memberId, DateTime selectedDay)
        {
            Context db = new Context();
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
        public static double DailyProtein(int memberId, DateTime selectedDay)
        {
            Context db = new Context();
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
        public static double DailyFat(int memberId, DateTime selectedDay)
        {
            Context db = new Context();
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
        public static List<Food> DailyFoods(int memberId, DateTime selectedDay)
        {
            Context db = new Context();

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
        public static int DailyRemainWater(int memberId, DateTime selectedDay)
        {
            Context db = new Context();

            int totalGlass = 13;

            int waterId = db.Foods.FirstOrDefault(x => x.Name == "Water").FoodId;

            foreach (var item in db.MembersFoods.ToList())
            {
                if(item.MemberId == memberId && item.CreateDateTime == selectedDay && item.FoodId == waterId)
                {
                    totalGlass--;
                }
            }

            return totalGlass;
        }
        public static string GetMemberName(int memberId)
        {
            Context db = new Context();

           return db.Members.FirstOrDefault(x => x.MemberId == memberId).Name;
        }
        public static double CalculateDailyCalorieNeed(int memberId)
        {
            Context db = new Context();
            var member = db.Members.FirstOrDefault(x => x.MemberId == memberId);
            double genderCalorie = 0;
            double activityCalorie = 0;

            if (member.Gender == "Female")
                genderCalorie = 655.1 + (9.563 * member.Weight) + (1.850 * member.Height) - (4.676 * (DateTime.Now.Year - member.BirthDate.Year));
            else if (member.Gender == "Male")
                genderCalorie = 66.47 + (13.75 * member.Weight) + (5.003 * member.Height) - (6.7555 * (DateTime.Now.Year - member.BirthDate.Year));

            if(member.ActivityLevel == ActivityLevel.Sedentary.ToString())
                activityCalorie = genderCalorie * 1.2;
            else if(member.ActivityLevel == ActivityLevel.LightlyActive.ToString())
                activityCalorie = genderCalorie * 1.375;
            else if(member.ActivityLevel == ActivityLevel.ModeratelyActive.ToString())
                activityCalorie = genderCalorie * 1.725;
            else if(member.ActivityLevel == ActivityLevel.VeryActive.ToString())
                activityCalorie = genderCalorie * 1.9;

            var goalName = db.Goals.FirstOrDefault(x => x.GoalId == member.GoalId).Name;

            if (goalName == "Lose Weight")
                return activityCalorie - 513;
            else if (goalName == "Gain Weight")
                return activityCalorie + 513;
            else if(goalName == "Maintain Your Weight")
                return activityCalorie;
            else
                return activityCalorie;
        }
        public static void plusOneGlassOfWater(int memberId, DateTime selectedDay, string mealName)
        {
            Context db = new Context();

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
        public static void MemberFoodRemevoFromDB(DateTime createDate, int memberId, int foodId)
        {
            Context db = new Context();

            var mealId = db.MembersFoods.FirstOrDefault(x=>x.MemberId == memberId && x.FoodId == foodId && x.CreateDateTime == createDate).MealId;

            var memberFoodGonnaDeleted = db.MembersFoods.FirstOrDefault(x => x.CreateDateTime == createDate && x.MemberId == memberId && x.MealId == mealId);
            var mealFoodGonnaDeleted = db.MealsFoods.FirstOrDefault(x => x.CreateDateTime == createDate && x.FoodId == foodId && x.MealId == mealId);

            db.MembersFoods.Remove(memberFoodGonnaDeleted);
            db.MealsFoods.Remove(mealFoodGonnaDeleted);
            db.SaveChanges();
        }
        public static void ChangeMembersGoal(int memberId, string newGoal)
        {
            Context db = new Context();

            int newGoalId = db.Goals.FirstOrDefault(x => x.Name == newGoal).GoalId;

            db.Members.FirstOrDefault(x => x.MemberId == memberId).GoalId = newGoalId;

            db.SaveChanges();

        }
        public static Member getMemberInformations(int memberId)
        {
            Context db = new Context();
            return db.Members.FirstOrDefault(x => x.MemberId == memberId);
        }
        public static void ChangeMemberInformation(int memberId, string email, string name, string surname, string password, double weight, string gender, int height, DateTime birthDate, string activityLevel)
        {
            Context db = new Context();
            var member = db.Members.FirstOrDefault(x => x.MemberId == memberId);

            member.Email = email;
            member.Name = name;
            member.Surname = surname;
            member.Password = password;
            member.Weight = weight;
            member.Gender = gender;
            member.Height = height;
            member.BirthDate = birthDate;
            member.ActivityLevel = activityLevel;

            db.SaveChanges();
        }
    }
}
