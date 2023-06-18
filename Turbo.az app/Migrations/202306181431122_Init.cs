namespace Turbo.az_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BodyTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BodyTypeName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColorId = c.Int(nullable: false),
                        ModelId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        BodyTypeId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        Kilometer = c.Single(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProdYear = c.DateTime(nullable: false),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BodyTypes", t => t.BodyTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Colors", t => t.ColorId, cascadeDelete: true)
                .ForeignKey("dbo.Models", t => t.ModelId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.ColorId)
                .Index(t => t.ModelId)
                .Index(t => t.StatusId)
                .Index(t => t.BodyTypeId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColorName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModelName = c.String(nullable: false, maxLength: 30),
                        BrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsNew = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Cars", "ModelId", "dbo.Models");
            DropForeignKey("dbo.Models", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Cars", "ColorId", "dbo.Colors");
            DropForeignKey("dbo.Cars", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Cars", "BodyTypeId", "dbo.BodyTypes");
            DropIndex("dbo.Models", new[] { "BrandId" });
            DropIndex("dbo.Cars", new[] { "CityId" });
            DropIndex("dbo.Cars", new[] { "BodyTypeId" });
            DropIndex("dbo.Cars", new[] { "StatusId" });
            DropIndex("dbo.Cars", new[] { "ModelId" });
            DropIndex("dbo.Cars", new[] { "ColorId" });
            DropTable("dbo.Status");
            DropTable("dbo.Brands");
            DropTable("dbo.Models");
            DropTable("dbo.Colors");
            DropTable("dbo.Cities");
            DropTable("dbo.Cars");
            DropTable("dbo.BodyTypes");
        }
    }
}
