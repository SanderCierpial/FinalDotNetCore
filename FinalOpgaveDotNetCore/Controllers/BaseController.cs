using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace FinalOpgaveDotNetCore.Controllers
{
    public class BaseController : Controller
    {
        IProductService productService;
        IShoppingItemService shoppingItemService;
        IShoppingBagService shoppingBagService;
        ICustomerService customerService;
        public BaseController(IProductService _productService, IShoppingItemService _shoppingItemService, IShoppingBagService _shoppingBagService, ICustomerService _customerService)
        {
            productService = _productService;
            shoppingItemService = _shoppingItemService;
            shoppingBagService = _shoppingBagService;
            customerService = _customerService;
            ShoppingBag shoppingBag = shoppingBagService.LastOrDefault();
            int r = shoppingBag.ShoppingItems.Count();
            ViewData["nr"] = r;
        }

    }
}