﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class SpreadsheetController : Controller
    {
        //
        // GET: /ShowHide/

        public ActionResult ShowHide()
        {
            var dataSource = new OrderItemsDataContext().GetProductDetails().ToList();
            ViewBag.Datasource = dataSource;
            return View();
        }

    }
}