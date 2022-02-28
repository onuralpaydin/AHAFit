using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_Data
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public double Calorie { get; set; }
        public double Carbohydrate { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public string PhotoURL { get; set; }
        public List<MemberFood> MemberFoods { get; set; }
        public List<MealFood> MealFoods { get; set; }
        public string FoodType { get; set; }
    }

    public enum FoodType
    {
        Fruit,
        Vegetable,
        Grain,
        ProteinFood,
        Dairy
    }
}
