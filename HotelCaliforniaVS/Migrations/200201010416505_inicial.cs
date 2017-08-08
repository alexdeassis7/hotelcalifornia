namespace HotelCaliforniaVS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FechaIngreso = c.DateTime(nullable: false),
                        FechaEgreso = c.DateTime(nullable: false),
                        CantNinos = c.Int(nullable: false),
                        CantAdultos = c.Int(nullable: false),
                        usuario_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuarios", t => t.usuario_ID)
                .Index(t => t.usuario_ID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameUser = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "usuario_ID", "dbo.Usuarios");
            DropIndex("dbo.Reservas", new[] { "usuario_ID" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Reservas");
        }
    }
}
