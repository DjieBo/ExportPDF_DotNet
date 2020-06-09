using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExportPDF.Models;
using Rotativa;
using Rotativa.Options;

namespace ExportPDF.Controllers
{
    public class ExecutiveController : Controller
    {
        ReportEntities context;
        public ExecutiveController()
        {
            context = new ReportEntities();
        }
        public ActionResult GetAll()
        {
            var Data = context.ExecutiveReports.ToList();
            return View(Data);
        }

        public ActionResult PrintAll()
        {
            var q = new ActionAsPdf("GetAll")
            {
                PageSize = Size.A4,
                PageOrientation = Orientation.Landscape,
                PageMargins = { Left = 0, Right = 0 }
            };
            return q;
        }

    }
}