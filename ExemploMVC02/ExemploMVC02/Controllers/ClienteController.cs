using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExemploMVC02.Models;
namespace ExemploMVC02.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lista(string stringId)
        {
            
            var lstClientes = new List<Cliente>
            {

               new Cliente() {FCLICOD = 1 , FNOME =  "Adamastor", FCPF = "312321", FENDERECO =" Rua i" },
               new Cliente() {FCLICOD = 2 , FNOME = "Nad alegal", FCPF = "3213213", FENDERECO = "Rua das ruas" }


            };

            if (stringId != ""  && stringId != null)
            lstClientes= lstClientes.Where(c => c.FNOME == stringId).ToList(); 

            return View(lstClientes);
        }
    }
}