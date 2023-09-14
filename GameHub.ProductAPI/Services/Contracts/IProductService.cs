﻿using GameHub.ProductAPI.DTOs;

namespace GameHub.ProductAPI.Services.Contracts;

public interface IProductService
{
    Task<IEnumerable<ProductDTO>> GetProducts();
    Task<ProductDTO> GetProductById(int id);
    Task AddProduct(ProductDTO productDTO);
    Task UpdateProduct(ProductDTO productDTO);
    Task DeleteProduct(int id);
}
