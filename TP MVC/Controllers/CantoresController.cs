using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_TP.Services;

namespace TP_MVC.Controllers
{
    public class CantoresController : Controller
    {
        protected readonly Repositorio repositorio = new Repositorio();
        // GET: Cantores
        public ActionResult Index()
        {
            return View(repositorio.GetCantores());
        }

        // GET: Cantores/Details/5
        public ActionResult Details(int id)
        {
            return View(repositorio.GetCantoresByID(id));
        }

        // GET: Cantores/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}
