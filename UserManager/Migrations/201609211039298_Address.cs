namespace UserManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Address", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Address");
        }
    }
}
