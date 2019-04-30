using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace ServerValidation.Controllers
{
    public class UserController : Controller
    {        
        public ActionResult Index()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult Index(ServerValidation.Models.User model)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                ModelState.AddModelError("Name", "Name is required");
            }
            if (!string.IsNullOrEmpty(model.Email))
            {
                string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex re = new Regex(emailRegex);
                if (!re.IsMatch(model.Email))
                {
                    ModelState.AddModelError("Email", "Email is not valid");
                }
            }
            else
            {
                ModelState.AddModelError("Email", "Email is required");
            }
            if (ModelState.IsValid)
            {
                ViewBag.Name = model.Name;
                ViewBag.Email = model.Email;
            }
            return View(model);
        }
    }
}
