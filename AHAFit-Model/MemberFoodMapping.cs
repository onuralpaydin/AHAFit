using AHAFit_Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_Model
{
    public class MemberFoodMapping : EntityTypeConfiguration<MemberFood>
    {
        public MemberFoodMapping()
        {
            ToTable("MembersAndFoods");
            HasKey(x => x.MemberFoodId);
            Property(x => x.CreateDateTime).IsRequired();
            HasRequired(x => x.Member).WithMany(x => x.MemberFoods).HasForeignKey(x => x.MemberId);
            HasRequired(x => x.Food).WithMany(x => x.MemberFoods).HasForeignKey(x => x.FoodId);
        }

    }
}
