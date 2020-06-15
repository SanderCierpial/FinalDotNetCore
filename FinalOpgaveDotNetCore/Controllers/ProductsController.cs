using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace FinalOpgaveDotNetCore.Controllers
{
    public class ProductsController : Controller
    {
        IProductService productService;
        IShoppingItemService shoppingItemService;
        IShoppingBagService shoppingBagService;
        ICustomerService customerService;
        public ProductsController(IProductService _productService, IShoppingItemService _shoppingItemService, IShoppingBagService _shoppingBagService, ICustomerService _customerService)
        {
            productService = _productService;
            shoppingItemService = _shoppingItemService;
            shoppingBagService = _shoppingBagService;
            customerService = _customerService;
        }


        public IActionResult Index()
        {
            List<Product> products = productService.GetAllProducts();
            ViewData["1"] = "/images/items/item1.jpg";
            ViewData["2"] = "/images/items/item2.jpg";
            ViewData["3"] = "/images/items/item3.jpg";
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            ViewData["1"] = "/images/items/item1.jpg";
            ViewData["2"] = "/images/items/item2.jpg";
            ViewData["3"] = "/images/items/item3.jpg";
            Product product = productService.FindProductById(id);
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ShoppingBag(int id, string quantity)
        {
            ViewData["1"] = "/images/items/item1.jpg";
            ViewData["2"] = "/images/items/item2.jpg";
            ViewData["3"] = "/images/items/item3.jpg";
            Product product = productService.FindProductById(id);
            int r = int.Parse(quantity);
            ShoppingItem shoppingItem = new ShoppingItem()
            {
                Quantity = r,
                Product = product
            };
            if (shoppingBagService.LastOrDefault()==null)
            {
                List<ShoppingItem> shoppingItems = new List<ShoppingItem>();
                shoppingItems.Add(shoppingItem);
                Customer customer = customerService.FindCustomerById(1);
                ShoppingBag shoppingBag = new ShoppingBag()
                {
                    Date = DateTime.Now,
                    Customer = customer,
                    ShoppingItems = shoppingItems
                };
                shoppingBagService.SaveShoppingBag(shoppingBag);
                shoppingBagService.CalculateShoppingBag(shoppingBag);
                return View(shoppingBag);
            }
            ShoppingBag currentbag = shoppingBagService.LastOrDefault();
            currentbag.ShoppingItems = shoppingItemService.GetAllShoppingItemsByBagId(currentbag.Id);
            foreach (var item in currentbag.ShoppingItems)
            {
                item.Product = productService.FindProductById(item.ProductId);
            }
            if (shoppingItemService.GetAllShoppingItemsByBagId(currentbag.Id) == null)
            {
                List<ShoppingItem> shoppingItems = new List<ShoppingItem>();
                shoppingItems.Add(shoppingItem);
                Customer customer = customerService.FindCustomerById(1);
                ShoppingBag shoppingBag = new ShoppingBag()
                {
                    Date = DateTime.Now,
                    Customer = customer,
                    ShoppingItems = shoppingItems
                };
                shoppingBagService.SaveShoppingBag(shoppingBag);
                shoppingBagService.CalculateShoppingBag(shoppingBag);
                return View(shoppingBag);
            }
            if (shoppingItemService.FindShoppingItemByProductId(id) != null)
            {
                ShoppingItem item = shoppingItemService.FindShoppingItemByProductId(id);
                item.Quantity += r;
                shoppingItemService.UpdateShoppingItem(item);
            }
            else
            {
                currentbag.ShoppingItems.Add(shoppingItem);
            }
            shoppingBagService.UpdateShoppingBag(currentbag);
            shoppingBagService.CalculateShoppingBag(currentbag);
            return View(currentbag);
        }

        public IActionResult ShoppingBag()
        {
            ViewData["1"] = "/images/items/item1.jpg";
            ViewData["2"] = "/images/items/item2.jpg";
            ViewData["3"] = "/images/items/item3.jpg";
            ShoppingBag shoppingBag = shoppingBagService.LastOrDefault();
            shoppingBag.ShoppingItems = shoppingItemService.GetAllShoppingItemsByBagId(shoppingBag.Id);
            foreach (var item in shoppingBag.ShoppingItems)
            {
                item.Product = productService.FindProductById(item.ProductId);
            }
            shoppingBagService.UpdateShoppingBag(shoppingBag);
            shoppingBagService.CalculateShoppingBag(shoppingBag);
            return View(shoppingBag);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            shoppingItemService.DeleteShoppingItem(id);
            return RedirectToAction("ShoppingBag");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, string quantity)
        {
            int r = int.Parse(quantity);
            ShoppingItem item = shoppingItemService.FindShoppingItemById(id);
            item.Quantity = r;
            shoppingItemService.UpdateShoppingItem(item);
            return RedirectToAction("ShoppingBag");
        }
    }
}