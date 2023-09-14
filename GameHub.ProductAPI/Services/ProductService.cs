﻿using AutoMapper;
using GameHub.ProductAPI.DTOs;
using GameHub.ProductAPI.Models;
using GameHub.ProductAPI.Repositories;
using GameHub.ProductAPI.Services.Contracts;

namespace GameHub.ProductAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productEntity = await _productRepository.GetAll();
            return _mapper.Map<IEnumerable<ProductDTO>>(productEntity);
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var productDto = await _productRepository.GetById(id);
            return _mapper.Map<ProductDTO>(productDto);
        }

        public async Task AddProduct(ProductDTO productDto)
        {
            var productEntity = _mapper.Map<Product>(productDto);
            await _productRepository.Create(productEntity);
            productDto.Id = productEntity.Id;
        }

        public async Task UpdateProduct(ProductDTO productDTO)
        {
            var productEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.Update(productEntity);
        }

        public async Task DeleteProduct(int id)
        {
            var productEntity = await _productRepository.GetById(id);
            await _productRepository.Delete(productEntity.Id);
        }
    }
}
