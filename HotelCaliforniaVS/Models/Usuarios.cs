using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelCaliforniaVS.Models
{


    [Table("Usuarios")]//pongo nombre a la table para que no aparezca el usuarioes

    public class  Usuarios
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         
        public int ID { get; set; }
        public string NameUser { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }



    }
}