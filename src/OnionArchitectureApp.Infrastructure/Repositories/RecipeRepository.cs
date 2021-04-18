using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnionArchitectureApp.DomainModel.Models;
using OnionArchitectureApp.DomainServices.Interfaces;

namespace OnionArchitectureApp.Infrastructure.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        public RecipeRepository()
        {
        }

        public Task<IEnumerable<Recipe>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Recipe> GetByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
