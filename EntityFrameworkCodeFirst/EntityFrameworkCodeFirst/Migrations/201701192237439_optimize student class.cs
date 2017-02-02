namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class optimizestudentclass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "name", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AlterColumn("dbo.Students", "FavoriteColor", c => c.String(maxLength: 30, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "FavoriteColor", c => c.String());
            AlterColumn("dbo.Students", "name", c => c.String(nullable: false));
        }
    }
}
