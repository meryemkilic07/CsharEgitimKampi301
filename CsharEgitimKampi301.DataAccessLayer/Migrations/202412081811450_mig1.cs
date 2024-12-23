namespace CsharEgitimKampi301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()//veri tabanı güncelleme işlemi
        {
            AddColumn("dbo.Customers", "CustomerStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()//silme işlemi
        {
            DropColumn("dbo.Customers", "CustomerStatus");
        }
    }
}
