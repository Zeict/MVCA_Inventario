using MVCA_Inventario.Models;
using MVCA_Inventario.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCA_Inventario.Controllers
{
    public class HomeController : Controller
    {

        private readonly IRepository _repository;
        public HomeController(IRepository repository)
        {
            _repository = repository;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult Consultar()
        {
            return View();
        }

        public ActionResult Inventario()
        {
            return View();
        }

        [HttpGet]
        public ActionResult getProduct()
        {
            List<Product> list = new List<Product>();

            list = _repository.GetProducts();

            string json_data = JsonConvert.SerializeObject(list);

            return Json(json_data, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult addProduct(Product ProdDetails)
        {
            string result = _repository.addProduct(ProdDetails);


            List<Product> list = new List<Product>();
            list = _repository.GetProducts();

            string json_data = JsonConvert.SerializeObject(list);

            return Json(json_data, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult updateProduct(Product ProdDetails)
        {
            string result = _repository.updateProduct(ProdDetails);

            List<Product> list = new List<Product>();
            list = _repository.GetProducts();

            string json_data = JsonConvert.SerializeObject(list);

            return Json(json_data, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult deleteProduct(Product ProdDetails)
        {
            string result = _repository.deleteProduct(ProdDetails);

            List<Product> list = new List<Product>();
            list = _repository.GetProducts();

            string json_data = JsonConvert.SerializeObject(list);

            return Json(json_data, JsonRequestBehavior.AllowGet);
        }


    }
}