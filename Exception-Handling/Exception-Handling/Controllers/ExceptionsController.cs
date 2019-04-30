using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exception_Handling.Controllers
{
    public class ExceptionsController : Controller
    {
        // GET: Exceptions
        //[HandleError()]
       // [HandleError(ExceptionType = typeof(DivideByZeroException), View = "DividebyZeroException")]
        public ActionResult Index()
        {
            //throw new Exception("test");
            int i = 0;
            int j = 10;
            int k = j / i;

            return View();

        }

        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            //Log the error!!
           // _Logger.Error(filterContext.Exception);
            //Redirect or return a view, but not both.
            filterContext.Result = RedirectToAction("Index", "ErrorHandler");
            // OR 
            //filterContext.Result = new ViewResult
            //{
            //    ViewName = "~/Views/ErrorHandler/Index.cshtml"
            //};
        }

    }
  
}