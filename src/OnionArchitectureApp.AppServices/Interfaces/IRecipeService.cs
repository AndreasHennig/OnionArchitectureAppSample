using System.Threading.Tasks;
using OnionArchitectureApp.DomainModel.Models;

namespace OnionArchitectureApp.AppServices.Interfaces
{
    public interface IRecipeService
    {
        Task PublishRecipeAsync(Recipe recipe);
    }
}
