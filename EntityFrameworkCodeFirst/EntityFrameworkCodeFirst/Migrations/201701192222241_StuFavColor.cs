namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StuFavColor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "FavoriteColor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "FavoriteColor");
        }
    }
}
