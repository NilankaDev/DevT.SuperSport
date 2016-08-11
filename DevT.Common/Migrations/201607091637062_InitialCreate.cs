namespace Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        IsArchived = c.Boolean(nullable: false),
                        CountryOfBirth = c.String(),
                        Age = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(),
                        UserName = c.String(maxLength: 255),
                        Password = c.Binary(),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.People", new[] { "UserName" });
            DropTable("dbo.People");
        }
    }
}
