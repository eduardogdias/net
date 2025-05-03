using cp2.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace cp2.Controllers
{
    public class PatioController : Controller
    {
        private static List<Patio> patios = new List<Patio>();

        // Read =========================================================================
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PatioView()
        {
            return View(patios);
        }

        public IActionResult NomeCadastrado()
        {
            return View();
        }

        // Create =========================================================================
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Patio patio)
        {
            patio.Id = patios.Count + 1;

            // Calcula a área total do pátio
            double areaPatio = patio.ComprimentoPatio * patio.LarguraPatio;

            // Define a área ocupada por cada moto
            double areaPorVaga = patio.ComprimentoVaga * patio.LarguraVaga;

            // Calcula a quantidade de vagas e arredonda para baixo
            patio.Vagas = (int)Math.Floor(areaPatio / areaPorVaga);

            patios.Add(patio);
            return RedirectToAction("PatioView");
        }



        //Update =========================================================================
            public IActionResult Update(int id)
        {
            Patio patio = patios.FirstOrDefault(p => p.Id == id);
            if (patio == null)
            {
                return NotFound();
            }
            return View(patio);
        }

        [HttpPost]
        public IActionResult Update(Patio patio)
        {
            int index = patios.FindIndex(p => p.Id == patio.Id);
            if (index == -1)
            {
                return NotFound();
            }

            double areaPatio = patio.ComprimentoPatio * patio.LarguraPatio;
            double areaPorVaga = patio.ComprimentoVaga * patio.LarguraVaga;
            patio.Vagas = (int)Math.Floor(areaPatio / areaPorVaga);

            patios[index] = patio;
            return RedirectToAction("PatioView");
        }



        // Delete =========================================================================
        public IActionResult Delete(int id)
        {
            Patio patio = patios.FirstOrDefault(p => p.Id == id);
            if (patio == null)
            {
                return NotFound();
            }
            return View(patio);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Patio patio = patios.FirstOrDefault(p => p.Id == id);
            if (patio == null)
            {
                return NotFound();
            }
            patios.Remove(patio);
            return RedirectToAction("PatioView");
        }

    }
}
