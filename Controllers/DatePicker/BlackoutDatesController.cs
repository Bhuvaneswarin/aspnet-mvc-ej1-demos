﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class DatePickerController : Controller
    {
        //
        // GET: /DatePicker BlackoutDates/

        public ActionResult BlackoutDates()
        {
            return View();
        }

    }
}