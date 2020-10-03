using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProduct.Models;
using MVCProduct.Repository;

namespace MVCProduct.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult GetAllProductDetails()
        {
            PrdRepository PrdRepo = new PrdRepository();
            ModelState.Clear();
            return View(PrdRepo.GetAllProducts());
        }

        // GET: Product
      /*  public ActionResult Index()
        {
            return View();
        }*/

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            PrdRepository PrdRepo = new PrdRepository();
            return View(PrdRepo.GetAllProducts().Find(ProductModel => ProductModel.Prdid == id));
        }

        // GET: Product/Create
        public ActionResult AddProduct()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult AddProduct(ProductModel Prd)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    PrdRepository PrdRepo = new PrdRepository();

                    if (PrdRepo.AddProduct(Prd))
                    {
                        ViewBag.Message = "Product details added successfully";
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult EditProductDetails(int id)
        {
            PrdRepository PrdRepo = new PrdRepository();

            return View(PrdRepo.GetAllProducts().Find(ProductModel => ProductModel.Prdid == id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult EditProductDetails(int id, ProductModel obj)
        {
            try
            {
                PrdRepository PrdRepo = new PrdRepository();

                PrdRepo.UpdateProduct(obj);

                return RedirectToAction("GetAllProductDetails");
            }
            catch
            {
                return View();
            }
        }


        // GET: Product/Delete/5
        public ActionResult DeleteProduct(int id)
        {
            try
            {
                PrdRepository PrdRepo = new PrdRepository();
                if (PrdRepo.DeleteProduct(id))
                {
                    ViewBag.AlertMsg = "Product details deleted successfully";

                }
                return RedirectToAction("GetAllProductDetails");

            }
            catch
            {
                return View();
            }
        }       
     }
  }
