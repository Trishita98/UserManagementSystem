using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TsignupController : Controller
    {
        // GET: Tsignup
        public ActionResult Index()
        {
            using (training_dbEntities dbmodel = new training_dbEntities())
            {
                return View(dbmodel.TUsers.ToList());
            }

        }

        // GET: Tsignup/Details/5
        public ActionResult Details(int id)
        {
            using (training_dbEntities dbModel = new training_dbEntities())
            {
                return View(dbModel.TUsers.Where(x => x.UserID == id).FirstOrDefault());
            }

        }

        // GET: Tsignup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tsignup/Create
        [HttpPost]
        public ActionResult Create(TUser customer)
        {
            try
            {
                // TODO: Add insert logic here



                using (training_dbEntities dbModel = new training_dbEntities())
                {
                    dbModel.TUsers.Add(customer);
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tsignup/Edit/5
        public ActionResult Edit(int id)
        {
            using (training_dbEntities dbModel = new training_dbEntities())
            {
                return View(dbModel.TUsers.Where(x => x.UserID == id).FirstOrDefault());
            }

        }

        // POST: Tsignup/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TUser customer)
        {
            try
            {
                using (training_dbEntities dbModel = new training_dbEntities())
                {
                    dbModel.Entry(customer).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }
                // TODO: Add update logic here



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tsignup/Delete/5
        public ActionResult Delete(int id)
        {
            using (training_dbEntities dbModel = new training_dbEntities())
            {
                return View(dbModel.TUsers.Where(x => x.UserID == id).FirstOrDefault());
            }
        }

        // POST: Tsignup/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (training_dbEntities dbModel = new training_dbEntities())
                {
                    TUser customer = dbModel.TUsers.Where(x => x.UserID == id).FirstOrDefault();
                    dbModel.TUsers.Remove(customer);
                    dbModel.SaveChanges();
                }
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
