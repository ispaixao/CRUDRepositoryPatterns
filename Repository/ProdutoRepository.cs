using System.Collections.Generic;
using System.Linq;
using TesteCRUDRepositoryPatterns.Data;
using TesteCRUDRepositoryPatterns.Model;
using TesteCRUDRepositoryPatterns.Repository.Interfaces;

namespace TesteCRUDRepositoryPatterns.Repository
{
    public class ProdutoRepository : BaseRepository, IProdutoRepository
    {
        private AppDbContext _context;
        public ProdutoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Produto getProdutoById(int id)
        {
            return _context.Produtos.FirstOrDefault(produto => produto.ID == id);
        }

        public IEnumerable<Produto> getProdutos()
        {
            return _context.Produtos.ToList();
        }
    }
}
