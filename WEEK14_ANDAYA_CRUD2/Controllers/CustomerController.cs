using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEEK14_ANDAYA_CRUD2.Models;
using System.Data.Entity;

namespace WEEK14_ANDAYA_CRUD2.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())

            {

                return
                View(dbModel.Customers.ToList());

            }
        }



        // GET: Customer/Details/5
        public ActionResult Details(int id)

        {

            using (DbModels dbModel = new
            DbModels())

            {
                return
              View(dbModel.Customers.Where(x =>
              x.Id == id).FirstOrDefault());

            }

        }

        // GET: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {

                    dbModel.Customers.Add(customer);
                    dbModel.SaveChanges();

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            
        }

        // POST: Customer/Create
        public ActionResult Create()
        {
          
            return View();
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)

        {

            using (DbModels dbModel =
            new DbModels())

            {

                return
                View(dbModel.Customers.Where(x
                => x.Id == id).FirstOrDefault());

            }

        }

        // POST: Customer/Edit/5
        [HttpPost]

        public ActionResult Edit(int id, Customer customer)

        {

            try

            {

                using (DbModels dbModel = new
                DbModels())

                {

                    dbModel.Entry(customer).State =
                    EntityState.Modified;

                    dbModel.SaveChanges();

                }

                return RedirectToAction("Index");

            }

            catch

            {

                return View();

            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)

        {

            using (DbModels dbModel = new
            DbModels())

            {

                return
                View(dbModel.Customers.Where(x => x.Id == id).FirstOrDefault());

            }

        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,
FormCollection collection)

        {
            try
            {

                using (DbModels dbModel = new
                DbModels())

                {

                    Customer customer =
                    dbModel.Customers.Where(x => x.Id ==
                    id).FirstOrDefault();

                    dbModel.Customers.Remove(customer);

                    dbModel.SaveChanges();

                }

                return RedirectToAction("Index");

            }

            catch
            {

                return View();

            }
        }
    }
}
