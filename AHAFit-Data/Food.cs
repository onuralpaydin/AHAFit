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
        public decimal Calorie { get; set; }
        public decimal Carbohydrate { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }
        public string PhotoURL { get; set; }
        public List<MemberFood> MemberFoods { get; set; }
        public List<MealFood> MealFoods { get; set; }

    }
}
