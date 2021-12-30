namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_MessageIsDraftColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "IsDraft", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "IsDraft");
        }
    }
}
