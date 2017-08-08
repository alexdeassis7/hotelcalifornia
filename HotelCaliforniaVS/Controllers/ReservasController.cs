using HotelCaliforniaVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelCaliforniaVS.Controllers
{
    public class ReservasController : Controller
    {
        HotelContext db = new HotelContext();

       [HttpPost]
        public ActionResult Crear(Usuarios usuario1, DateTime FechaIngreso, DateTime FechaEgreso, int CantNinos, int CantAdultos)
        {
            if(Session["UsuarioLogueado"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Usuarios usuario = (Usuarios)Session["UsuarioLogueado"];

            Reservas nuevaReserva = new Reservas();
            nuevaReserva.usuario = usuario1;
            nuevaReserva.FechaIngreso = FechaIngreso;
            nuevaReserva.FechaEgreso = FechaEgreso;
            nuevaReserva.CantNinos = CantNinos;
            nuevaReserva.CantAdultos = CantAdultos;

            db.Reservas.Add(nuevaReserva);
            db.SaveChanges();

            TempData["Mensaje"] = "Reserva Creada!";

            return RedirectToAction("Index", "Home");
        }
    }
}