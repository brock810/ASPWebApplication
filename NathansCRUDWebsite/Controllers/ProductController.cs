using System;
using Microsoft.AspNetCore.Mvc;
using NathansCRUDWebsite.Models;
using Renci.SshNet;

namespace NathansCRUDWebsite.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
         
            return View();
        }
    }
}