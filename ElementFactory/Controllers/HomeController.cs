﻿namespace ElementFactory.Controllers
{
    using ElementFactory.Core.Contracts.Service;
    using ElementFactory.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IChemicalElementService service;

        public HomeController(ILogger<HomeController> logger, 
            IChemicalElementService service) 
        {
            this.logger = logger;
            this.service = service;
        }

        public IActionResult Index()
        {
            return RedirectToAction("CreateRoles", "Role");
        }

        public async Task<IActionResult> LoadTable()
        {
            var elements = await this.service.GetAllAsync();
            var collection = elements.OrderBy(ce => ce.AtomicNumber).ToList();

            return View("Index", collection);
        }

        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, 
            NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            { RequestId = Activity.Current?.Id ?? 
            HttpContext.TraceIdentifier });
        }
    }
}