#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Web.Mvc;

namespace MVCSampleBrowser.Areas.SalesSummary
{
    public class SalesSummaryAreaRegistration :AreaRegistration
    {
        public override string AreaName
        {
            get 
            { 
                return "SalesSummary"; 
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
             context.MapRoute(
                "SalesSummary_default",
                "SalesSummary/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}