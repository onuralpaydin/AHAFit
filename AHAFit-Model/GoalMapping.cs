using AHAFit_Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_Model
{
    public class GoalMapping : EntityTypeConfiguration<Goal>
    {
        public GoalMapping()
        {
            ToTable("Goals");
            HasKey(x => x.GoalId);
            Property(x => x.Name).IsRequired().HasMaxLength(100);
            HasMany<Member>(x => x.Members).WithRequired(x => x.Goal).HasForeignKey<int>(x => x.GoalId);
        }
    }
}
