using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Entities;
using MemoApp.Models;

namespace MemoApp.Controllers
{
    public class HomeController : Controller
    {
        public Model myModel = new Model();

        // Initial Run.
        // List all records.
        public ActionResult Index()
        {
            var records = myModel.GetList();

            return View(records);
        }
        /*
        public ActionResult Index()
        {
            ContactBAL db = new ContactBAL();
            var records = db.GetAll();

            return View(records);
        }*/

        [HttpGet]
        // Add a record.
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        // Return to view after adding a record.
        public ActionResult Create(Contact p)
        {
            ContactBAL db = new ContactBAL();
            db.add(p);
            return RedirectToAction("Index");
        }

        // View details of a single record.
        public ActionResult Details(int id)
        {
            ContactBAL db = new ContactBAL();
            var currentRecord = db.Details(id);
            return View(currentRecord);
        }
        // Return to view after deleting.
        public ActionResult Delete(int id)
        {
            ContactBAL db = new ContactBAL();
            db.DeleteRecord(id);

            return RedirectToAction("Index");
        }
        [HttpGet]
        // Update a record
        public ActionResult Edit(int id)
        {
            ContactBAL db = new ContactBAL();
            var record = db.Details(id);
            return View(record);
        }
        [HttpPost]
        // Return to view after updating.
        public ActionResult Edit(Contact c)
        {
            ContactBAL db = new ContactBAL();
            db.Update(c);
            return RedirectToAction("Index");
        }
    }
}