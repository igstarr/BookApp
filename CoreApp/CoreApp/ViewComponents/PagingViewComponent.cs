using Biz.Interface;
using Biz.Logic;
using CoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.ViewComponents
{
    public class PagingViewComponent : ViewComponent
    {
        private readonly IBookService _bookService;

        public PagingViewComponent(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IViewComponentResult Invoke(SortFilterPageOptions sortFilterPageData)
        {
            var model = new PagingViewModel
            {
                SortFilterPageData = sortFilterPageData
            };
            model.TotalCount = _bookService.GetBooksTotalCount(sortFilterPageData).Count();
            
            return View(model);
        }
    }
}
