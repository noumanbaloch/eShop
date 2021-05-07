using eShop.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eShop.WebUI.Controllers
{
    public class BaksetController : Controller
    {
        IBasketService basketSerivce;
        public BaksetController(IBasketService basketService)
        {
            this.basketSerivce = basketService;
        }
        // GET: Bakset
        public ActionResult Index()
        {
            var model = basketSerivce.GetBasketItems(this.HttpContext);
            return View(model);
        }

        public ActionResult AddtoBasket(string Id)
        {
            basketSerivce.AddToBasket(this.HttpContext, Id);
            return View();
        }

        public ActionResult RemoveFromBasket(string Id)
        {
            basketSerivce.RemoveFromBasket(this.HttpContext, Id);

            return View();
        }

        public PartialViewResult BasketSummary()
        {
            var basketSummary = basketSerivce.GetBasketSummary(this.HttpContext);

            return PartialView(basketSummary);
        }
    }
}