namespace ASPNetCrudApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Genres", "Name", c => c.String());
        }
    }
}
