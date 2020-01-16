namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AgentContracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AgentId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Commission = c.Double(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.AgentId, cascadeDelete: true)
                .Index(t => t.AgentId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClientContracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AgentId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        TourId = c.Int(nullable: false),
                        NumberPeople = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Total = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AgentContracts", t => t.AgentId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Tours", t => t.TourId, cascadeDelete: true)
                .Index(t => t.AgentId)
                .Index(t => t.ClientId)
                .Index(t => t.TourId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        Passport = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        Duration = c.String(),
                        Cost = c.Double(nullable: false),
                        Service = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Statements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Salary = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Period = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TableStatements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AgentId = c.Int(nullable: false),
                        Sum = c.Double(nullable: false),
                        StatementId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AgentContracts", t => t.AgentId, cascadeDelete: true)
                .ForeignKey("dbo.Statements", t => t.StatementId, cascadeDelete: true)
                .Index(t => t.AgentId)
                .Index(t => t.StatementId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TableStatements", "StatementId", "dbo.Statements");
            DropForeignKey("dbo.TableStatements", "AgentId", "dbo.AgentContracts");
            DropForeignKey("dbo.ClientContracts", "TourId", "dbo.Tours");
            DropForeignKey("dbo.ClientContracts", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.ClientContracts", "AgentId", "dbo.AgentContracts");
            DropForeignKey("dbo.AgentContracts", "AgentId", "dbo.Users");
            DropIndex("dbo.TableStatements", new[] { "StatementId" });
            DropIndex("dbo.TableStatements", new[] { "AgentId" });
            DropIndex("dbo.ClientContracts", new[] { "TourId" });
            DropIndex("dbo.ClientContracts", new[] { "ClientId" });
            DropIndex("dbo.ClientContracts", new[] { "AgentId" });
            DropIndex("dbo.AgentContracts", new[] { "AgentId" });
            DropTable("dbo.TableStatements");
            DropTable("dbo.Statements");
            DropTable("dbo.Tours");
            DropTable("dbo.Clients");
            DropTable("dbo.ClientContracts");
            DropTable("dbo.Users");
            DropTable("dbo.AgentContracts");
        }
    }
}
