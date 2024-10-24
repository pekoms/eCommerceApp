﻿using eCommerceApp.Application.DTOs;
using eCommerceApp.Application.DTOs.Category;
using eCommerceApp.Application.DTOs.Product;

namespace eCommerceApp.Application.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CreateCategory>> GetAllAsync();
        Task<GetProduct> GetByIdAsync(Guid id);
        Task<ServiceResponse> AddAsync(CreateCategory product);
        Task<ServiceResponse> UpdateAsync(UpdateCategory entity);
        Task<ServiceResponse> DeleteAsync(Guid id);
    }
}
