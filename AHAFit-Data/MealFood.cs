using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_Data
{
    public class MealFood
    {
        public MealFood()
        {
            this.CreateDateTime = DateTime.Now;
        }
        public MealFood(DateTime CreateTime)
        {
            this.CreateDateTime = CreateTime;
        }
        public DateTime CreateDateTime { get; set; }
        public int MealFoodId { get; set; }
        public int MealId { get; set; }
        public int FoodId { get; set; }
        public Meal Meal { get; set; }
        public Food Food { get; set; }
    }
}
