using AHAFit_Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_Model
{
    public class MealFoodMapping : EntityTypeConfiguration<MealFood>
    {
        public MealFoodMapping()
        {
            ToTable("MealsFoods");
            HasKey(x => x.MealFoodId);
            Property(x => x.CreateDateTime).IsRequired();
            HasRequired(x => x.Meal).WithMany(x => x.MealFoods).HasForeignKey(x => x.MealId);
            HasRequired(x => x.Food).WithMany(x => x.MealFoods).HasForeignKey(x => x.FoodId);
        }
    }
}
