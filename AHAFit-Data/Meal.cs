﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_Data
{
    public class Meal
    {
        public int MealId { get; set; }
        public string Name { get; set; }
        public List<MealFood> MealFoods { get; set; }
    }
}
