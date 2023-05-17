using Microsoft.AspNetCore.Mvc;
using ParcialPresentacionWeb3Servicio;

namespace ParcialPresentacionWeb3.Controllers
{
    public class Ventas : Controller
    {

        private IClienteServicio _IClienteServicio;

        public Ventas(IClienteServicio iClienteServicio) { 
            _IClienteServicio = iClienteServicio;
        }



        public IActionResult RegistrarVenta()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VerResultados() 
        {
            return View(_IClienteServicio.listaClientes());

            
        }


        [HttpPost]
        public IActionResult RegistrarVentas(String cliente, int cantidadVendida, int precioUnitario) {

            /*try {
                int resultado = _IClienteServicio.RegistrarVenta(cliente, cantidadVendida, precioUnitario);
                ViewBag.Total = "El total es:";
                ViewBag.Resultado = resultado;
                return View("RegistrarVenta");
            }

            catch (Exception ex)
            {

                ViewBag.MensajeError = ex.Message;
            }*/

            double resultado = _IClienteServicio.RegistrarVenta(cliente, cantidadVendida, precioUnitario);
            ViewBag.Total = "El total es:";
            ViewBag.Resultado = resultado;
            return View("RegistrarVenta");

           /* return View("RegistrarVenta");*/
        
        
        }

    }
}
