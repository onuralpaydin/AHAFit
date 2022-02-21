using AHAFit_Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_Model
{
    public class FoodMapping : EntityTypeConfiguration<Food>
    {
        public FoodMapping()
        {
            ToTable("Foods");
            HasKey(x => x.FoodId);
            Property(x => x.Name).IsRequired().HasMaxLength(100);
            Property(x => x.Calorie).IsRequired().HasPrecision(18, 2);
            Property(x => x.Carbohydrate).IsRequired().HasPrecision(18, 2);
            Property(x => x.Protein).IsRequired().HasPrecision(18, 2);
            Property(x => x.Fat).IsRequired().HasPrecision(18, 2);
            Property(x => x.PhotoURL).IsRequired().HasMaxLength(300);
        }
      

    }
}
