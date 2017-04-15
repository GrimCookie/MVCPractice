namespace MVCpractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Reviews", "ReviewrEmail", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "ReviewrEmail", c => c.String());
            DropColumn("dbo.Albums", "Price");
        }
    }
}
