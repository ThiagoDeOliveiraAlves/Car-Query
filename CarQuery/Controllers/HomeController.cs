﻿using CarQuery.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CarQuery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarouselRepository _carouselRepository;

        public HomeController(ICarouselRepository carouselRepository)
        {
            _carouselRepository = carouselRepository;
        }

        public async Task<IActionResult> Index()
        {
            var carousels = await _carouselRepository.GetAllVisibleCarouselsToDisplay();
            return View(carousels);
        }
    }
}
