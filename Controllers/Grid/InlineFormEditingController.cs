﻿using MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class GridController : Controller
    {
        //
        // GET: /InlineFormEditing/

        public ActionResult InlineFormEditing()
        {
            var DataSource = OrderRepository.GetAllRecords();
            ViewBag.datasource = DataSource;
            return View();
        }

        public ActionResult InlineUpdate(EditableOrder value)
        {
            OrderRepository.Update(value);
            var data = OrderRepository.GetAllRecords();
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public ActionResult InlineInsert(EditableOrder value)
        {
            OrderRepository.Add(value);
            var data = OrderRepository.GetAllRecords();
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public ActionResult InlineDelete(int key)
        {
            OrderRepository.Delete(key);
            var data = OrderRepository.GetAllRecords();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}