using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Dac
{
    public class AbmAvion
    {
        private static DBLineaAerea context = new DBLineaAerea();

        public static List<Avion> SelectAll() 
        {
            return context.Aviones.ToList(); 
        }

        public static int Insert(Avion avion) 
        {
            context.Aviones.Add(avion);
            return context.SaveChanges();
        }

        public static int Update(Avion avion)
        {
            Avion AvionOrigen = context.Aviones.Find(avion.AvionID); 
            AvionOrigen.Capacidad = avion.Capacidad;
            AvionOrigen.Demonimacion = avion.Demonimacion;
            
            return context.SaveChanges();

        }

        public static int Delete(Avion avion)
        {
            Avion AvionOrigen = context.Aviones.Find(avion.AvionID);
            if (AvionOrigen != null) 
            {
                context.Aviones.Remove(AvionOrigen);
                return context.SaveChanges(); 
            }
            return 0;
        }

        public static Avion SelectWhereById(int id) 
        {
            return context.Aviones.Find(id);

        }

    }


}
