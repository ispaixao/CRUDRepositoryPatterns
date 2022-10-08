using System.Collections.Generic;
using TesteCRUDRepositoryPatterns.Model;

namespace TesteCRUDRepositoryPatterns.Repository.Interfaces
{
    public interface IProdutoRepository : IBaseRepository
    {
        public IEnumerable<Produto> getProdutos();
        public Produto getProdutoById(int id);
    }
}
