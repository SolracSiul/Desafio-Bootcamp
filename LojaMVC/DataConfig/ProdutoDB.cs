using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaMVC.NovaPasta1
{
    
    public class ProdutoDB
    {
        [Key]
        public int Id { get; set; }
    
        public string NomeProduto { get; set; }
        
        public int Preco { get; set; }

        public int Estoque {  get; set; }

    }
}
