﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSampleBrowser.Models;

namespace MVCSampleBrowser.Controllers
{
    public partial class RotatorController : Controller
    {
        //
        // GET: /RotatorThumbnail/
        List<localdata> LocalElement = new List<localdata>();
        public ActionResult Thumbnail()
        {
            LocalElement.Add(new localdata { text = "green", url = "../Images/rotator/green.jpg" });
            LocalElement.Add(new localdata { text = "snow", url = "../Images/rotator/snow.jpg" });
            LocalElement.Add(new localdata { text = "wheat", url = "../Images/rotator/wheat.jpg" });
            LocalElement.Add(new localdata { text = "tablet", url = "../Images/rotator/tablet.jpg" });
            LocalElement.Add(new localdata { text = "sea", url = "../Images/rotator/sea.jpg" });
            LocalElement.Add(new localdata { text = "bread", url = "../Images/rotator/bread.jpg" });
            LocalElement.Add(new localdata { text = "snowfall", url = "../Images/rotator/snowfall.jpg" });
            ViewBag.datasource = LocalElement;
            return View();
        }

    }
}