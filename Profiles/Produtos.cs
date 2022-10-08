using AutoMapper;
using TesteCRUDRepositoryPatterns.Model;
using TesteCRUDRepositoryPatterns.Model.DTOs;

namespace TesteCRUDRepositoryPatterns.Profiles
{
    public class Produtos : Profile
    {
        public Produtos()
        {
            CreateMap<CreateProdutoDTO, Produto>();
            CreateMap<UpdateProdutoDTO, Produto>();
        }
    }
}
