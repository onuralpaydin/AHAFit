using AHAFit_Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_Model
{
    public class MemberMapping : EntityTypeConfiguration<Member>
    {
        public MemberMapping()
        {
            ToTable("Members");
            HasKey(x => x.MemberId);
            Property(x => x.Email).IsRequired().HasMaxLength(250);
            Property(x => x.Name).IsRequired().HasMaxLength(100);
            Property(x => x.Surname).IsRequired().HasMaxLength(100);
            Property(x => x.Password).IsRequired().HasMaxLength(100);
            Property(x => x.Weight).IsRequired().HasPrecision(18, 2);
            Property(x => x.Gender).IsRequired();
            Property(x => x.Height).IsRequired();
            Property(x => x.BirthDate).IsRequired();
            Property(x => x.ActivityLevel).IsRequired();
            HasRequired<Goal>(x => x.Goal).WithMany(x => x.Members);
        }
    }
}
