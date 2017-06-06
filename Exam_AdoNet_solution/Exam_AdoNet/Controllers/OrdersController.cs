using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Exam_AdoNet.Models;
using Exam_AdoNet.Models.DbModels;

namespace Exam_AdoNet.Controllers
{
    public class OrdersController : Controller
    {
        private StoreDbContext db = new StoreDbContext();

        // GET: Orders
        public ActionResult Index()
        {
            return View(db.Orders.Include(o=>o.User).ToList());
        }

        public ActionResult GetUserOrders(int? userId)
        {
            if (userId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //db.Orders.Include(o => o.User);
            var orders = db.Orders.Where(o => o.User.Id == userId).Include(o => o.User);

            return View("Index", orders.ToList());
        }


        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            ViewBag.Users = new SelectList(db.Users, "Id", "LName");
            ViewBag.Goods = new SelectList(db.Goods, "Id", "Name");
            
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date")] Order order)
        {
            int selectedUserId = Convert.ToInt32(ValueProvider.GetValue("Users").AttemptedValue);
            int selectedGoodId = Convert.ToInt32(ValueProvider.GetValue("Goods").AttemptedValue);
            int goodQuantity = Convert.ToInt32(ValueProvider.GetValue("Quantity").AttemptedValue);

            User user = db.Users.Find(selectedUserId);
            Good good = db.Goods.Find(selectedGoodId);
            OrderItem orderItem = new OrderItem { Good = good, Order = order, Quantity = goodQuantity};

            db.OrderItems.Add(orderItem);
            order.User = user;
            order.OrderItems.Add(orderItem);

            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Date")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
