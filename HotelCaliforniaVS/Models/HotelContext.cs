using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HotelCaliforniaVS.Models
{
    public class HotelContext : DbContext
    {
        /// <summary>
        /// Llamamos al constructor de DbContext y le pasamos
        /// el nombre de la cadena de conexión en el web.config
        /// </summary>
        public HotelContext() : base("name=HotelContext")
        {

        }
    
        public DbSet<Reservas> Reservas { get; set; }
   
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}