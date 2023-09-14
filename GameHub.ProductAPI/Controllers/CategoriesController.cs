﻿using GameHub.ProductAPI.DTOs;
using GameHub.ProductAPI.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> Get()
        {
            var categories = await _categoryService.GetCategories();

            if (categories == null)
                return NotFound("Categories not found");

            return Ok(categories);
            
        }
        
        [HttpGet("products")]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategoriesProducts()
        {
            var categoriesDto = await _categoryService.GetCategoriesProducts();
            if (categoriesDto == null)
                return NotFound("Categories not found");

            return Ok(categoriesDto);
        }

        [HttpGet("{id:int}", Name = "GetCategory")]
        public async Task<ActionResult<CategoryDTO>> Get(int id)
        {
            var categoryDto = await _categoryService.GetCategoryById(id);
            if (categoryDto == null)
                return NotFound("Category not found");

            return Ok(categoryDto);
        }

        [HttpPost]
        public async Task<ActionResult<CategoryDTO>> Post([FromBody]CategoryDTO categoryDto)
        {
            if (categoryDto == null)
                return BadRequest("Invalid Data");

            await _categoryService.AddCategory(categoryDto);

            return new CreatedAtRouteResult("GetCategory", new { id = categoryDto.CategoryId }, categoryDto);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody]CategoryDTO categoryDto)
        {
            if (id != categoryDto.CategoryId)
                return BadRequest();

            else if (categoryDto == null)
                return BadRequest();
            await _categoryService.UpdateCategory(categoryDto);

            return Ok(categoryDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<CategoryDTO>> Delete(int id)
        {
            var categoryDto = await _categoryService.GetCategoryById(id);
            if (categoryDto == null)
                return NotFound("Category not found");

            await _categoryService.DeleteCategory(id);

            return Ok(categoryDto);
        }
    }
}
