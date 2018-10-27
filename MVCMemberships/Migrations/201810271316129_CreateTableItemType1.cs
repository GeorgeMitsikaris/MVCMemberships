namespace MVCMemberships.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableItemType1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ItemType");
        }
    }
}
