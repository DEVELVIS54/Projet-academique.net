using System.Web.Mvc;
using TEST1WEB.Models;

namespace TEST1WEB.Controllers
{
    public class PhotoController : Controller
    {
        // GET: Photo/AfficherPhoto
        public ActionResult AfficherPhoto()
        {
            Photo ph = new Photo();
            ph.Title = "Ma photo";
            ph.Description = "c'est une photo de vacance";
            ph.Author = "Mr Ouedraogo";
            return View(ph);
        }
    }
}