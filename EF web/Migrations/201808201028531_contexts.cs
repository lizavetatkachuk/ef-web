namespace EF_web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contexts : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        LName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
