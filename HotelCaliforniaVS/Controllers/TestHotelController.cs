using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelCaliforniaVS.Controllers
{
    public class TestHotelController : Controller
        {
        /// <summary>
        /// este metodo multiplica dos decimales
        /// </summary>
        /// <param name="o1"></param>
        /// <param name="o2"></param>
        /// <returns></returns>
        public decimal PruebaMultiplicacion(decimal o1, decimal o2)

        {
            return (o1 * 02);






    }
        // GET: TestHotel
        public ActionResult Index()
        {
            return View();
        }

        // GET: TestHotel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TestHotel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestHotel/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TestHotel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestHotel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TestHotel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestHotel/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
