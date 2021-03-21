using AutoMapper;
using SCI.App.ViewModels;
using SCI.Negocio.Modelos;

namespace SCI.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Categoria, CategoriaViewModel>().ReverseMap();
            CreateMap<Livro, LivroViewModel>().ReverseMap();
        }
    }
}
