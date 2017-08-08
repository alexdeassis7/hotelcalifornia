namespace HotelCaliforniaVS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "Password");
        }
    }
}
