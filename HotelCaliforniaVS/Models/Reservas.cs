using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelCaliforniaVS.Models
{

    [Table("Reservas")]//pongo nombre a la table para que no aparezca el reservaes

    public class Reservas
    {     
       
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

            public int ID { get; set; }

            public Usuarios usuario { get; set; }
        
            public DateTime FechaIngreso { get; set; }

            public DateTime FechaEgreso { get; set; }                

            public int CantNinos { get; set; }

            public int CantAdultos { get; set; }

        //Preguntar a juan si debo agregar un public List<Reservas> Reservas{get; set;}

       
    }
}