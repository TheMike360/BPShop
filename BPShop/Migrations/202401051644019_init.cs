namespace BPShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        ProductIds = c.String(nullable: false),
                        Count = c.String(nullable: false),
                        Address = c.String(nullable: false, maxLength: 200),
                        HisName = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 20),
                        RecipientName = c.String(nullable: false, maxLength: 100),
                        RecipientContact = c.String(nullable: false, maxLength: 100),
                        PayType = c.Int(nullable: false),
                        OrderStatuses = c.Int(nullable: false),
                        DeliverDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(nullable: false, maxLength: 2000),
                        Count = c.Int(nullable: false),
                        CountFlowersInBouquet = c.Int(),
                        ProductType = c.Int(nullable: false),
                        SearchPrompt = c.String(nullable: false, maxLength: 2000),
                        ImgRef = c.String(maxLength: 200),
                        FlowersType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
        }
    }
}
