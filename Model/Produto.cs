using System.ComponentModel.DataAnnotations;

namespace TesteCRUDRepositoryPatterns.Model
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }

    }
}
