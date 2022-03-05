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
            if(db.Foods.FirstOrDefault(x => x.FoodId == foodId) == null)
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
    }
}
