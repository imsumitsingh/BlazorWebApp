using BlazorWebApp.Models;

namespace BlazorWebApp.Services
{
    public class ProductServices
    {
        private RepoContext _context = new();
        public ProductServices()
        {
            _context= new();
        }

        public string GenerateID()
        {
            string? name=string.Empty;            
            name = _context.Products.OrderByDescending(e=>e.Id).Select(e=>e.ProductId).FirstOrDefault();
            if (name is null)
            {
                return "PROD-10001";
            }
            else
            {
               return "PROD-"+(Convert.ToInt32(name.Split('-')[1])+1);
            }
        }

        public List<Product> Get()
        {
            return _context.Products.OrderByDescending(p => p.CreateDate).ToList();  
        }
        public int Add(Product product) { 
           _context.Products.Add(product);  
            return _context.SaveChanges();  
        }
    }
}
