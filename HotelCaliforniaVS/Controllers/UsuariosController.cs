using HotelCaliforniaVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelCaliforniaVS.Controllers
{
    public class UsuariosController : Controller
    {
        [HttpPost]
        // GET: Usuarios
        public ActionResult RegistrarUser(string email, string email2, string password, string password2)
        {

            if ((email.Equals(email2)) && (password.Equals(password2)))
            {

                using (HotelContext db = new HotelContext())
                {
                    //busco el usuario en la base de datos haber si es que ya no existe
                    Usuarios usuario = db.Usuarios.FirstOrDefault(u => u.NameUser == email && u.Password == password);
                    //mostrar mensaje que el usuario ya existe si es que ahi uno en la base de dato  o crear el usuario nuevo
                    if (usuario == null)
                    {
                        //creo el usuario  nuevo
                        Usuarios u = new Usuarios();
                        u.Email = email;
                        u.NameUser = email;
                        u.Password = password;
                        db.Usuarios.Add(u);//lo agrego a la base de datos
                        db.SaveChanges();//guardo los cambios
                        TempData["Mensaje"] = "EL USUARIO FUE CREADO CON EXITO";

                        return RedirectToAction("Index", "Home");
                      }
                    else
                    {
                        //aca muestro un mensaje que ese nombre de usuario ya existe y pregunto si olvido su contraseña
                        TempData["Mensaje"] = "el usuario ya exite intente de nuevo con otro nombre";
                    }                

                    
                }
                return RedirectToAction("Index");

            }
            else
            {
                TempData["Mensaje"] = "los campos no coinciden vuelva a intentarlo";
                return RedirectToAction("Index");
            }
        }


        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            using (HotelContext db = new HotelContext())
            {
                Usuarios usuario = db.Usuarios.FirstOrDefault(u => u.Email == email && u.Password == password);
                if(usuario != null)
                {
                    //login correcto
                    Session["UsuarioLogueado"] = usuario;
                }
                else
                {
                    //o no existe o esta mal la contraseña
                    TempData["Error"] = "El usuario no existe o esta mal la password.";
                }
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            Session.Clear();
            //Session["UsuarioLogueado"] = null;
            return RedirectToAction("Index", "Home");
        }

        public ActionResult MisReservas()
        {
            if(Session["UsuarioLogueado"] == null)
            {
                return RedirectToAction("Reservas", "Home");
            }

            Usuarios usuario = (Usuarios)Session["UsuarioLogueado"];
            return View(usuario);
        }
    }
}