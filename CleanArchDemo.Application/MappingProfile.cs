using AutoMapper;
using CleanArchDemo.Application.DTOs;
using CleanArchDemo.Domain.Entities;

namespace CleanArchDemo.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<ProductDto, Product>();

        CreateMap<CreateProductDto, Product>();
        CreateMap<Product, CreateProductDto>();

        CreateMap<StudentDto, Student>();
        CreateMap<Student, StudentDto>();
        
    }
}