using ShopBridge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopBridge.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {

            productClient pc = new productClient();
            ViewBag.listProducts = pc.productList();
            return View();
        }

        // GET: Inventory/Details/id
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inventory/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Inventory/Create
        [HttpPost]
        public ActionResult Create(Inventory inventory)
        {
            try
            {
                // TODO: Add insert logic here
                if(ModelState.IsValid)
                {
                    productClient pc = new productClient();
                    pc.createProduct(inventory);
                    return RedirectToAction("Index");
                }
                return View(inventory);
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventory/Edit/5
        public ActionResult Edit(int id)
        {
            Inventory inv = new Inventory();
            productClient pc = new productClient();
            var res = pc.searchProduct(id);
            inv.id = res.id;
            inv.name = res.name;
            inv.price = res.price;
            inv.noOfAvailibity = res.noOfAvailibity;
            inv.availbility = res.availbility;
            inv.description = res.description;

            return View(inv);
        }

        // POST: Inventory/Edit/5
        [HttpPost]
        public ActionResult Edit(Inventory inventory)
        {
            try
            {
                // TODO: Add update logic here
                if(ModelState.IsValid)
                {
                    productClient pc = new productClient();
                    pc.editProduct(inventory);
                    return RedirectToAction("Index");
                }
                return View(inventory);
             
            }
            catch
            {
                return View(inventory);
            }
        }

        // GET: Inventory/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                productClient pc = new productClient();
                pc.deleteProduct(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
           
        }

       
    }
}
