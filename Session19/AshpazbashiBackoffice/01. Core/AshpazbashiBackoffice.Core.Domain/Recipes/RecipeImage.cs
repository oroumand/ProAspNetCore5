using AshpazbashiBackoffice.Core.Domain.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshpazbashiBackoffice.Core.Domain.Recipes
{
    public class RecipeImage: Entity
    {
        public string Name { get; set; }
        public string PhysicalPath { get; set; }
        public string FileType { get; set; }
    }
}
