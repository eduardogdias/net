using cp2.Models;
using Microsoft.AspNetCore.Mvc;

namespace cp2.Controllers
{
    public class MotoController : Controller
    {
        private static List<Moto> motos = new List<Moto>();

        // Read =========================================================================
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MotoView()
        {
            return View(motos);
        }

        public IActionResult PlacaCadastrada()
        {
            return View();
        }



        // Create =========================================================================
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Moto moto)
        {
            foreach(var m in motos){
                if(moto.Placa == m.Placa)
                {
                    Console.WriteLine("Moto com placa já cadastrada");
                    return RedirectToAction("PlacaCadastrada");
                }
            }
            motos.Add(moto);
            return RedirectToAction("MotoView");
        }



        // Update =========================================================================
        public IActionResult Update(string placa)
        {
            Moto moto = motos.FirstOrDefault(m => m.Placa == placa);
            if (moto == null)
            {
                return NotFound();
            }
            return View(moto);
        }

        [HttpPost]
        public IActionResult Update(Moto moto)
        {
            int index = motos.FindIndex(m => m.Placa == moto.Placa);
            if (index == -1)
            {
                return NotFound();
            }
            motos[index] = moto;
            return RedirectToAction("MotoView");
        }



        // Delete =========================================================================
        public IActionResult Delete(string placa)
        {
            Moto moto = motos.FirstOrDefault(m => m.Placa == placa);
            if (moto == null)
            {
                return NotFound();
            }
            return View(moto);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(string placa)
        {
            Moto moto = motos.FirstOrDefault(m => m.Placa == placa);
            if (moto == null)
            {
                return NotFound();
            }
            motos.Remove(moto);
            return RedirectToAction("MotoView");
        }

    }
}
