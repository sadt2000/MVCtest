﻿using MVCtest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCtest.Controllers
{
    public class categoriesrepositoryController : Controller
    {
        ICategoryRepository repository = new CategoryRepository();

        //IGeneric<Categories> db = new Generic<Categories>();

        // GET: categoriesrepository
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }  
       
        public ActionResult Creat(Categories categories)
        {
            if (Request.Form.Count > 0)
            {
                //Categories category = new Categories();
                //category.CategoryName = Request.Form["CategoryName"];
                //category.Description = Request.Form["Description"];


                repository.Creat(categories);
                 return RedirectToAction("Index");
            }

            return View();
        }


        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            return View(repository.GetById(id));
        }
        [HttpPost]
        public ActionResult Edit( Categories categories)
        {
            //Categories categorie = new Categories();
            //categorie.CategoryID = Convert.ToInt32(Request.Form["CategoryID"]);
            //categorie.CategoryName = Request.Form["CategoryName"];
            //categorie.Description = Request.Form["Description"];

            repository.Update(categories);
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id = 0)
        {
            repository.Delete(repository.GetById(id));
            return RedirectToAction("Index");
        }

    }
}