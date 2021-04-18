using System.Collections.Generic;

namespace OnionArchitectureApp.DomainModel.Models
{
    public class Recipe
    {
        public string Title { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}
