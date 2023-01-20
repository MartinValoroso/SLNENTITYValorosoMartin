namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avion",
                c => new
                    {
                        AvionID = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Demonimacion = c.String(nullable: false, maxLength: 50, unicode: false),
                        IdLinea = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AvionID)
                .ForeignKey("dbo.LineaAerea", t => t.IdLinea, cascadeDelete: true)
                .Index(t => t.IdLinea);
            
            CreateTable(
                "dbo.LineaAerea",
                c => new
                    {
                        LineaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LineaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avion", "IdLinea", "dbo.LineaAerea");
            DropIndex("dbo.Avion", new[] { "IdLinea" });
            DropTable("dbo.LineaAerea");
            DropTable("dbo.Avion");
        }
    }
}
