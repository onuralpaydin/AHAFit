using AHAFit_Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAFit_Model
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = "server=.; database=AHAFit; uid=sa; pwd=1234";
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MemberFood> MembersFoods { get; set; }
        public DbSet<MealFood> MealsFoods { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FoodMapping());
            modelBuilder.Configurations.Add(new GoalMapping());
            modelBuilder.Configurations.Add(new MealMapping());
            modelBuilder.Configurations.Add(new MemberFoodMapping());
            modelBuilder.Configurations.Add(new MealFoodMapping());
            modelBuilder.Configurations.Add(new MemberMapping());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
