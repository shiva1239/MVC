namespace MVC_Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDOB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DOB", d => d.DateTime(nullable:false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DOB");
        }
    }
}
