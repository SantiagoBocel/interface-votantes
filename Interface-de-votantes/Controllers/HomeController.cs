using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Interface_de_votantes.Models;
using Interface_de_votantes.Services;

namespace Interface_de_votantes.Controllers
{
    public class HomeController : Controller
    {
        Storage Temp = Storage.GetInstance();

        public IActionResult Index(string dpi, int depto, int presi, int alcalde, int boletadiputadodistrito, int boletadiputadonacional, string fecha)
        {
            if (dpi >= 1000000000000 && dpi <= 9999999999999)// condicion para que unicamente con 13 cifras se pueda mandar el dpi
            {
                Temp.Listado.Add(new Votantes()
                {
                    id = Temp.Listado.Count,
                    depto = depto,
                    dpi = dpi,
                    boleta_presidente = presi,
                    boleta_alcalde = alcalde,
                    boleta_diputados_distrito = boletadiputadodistrito,
                    boleta_diputado_nacional = boletadiputadonacional,
                    fecha_hora = fecha,

                    ViewBag.Message = "El dpi ha sido ingresado al registro"//mensaje para el script

            })
             ;
            }
            else if (dpi > 9999999999999 || dpi < 1000000000000)// condicion para el caso en el que no se ingresen 13 cifras mande el sig mensaje 
            {
                ViewBag.Message = "El numero de DPI no ha sido ingresado, debe tener exactamente 13 cifras";
            }

            return View("Index", Temp);
        }

        public IEnumerable<Votantes> Get()
        {
            return Temp.Listado;
        }
    }
}
