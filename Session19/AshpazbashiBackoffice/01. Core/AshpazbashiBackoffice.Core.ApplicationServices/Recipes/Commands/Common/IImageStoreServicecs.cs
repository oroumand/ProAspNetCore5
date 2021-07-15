using AshpazbashiBackoffice.Core.Domain.Recipes;
using System;
using System.IO;

namespace AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Common
{
    public interface IImageStoreServicecs
    {
        RecipeImage Save(RecipeImageInput recipeImage);
    }
    public class PhysicalImageStoreService : IImageStoreServicecs
    {
        public RecipeImage Save(RecipeImageInput recipeImage)
        {
            string path = $"D:\\ApplicaiotnFiles\\{recipeImage.Name}";
            var result = new RecipeImage
            {
                Id = Guid.NewGuid(),
                Name = recipeImage.Name,
                PhysicalPath = path,
                FileType = Path.GetExtension(recipeImage.Name)
            };
            File.WriteAllBytes(path, recipeImage.FileContent);
            return result;
        }
    }
}
