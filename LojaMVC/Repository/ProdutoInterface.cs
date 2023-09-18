using LojaMVC.Models;

namespace LojaMVC.Repository
{
    public interface ProdutoInterface
    {
       
        List<ProdutoModel> FindAll();
        ProdutoModel CreateProduct(ProdutoModel produto);

        ProdutoModel ListarPorId(int id);

        ProdutoModel Atualizar(ProdutoModel produto);

        bool Apagar(int id);
        
    }
}
