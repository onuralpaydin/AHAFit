using System;
using AHAFit_Data;
using AHAFit_Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AHAFit_BLL
{
    public class Alper
    {
        Context db = new Context();
        private readonly int memberId;
        public Alper(int memberId)
        {
            this.memberId = memberId;
        }

        public List<string> Meals()
        {
            return db.Meals.Select(x=>x.Name).ToList();
        }
        public string[] Categories()
        {
            return Enum.GetNames(typeof(FoodType));
        }        
        public double ReportsFormCalorieMember(int mealId,int datetimevalue)        {
            
            DateTime Date = DateTime.Now.AddDays(datetimevalue);

            List<double> totalCalorie = new List<double>();
            double sumCalorie = 0,avg=0;    
            var TotalCalories = db.MembersFoods.Where(x => x.MemberId == memberId && x.MealId == mealId && DbFunctions.TruncateTime(x.CreateDateTime) >= Date.Date).Select(x => x.FoodId).ToList();


            foreach (var item in TotalCalories)
            {
                totalCalorie.AddRange(db.Foods.Where(x => x.FoodId == item).Select(x => x.Calorie).ToList());
            }
           
            foreach (var item in totalCalorie)
            {
                sumCalorie += item;
            }

            int mealValue = db.MembersFoods.Where(x => x.MemberId == memberId && x.MealId == mealId).Count();

            avg = (sumCalorie / mealValue);
            return Math.Round(avg,2);

        }
        public double ReportsFormCalorieAllMembers(int mealId, int datetime)
        {
            DateTime Date = DateTime.Now.AddDays(datetime);

            List<double> totalCalorie = new List<double>();
            double sumCalorie = 0, avg = 0;
            var TotalCalories = db.MembersFoods.Where(x=>x.MealId == mealId && DbFunctions.TruncateTime(x.CreateDateTime) >= Date.Date).Select(x => x.FoodId).ToList();
            foreach (var item in TotalCalories)
            {
                totalCalorie.AddRange(db.Foods.Where(x => x.FoodId == item).Select(x => x.Calorie).ToList());

            }
            foreach (var item in totalCalorie)
            {
                sumCalorie += item;
            }
            int mealValue = db.MembersFoods.Where(x=>x.MealId == mealId).Count();

            avg = (sumCalorie / mealValue);
            return Math.Round(avg,2);
        }
        public double ReportsFormCalorieMemberByCategorie(int memberId,string foodtype,int datetimevalue)
        {
            DateTime Date = DateTime.Now.AddDays(datetimevalue);
            double totalCalorie = 0, avg = 0;            
            var selectedCalories = from m in db.MembersFoods
                    join f in db.Foods
                    on m.FoodId equals f.FoodId
                    join me in db.Members
                    on m.MemberId equals me.MemberId
                    where (me.MemberId == memberId && f.FoodType == foodtype && DbFunctions.TruncateTime(m.CreateDateTime) >= Date.Date)
                    select f.Calorie;
            foreach (var item in selectedCalories)
            {
                totalCalorie += item;                
            }
            avg = totalCalorie / selectedCalories.Count(); 
            return Math.Round(avg,2);
        }
        public double ReportsFormCalorieAllMembersByCategorie(string foodtype, int datetimevalue)
        {
            DateTime Date = DateTime.Now.AddDays(datetimevalue);
            double totalCalorie = 0, avg = 0;
            var selectedCalories = from m in db.MembersFoods
                                   join f in db.Foods
                                   on m.FoodId equals f.FoodId
                                   join me in db.Members
                                   on m.MemberId equals me.MemberId
                                   where (f.FoodType == foodtype && DbFunctions.TruncateTime(m.CreateDateTime) >= Date.Date)
                                   select f.Calorie;
            foreach (var item in selectedCalories)
            {
                totalCalorie += item;
            }
            avg = totalCalorie / selectedCalories.Count();
            return Math.Round(avg, 2);
        }     
    }
}
