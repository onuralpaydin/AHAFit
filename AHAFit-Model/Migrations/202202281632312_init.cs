namespace AHAFit_Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "FoodType", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "FoodType");
        }
    }
}
