namespace Planing.Migrations
{
    using System.Data.Entity.Migrations;
    public partial class ght4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groupes", "Nombre", c => c.Int(nullable: false));
            AddColumn("dbo.Sections", "Nombre", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sections", "Nombre");
            DropColumn("dbo.Groupes", "Nombre");
        }
    }
}
