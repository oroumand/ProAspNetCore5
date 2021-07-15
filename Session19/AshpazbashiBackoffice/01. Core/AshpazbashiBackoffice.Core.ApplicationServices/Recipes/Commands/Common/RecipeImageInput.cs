namespace AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Common
{
    public class RecipeImageInput
    {
        public string Name { get; set; }
        public string FileType { get; set; }
        public byte[] FileContent { get; set; }
    }
}
