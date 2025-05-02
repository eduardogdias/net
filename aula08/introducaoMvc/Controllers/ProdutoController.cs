using introducaoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace introducaoMvc.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> produtos = new List<Produto>();
        public IActionResult Index() {
            return View(produtos); // retorna a View "index" com a lista de produtos
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto newProduto)
        {
            newProduto.Id = produtos.Count + 1;
            produtos.Add(newProduto);
            return RedirectToAction("Index");
        }
    }
}
