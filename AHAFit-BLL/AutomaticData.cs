using AHAFit_Data;
using AHAFit_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_BLL
{
    public class AutomaticData
    {
        Context db = new Context();
        public void MealAndGoalDataLoad()
        {
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
        public void AutoAdminMember()
        {
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

            if (!db.Members.Any(x => x.Email == newMember.Email))
            {
                db.Members.Add(newMember);
                db.SaveChanges();
            }

        }
        public void AddWaterToFoods()
        {
            if (!db.Foods.Any(x => x.Name == "water"))
            {
                Food water = new Food();
                water.Name = "water";
                water.Calorie = 0;
                water.Carbohydrate = 0;
                water.Protein = 0;
                water.Fat = 0;
                water.PhotoURL = "asda";
                water.FoodType = "Grain";
                db.Foods.Add(water);
                db.SaveChanges();
            }

        }
    }
}
