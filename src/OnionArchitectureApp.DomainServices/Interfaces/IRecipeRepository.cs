using System.Collections.Generic;
using System.Threading.Tasks;
using OnionArchitectureApp.DomainModel.Models;

namespace OnionArchitectureApp.DomainServices.Interfaces
{
    public interface IRecipeRepository
    {
        public Task<Recipe> GetByIdAsync();

        public Task<IEnumerable<Recipe>> GetAllAsync();
    }
}
