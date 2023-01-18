namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avions",
                c => new
                    {
                        AvionID = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Demonimacion = c.String(),
                    })
                .PrimaryKey(t => t.AvionID);
            
            CreateTable(
                "dbo.LineaAereas",
                c => new
                    {
                        LineaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        FechaInicioActividades = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LineaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LineaAereas");
            DropTable("dbo.Avions");
        }
    }
}
