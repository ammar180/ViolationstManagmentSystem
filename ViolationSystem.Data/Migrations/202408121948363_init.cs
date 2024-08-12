namespace ViolationSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trucks",
                c => new
                    {
                        TruckCode = c.String(nullable: false, maxLength: 128),
                        IsExplored = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TruckCode);
            
            CreateTable(
                "dbo.Violations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TruckCode = c.String(nullable: false, maxLength: 128),
                        ViolationDate = c.DateTime(nullable: false),
                        Unit = c.String(nullable: false, maxLength: 64),
                        ElManfaz = c.String(maxLength: 64),
                        ReportNumber = c.String(maxLength: 128),
                        BlockDate = c.DateTime(),
                        PaymentDate = c.DateTime(),
                        Comments = c.String(),
                        VCount = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trucks", t => t.TruckCode, cascadeDelete: true)
                .Index(t => t.TruckCode);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Violations", "TruckCode", "dbo.Trucks");
            DropIndex("dbo.Violations", new[] { "TruckCode" });
            DropTable("dbo.Users");
            DropTable("dbo.Violations");
            DropTable("dbo.Trucks");
        }
    }
}
