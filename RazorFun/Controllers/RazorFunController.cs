using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RazorFun.Controllers
{   
    public class RazorFunController : Controller
    {
        // Index
        [HttpGet]
        [Route ("")]
        public ViewResult Index ()
        {
            return View ();
        }
    }
}