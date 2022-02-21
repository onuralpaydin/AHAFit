using AHAFit_Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_Model
{
    public class MealMapping : EntityTypeConfiguration<Meal>
    {
        public MealMapping()
        {
            ToTable("Meals");
            HasKey(x => x.MealId);
            Property(x => x.Name).IsRequired().HasMaxLength(100);
        }
    }
}
