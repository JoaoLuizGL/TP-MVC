using Microsoft.AspNetCore.Mvc;
using MVC_TP.Services;
using TP_MVC.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TP_MVC.Controllers
{
        [Route("api/apicantores")]
        [ApiController]
        public class ApiCantoresController : ControllerBase
        {
            protected readonly Repositorio repo = new Repositorio();
            // GET: api/<ApiCantoresController>
            [HttpGet]
            public IEnumerable<Cantores> Get()
            {
                return repo.GetCantores();
            }
        }
}
