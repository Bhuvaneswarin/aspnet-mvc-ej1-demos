#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.EJ.ReportWriter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSampleBrowser.Controllers
{
    public partial class ReportWriterController : Controller
    {
        // GET: ProductLineSales
        public ActionResult ProductLineSales()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ProductLineSales(string writerFormat)
        {
            try
            {
                string fileName = null;
                WriterFormat format;
                HttpContext httpContext = System.Web.HttpContext.Current;
                ReportWriter reportWriter = new ReportWriter();
                reportWriter.ReportProcessingMode = ProcessingMode.Remote;
                reportWriter.ReportPath = Server.MapPath("~/App_Data/Reports/ProductLineSales.rdl");

                if (writerFormat == "PDF")
                {
                    fileName = "ProductLineSales.pdf";
                    format = WriterFormat.PDF;
                }
                else if (writerFormat == "Word")
                {
                    fileName = "ProductLineSales.doc";
                    format = WriterFormat.Word;
                }
                else if (writerFormat == "Html")
                {
                    fileName = "ProductLineSales.Html";
                    format = WriterFormat.HTML;
                }
                else
                {
                    fileName = "ProductLineSales.xls";
                    format = WriterFormat.Excel;
                }
                reportWriter.Save(fileName, format, httpContext.Response);
            }
            catch { }

            return View();
        }
    }
}