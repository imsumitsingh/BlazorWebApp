using BlazorWebApp.Models;

namespace BlazorWebApp.Services
{
    public class SubCategoryServices
    {
        private RepoContext _context = new();
        public SubCategoryServices()
        {
            _context = new();
        }

        public string GenerateID()
        {
            string? name = string.Empty;
            name = _context.SubCategories.OrderByDescending(e => e.Id).Select(e => e.SubCategoryId).FirstOrDefault();
            if (name is null)
            {
                return "ELMO-10001";
            }
            else
            {
                return "ELMO-" + Convert.ToInt32(name.Split('-')[1]) + 1;
            }
        }

        public List<SubCategory> Get()
        {
            return _context.SubCategories.OrderByDescending(p => p.CreateDate).ToList();
        }
    }
}

