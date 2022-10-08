using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TesteCRUDRepositoryPatterns.Model;
using TesteCRUDRepositoryPatterns.Model.DTOs;
using TesteCRUDRepositoryPatterns.Repository.Interfaces;

namespace TesteCRUDRepositoryPatterns.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoController(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetProdutos()
        {
            var produtos = _produtoRepository.getProdutos();

            if (produtos == null)
            {
                return NotFound();
            }

            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetProdutoPorId(int id)
        {
            var produto = _produtoRepository.getProdutoById(id);
            if (produto == null) return NotFound();
            return Ok(produto);
        }

        [HttpPost]
        public IActionResult Cadastro(CreateProdutoDTO produtoDTO)
        {
            var produtoAdd = _mapper.Map<Produto>(produtoDTO);
            if (produtoAdd == null) return BadRequest("Dados incorretos");
            _produtoRepository.Add(produtoAdd);
            return Ok(produtoAdd);
        }

        [HttpPut("{id}")]
        public IActionResult Update(UpdateProdutoDTO produtoDTO, int id)
        {
            var produtoCadastrado = _produtoRepository.getProdutoById(id);

            var produtoUpdate = _mapper.Map(produtoDTO, produtoCadastrado);
            if (produtoUpdate == null) return BadRequest("Dados incorretos");
            _produtoRepository.Update(produtoUpdate);
            return Ok(produtoDTO);
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var produtoCadastrado = _produtoRepository.getProdutoById(id);
            if (produtoCadastrado == null) return NotFound();
            _produtoRepository.Delete(produtoCadastrado);
            return Ok();
        }
    }
}
