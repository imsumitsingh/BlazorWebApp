using BlazorWebApp.Models;

namespace BlazorWebApp.Services
{
    public class SupplierServices
    {
        private RepoContext _context = new();
        public SupplierServices()
        {
            _context = new();
        }

        public string GenerateID()
        {
            string? name = string.Empty;
            name = _context.Suppliers.OrderByDescending(e => e.Id).Select(e => e.SupplierId).FirstOrDefault();
            if (name is null)
            {
                return "SUPP-10001";
            }
            else
            {
                return "SUPP-" + Convert.ToInt32(name.Split('-')[1]) + 1;
            }
        }

        public List<Supplier> Get()
        {
            return _context.Suppliers.OrderByDescending(p => p.CreateDate).ToList();
        }
    }
}
