using alterarExcluir.Models;
using Microsoft.AspNetCore.Mvc;

namespace introducaoMvc.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> produtos = new List<Produto>();

        // GET =========================================================================
        public IActionResult Index() {
            return View(produtos); // retorna a View "index" com a lista de produtos
        }


        // POST =========================================================================
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto newProduto) {
            newProduto.Id = produtos.Count + 1;
            produtos.Add(newProduto);
            return RedirectToAction("Index");
        }


        // PUT =========================================================================
        //ação para exibit o formulário de edição de produto
        public IActionResult Edit(int id) {
            Produto produto = produtos.FirstOrDefault(p => p.Id == id);
            if(produto == null) {
                return NotFound();
            }
            return View(produto);
        }

        //ação para processar o formulário de edição produto
        [HttpPost]
        public IActionResult Edit(Produto produto) {
            int index = produtos.FindIndex(p => p.Id == produto.Id);
            if(index == -1) {
                return NotFound();
            }

            //atualiza o produto
            produtos[index] = produto;

            //redireciona de volta pra página principal
            return RedirectToAction("Index");
        }


        // DELETE =========================================================================
        public IActionResult Delete(int id) {
            Produto produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Produto produto = produtos.FirstOrDefault(p => p.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            produtos.Remove(produto);
            return RedirectToAction("Index");
        }
    }
}
