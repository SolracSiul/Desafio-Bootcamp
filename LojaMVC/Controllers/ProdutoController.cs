using LojaMVC.Models;
using LojaMVC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LojaMVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoInterface _produtoRepository;
        public ProdutoController(ProdutoInterface pi)
        {
            _produtoRepository = pi;
        }
        public IActionResult Index()
        {
            List<ProdutoModel> produtos = _produtoRepository.FindAll();
            return View(produtos);
        }
        public IActionResult CriarProduto()
        {
            return View();
        }
        public IActionResult EditarProduto(int id)
        {
            ProdutoModel pm = _produtoRepository.ListarPorId(id);
            return View(pm);
        }
        public IActionResult ApagarProduto(int id)
        {
            ProdutoModel pm = _produtoRepository.ListarPorId(id);
            return View(pm);
        }
        [HttpPost]
        public IActionResult Criar(ProdutoModel produto) { 
            _produtoRepository.CreateProduct(produto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(ProdutoModel produto)
        {
            _produtoRepository.Atualizar(produto);
            return RedirectToAction("Index");
        }

        
        public IActionResult Apagar(int id)
        {
            _produtoRepository.Apagar(id);
            return RedirectToAction("Index");
        }

    }
}
