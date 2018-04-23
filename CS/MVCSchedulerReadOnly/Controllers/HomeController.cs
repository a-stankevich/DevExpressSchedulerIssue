using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using MVCSchedulerReadOnly.Models;

namespace MVCSchedulerReadOnly.Views
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        #region #commonactions
        public ActionResult Index()
        {
            return View(SchedulerDataHelper.DataObject);
        }

        public ActionResult SchedulerPartial()
        {
            return PartialView("SchedulerPartial", SchedulerDataHelper.DataObject);
        }
        #endregion #commonactions

    }
}
