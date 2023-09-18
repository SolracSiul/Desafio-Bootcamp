using LojaMVC.Models;
using LojaMVC.NovaPasta1;

namespace LojaMVC.Repository
{
    public class ProdutoRepository : ProdutoInterface
    {
        private readonly BancoContext _bancoContext;
        public ProdutoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<ProdutoModel> FindAll()
        {
            return _bancoContext.ProdutoDB.ToList();
        }

        public ProdutoModel CreateProduct(ProdutoModel produto)
        {
            _bancoContext.ProdutoDB.Add(produto);
            _bancoContext.SaveChanges();
            return produto;
        }

        public ProdutoModel? ListarPorId(int id)
        {
            return _bancoContext.ProdutoDB.FirstOrDefault(x => x.Id == id) ?? null;
        }

        public ProdutoModel Atualizar(ProdutoModel produto)
        {
            ProdutoModel produtoDB = ListarPorId(produto.Id);
            if (produtoDB == null)
            {
                return null;
            }
            produtoDB.NomeProduto = produto.NomeProduto;
            produtoDB.Preco = produto.Preco;
            produtoDB.Estoque = produto.Estoque;

            _bancoContext.ProdutoDB.Update(produtoDB);
            _bancoContext.SaveChanges();

            return produtoDB;
        }

        public bool Apagar(int id)
        {
            ProdutoModel produtoDB = ListarPorId(id);
            if (produtoDB == null) throw new System.Exception("Erro ao deletar");
            _bancoContext.ProdutoDB.Remove(produtoDB);
            _bancoContext.SaveChanges();
            return true;

        }
    }
}