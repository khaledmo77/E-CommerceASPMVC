﻿using Project.Models;

namespace Project.Contract
{
    public interface IBrandService
    {
        Task<IEnumerable<Brand>> GetAllBrandsAsync();
        Task<Brand?> GetBrandByIdAsync(int id);
        Task AddBrandAsync(Brand brand);
        Task UpdateBrandAsync(Brand brand);
        Task DeleteBrandAsync(int id);
    }
}
