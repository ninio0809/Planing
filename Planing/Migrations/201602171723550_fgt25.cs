namespace Planing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fgt25 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Semestre", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Semestre");
        }
    }
}
