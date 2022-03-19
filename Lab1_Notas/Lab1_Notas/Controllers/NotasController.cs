using Lab1_Notas.Bussines;
using Lab1_Notas.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1_Notas.Controllers
{
    public class NotasController : Controller
    {
        public IActionResult Index()

        {

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult index_(Acciones acciones)
        {
            if (acciones.monto % 5 == 0)

               
                ViewBag.variableaenviar = "Puede retirar su dinero";
         

            else
            {
                return View("Error");
            }

            return View("index_");

            


        }


    }
       
    }

