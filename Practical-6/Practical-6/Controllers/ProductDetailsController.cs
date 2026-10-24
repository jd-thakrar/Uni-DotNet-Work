using Practical_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_6.Controllers
{
    public class ProductDetailsController : Controller
    {
        // GET: ProductDetails
        public ActionResult Index()
        {
            List<ProductDetails> P = GetData();
            
            return View("Product", P);
        }

        public ActionResult Details(int id)
        {
            List<ProductDetails> pall = GetData();
            ProductDetails p = new ProductDetails();
            p = pall.FirstOrDefault(x => x.id == id);
            return View("Details", p);
        }

        public List<ProductDetails> GetData()
        {

            List<ProductDetails> P = new List<ProductDetails>();

            ProductDetails p1 = new ProductDetails();
            p1.id = 1;
            p1.imageUrl = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSIxThfb1NeN5a1nd9aS9akzWXKflkpcAmVpJg5DmQxOHNvgGV_WwFMWebnn8W4JMp_17RusDurmmMNKDNG9HUhLZYj-CqeBkRAk-VAcChvsEuuFdVf-pTDjJ0";
            p1.name = "Macbook";
            p1.category = "Laptop";
            p1.description = "Have a Premium Experience with Mac";
            p1.price = 125000;

            ProductDetails p2 = new ProductDetails();
            p2.id = 2;
            p2.imageUrl = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcQnEyJKAMpPsGtu7nAwExiwIfGw3M7nSK__UMia5r9zk3FQYvPZd3WbIHao80rK4O44Re4v232dzh43YxqGUqPAGMSFejBoF6vJCNiWpTeMkXVgorBIxMVV_iI";
            p2.name = "Iphone";
            p2.category = "Mobile";
            p2.description = "Flagship Smartphome";
            p2.price = 100000;

            ProductDetails p3 = new ProductDetails();
            p3.id = 3;
            p3.imageUrl = "https://media-ik.croma.com/Croma%20Assets/Computers%20Peripherals/Laptop/Images/323258_0_2IVmGYybG.png?updatedAt=1783326925974&tr=w-640";
            p3.name = "Omen";
            p3.category = "Laptop";
            p3.description = "Seamless Gaming Experience with omen";
            p3.price = 150000;

            P.Add(p1);
            P.Add(p2);
            P.Add(p3);

            return P;
        }
    }
}