using BlazorWebApp.Models;

namespace BlazorWebApp.Services
{
    public class CategoryServices
    {
        private RepoContext _context = new();
        public CategoryServices()
        {
            _context = new();
        }

        public string GenerateID()
        {
            string? name = string.Empty;
            name = _context.Categories.OrderByDescending(e => e.Id).Select(e => e.CategoryId).FirstOrDefault();
            if (name is null)
            {
                return "EL-10001";
            }
            else
            {
                return "EL-" + Convert.ToInt32(name.Split('-')[1]) + 1;
            }
        }

        public List<Category> Get()
        {
            return _context.Categories.OrderByDescending(p => p.CreateDate).ToList();
        }
    }
}
