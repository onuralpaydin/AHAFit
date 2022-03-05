namespace AHAFit_Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        FoodId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Calorie = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Carbohydrate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Protein = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PhotoURL = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.FoodId);
            
            CreateTable(
                "dbo.MealsFoods",
                c => new
                    {
                        MealFoodId = c.Int(nullable: false, identity: true),
                        MealId = c.Int(nullable: false),
                        FoodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MealFoodId)
                .ForeignKey("dbo.Foods", t => t.FoodId, cascadeDelete: true)
                .ForeignKey("dbo.Meals", t => t.MealId, cascadeDelete: true)
                .Index(t => t.MealId)
                .Index(t => t.FoodId);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        MealId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.MealId);
            
            CreateTable(
                "dbo.MembersAndFoods",
                c => new
                    {
                        MemberFoodId = c.Int(nullable: false, identity: true),
                        CreateDateTime = c.DateTime(nullable: false),
                        MemberId = c.Int(nullable: false),
                        FoodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MemberFoodId)
                .ForeignKey("dbo.Foods", t => t.FoodId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId)
                .Index(t => t.FoodId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 250),
                        Name = c.String(nullable: false, maxLength: 100),
                        Surname = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 100),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Gender = c.String(nullable: false),
                        Height = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        GoalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MemberId)
                .ForeignKey("dbo.Goals", t => t.GoalId, cascadeDelete: true)
                .Index(t => t.GoalId);
            
            CreateTable(
                "dbo.Goals",
                c => new
                    {
                        GoalId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.GoalId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MembersAndFoods", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Members", "GoalId", "dbo.Goals");
            DropForeignKey("dbo.MembersAndFoods", "FoodId", "dbo.Foods");
            DropForeignKey("dbo.MealsFoods", "MealId", "dbo.Meals");
            DropForeignKey("dbo.MealsFoods", "FoodId", "dbo.Foods");
            DropIndex("dbo.Members", new[] { "GoalId" });
            DropIndex("dbo.MembersAndFoods", new[] { "FoodId" });
            DropIndex("dbo.MembersAndFoods", new[] { "MemberId" });
            DropIndex("dbo.MealsFoods", new[] { "FoodId" });
            DropIndex("dbo.MealsFoods", new[] { "MealId" });
            DropTable("dbo.Goals");
            DropTable("dbo.Members");
            DropTable("dbo.MembersAndFoods");
            DropTable("dbo.Meals");
            DropTable("dbo.MealsFoods");
            DropTable("dbo.Foods");
        }
    }
}
