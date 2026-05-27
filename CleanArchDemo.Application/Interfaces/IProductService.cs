using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchDemo.Domain.Entities;

namespace CleanArchDemo.Application.Interfaces;

public interface IProductService
{
    Task<List<Product>> GetAllProductsAsync();

    Task<Product?> GetProductByIdAsync(int id);

    Task AddProductAsync(Product product);
}