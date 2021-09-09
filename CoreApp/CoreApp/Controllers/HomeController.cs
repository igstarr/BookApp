using AutoMapper;
using Biz.Interface;
using Biz.Logic;
using CoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService _book;
        private readonly IMapper _mapper;
        public HomeController(ILogger<HomeController> logger, IBookService book, IMapper mapper)
        {
            _logger = logger;
            _book = book;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index(SortFilterPageOptions options)
        {
            var bookList = _book.GetBooks(options);

            var booklistComplete = await bookList.ToListAsync();
            var books = _mapper.Map<List<BookViewModel>>(booklistComplete);
            var model = new BookViewModelList(options, books);
            //string imageBase64Data = Convert.ToBase64String(model.CoverImageData);
            //model.displayImage = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateIndex(SortFilterPageOptions options)
        {
            var bookList = _book.GetBooks(options);

            var booklistComplete = await bookList.ToListAsync();
            var books = _mapper.Map<List<BookViewModel>>(booklistComplete);
            var model = new BookViewModelList(options, books);
            //string imageBase64Data = Convert.ToBase64String(model.CoverImageData);
            //model.displayImage = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
            return View("Index", model);
        }



        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> SeedBooks()
        {


            var item = await _book.SeedBooks();


            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
