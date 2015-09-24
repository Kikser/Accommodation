namespace Accommodation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accomodations", "image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accomodations", "image");
        }
    }
}
