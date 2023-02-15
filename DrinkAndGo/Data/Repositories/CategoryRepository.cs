﻿using DrinkAndGo.Data.Interfaces;
using System.Collections.Generic;
using DrinkAndGo.Data.Models;

namespace DrinkAndGo.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}