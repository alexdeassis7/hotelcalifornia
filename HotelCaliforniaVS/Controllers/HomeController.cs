using HotelCaliforniaVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace HotelCaliforniaVS.Controllers
{
    public class HomeController : Controller
    {
        HotelContext db = new HotelContext();

        public ActionResult Index()
        {
            List<Reservas> reservas = new List<Reservas>();
            reservas = db.Reservas.OrderByDescending(a => a.FechaIngreso).Take(10).ToList();
            ViewBag.Reservas = reservas;
                    return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult reservas()
        {
            ViewBag.Message = "pagina de reservas page.";

            return View();
        }


        public ActionResult Contacto()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult VistaDelHotel()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult habitaciones()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CrearCuenta()
        {
            ViewBag.Message = "crear cuenta nueva.";

            return View();
        }

        public ActionResult UsuariosRegistrados()
        {
            ViewBag.Message = "Usuarios Registrados.";

            return View();
        }

    

        //accion de formulario de contacto para mandar el mail
        [HttpPost]
        public ActionResult Contacto(string nombre, string correo, int telefono, string mensaje)
        {
            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com",587);
            //clienteSmtp.Host = "smtp.gmail.com";
            //clienteSmtp.Port = 465 ;
            clienteSmtp.Credentials = new NetworkCredential("alexdeassis7@gmail.com", "1787742836863837");
            clienteSmtp.EnableSsl = true;


            //creamos el mail para el dueño de la app

            MailMessage mensajeParaLaApp = new MailMessage();
            mensajeParaLaApp.From = new MailAddress("alexdeassis7@gmail.com", "Alex de Assis Gerente compania");
            mensajeParaLaApp.To.Add("alexdeassis7@gmail.com");
            mensajeParaLaApp.Subject = "Contacto del hotel california";
            mensajeParaLaApp.Body = nombre + "(" + correo  + ") te contacto desde la web del hotel <br> El mensaje fue : <b> " + mensaje + " <br> TELEFONO" + telefono;

            //mando el mail al dueño de la app
            
            //SI TENGO PROBLEMAS DE SERTIFICADO EJECUTO ESTA PORCION DE COGIDO
            // ServicePointManager.ServerCertificateValidationCallback =

            //delegate (object s              , X509Certificate certificate

            //  , X509Chain chain

            //, SslPolicyErrors sslPolicyErrors)

            //{ return true; };

            clienteSmtp.Send(mensajeParaLaApp);

            //mando mail al usuario que se contacto
            MailMessage mensajeParaUsuario = new MailMessage();
            mensajeParaUsuario.From = new MailAddress("alexdeassis7@gmail.com");
            mensajeParaUsuario.To.Add(correo);
            mensajeParaUsuario.Subject = "gracias por contactarte al hoteel";
            mensajeParaUsuario.IsBodyHtml = true;
            mensajeParaUsuario.Body = "hola " + nombre + ",<br> Gracias por contactarte con nostros!<br> tu mensaje fue : <b> " + mensaje + "</b>EL equipo del hotel<br><img src=\"ruta url de la imagen\">";

           clienteSmtp.Send(mensajeParaUsuario);


            ViewBag.Nombre = nombre + " Nos comunicaremos con usted a la brevedad";
            return View();//aca devolvemos una vista en este caso es la vista de "contacto " si creamos una vista 
            //con otros nombre diferente al nombre del metodo  tenemos que especificarlo entre medio de los ()

           // return RedirectToAction("Index");//cuando termina me manda al index de nuevo

        }
    }
}