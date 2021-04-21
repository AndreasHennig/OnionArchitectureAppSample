using System;
using System.Threading.Tasks;
using OnionArchitectureApp.AppServices.Interfaces;
using OnionArchitectureApp.DomainModel.Models;

namespace OnionArchitectureApp.Infrastructure.Services
{
    public class RecipeService : IRecipeService
    {
        public RecipeService()
        {
        }

        public Task PublishRecipeAsync(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
