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
            Property(x => x.Calorie).IsRequired();
            Property(x => x.Carbohydrate).IsRequired();
            Property(x => x.Protein).IsRequired();
            Property(x => x.Fat).IsRequired();
            Property(x => x.PhotoURL).IsRequired().HasMaxLength(300);
        }
      

    }
}
