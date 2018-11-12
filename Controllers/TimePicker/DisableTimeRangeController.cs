﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class TimePickerController : Controller
    {
        //
        // GET: /TimePickerDefault/

        public ActionResult DisableTimeRange()
        {
            TimePickerProperties propModel = new TimePickerProperties();
            List<DisableTimeRange> disableList = new List<Syncfusion.JavaScript.Models.DisableTimeRange>();
            disableList.Add(new DisableTimeRange { StartTime = "3:00 AM", EndTime = "6:00 AM" });
            disableList.Add(new DisableTimeRange { StartTime = "1:00 PM", EndTime = "3:00 PM" });
            disableList.Add(new DisableTimeRange { StartTime = "8:00 PM", EndTime = "10:00 PM" });

            propModel.DisableTimeRanges = disableList;
            return View(propModel);
        }

    }
}