using Day2Blazor.Models;

namespace Day2Blazor.Services
{
    public class ProductService
    {
        List<Product> products = new List<Product>();

        private readonly CategoryService categoryService;

        public ProductService(CategoryService categoryService)
        {
            products.Add(new Product { Id = 1, Name = "Tesla Model S", Price = 79999, DriveType = "Electric", Category = "Sport", CategoryId = 1 });
            products.Add(new Product { Id = 2, Name = "Toyota Camry", Price = 27999, DriveType = "Automatic", Category = "Family", CategoryId = 2 });
            products.Add(new Product { Id = 3, Name = "Ford Mustang GT", Price = 38999, DriveType = "Manual", Category = "Sport", CategoryId = 3 });
            products.Add(new Product { Id = 4, Name = "Honda Civic", Price = 21999, DriveType = "Automatic", Category = "Family", CategoryId = 4 });
            products.Add(new Product { Id = 5, Name = "BMW X5", Price = 59999, DriveType = "Automatic", Category = "Family", CategoryId = 1 });
            products.Add(new Product { Id = 6, Name = "Mercedes-Benz E-Class", Price = 54999, DriveType = "Automatic", Category = "Family", CategoryId = 2 });
            products.Add(new Product { Id = 7, Name = "Chevrolet Silverado 1500", Price = 38999, DriveType = "Automatic", Category = "Family", CategoryId = 3 });
            products.Add(new Product { Id = 8, Name = "Audi Q7", Price = 67999, DriveType = "Automatic", Category = "Family", CategoryId = 4 });
            products.Add(new Product { Id = 9, Name = "Jeep Wrangler", Price = 33999, DriveType = "Manual", Category = "Sport", CategoryId = 1 });
            products.Add(new Product { Id = 10, Name = "Subaru Outback", Price = 32999, DriveType = "Automatic", Category = "Family", CategoryId = 2 });
            this.categoryService = categoryService;
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product? GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public void Edit(Product editedProduct)
        {
            if (editedProduct != null)
            {
                Product? prodDB = products.FirstOrDefault(p => p.Id == editedProduct.Id);

                Category? catDB = categoryService.GetById(editedProduct.CategoryId);

                if (prodDB != null && catDB != null)
                {
                    prodDB.Name = editedProduct.Name;
                    prodDB.Price = editedProduct.Price;
                    prodDB.DriveType = editedProduct.DriveType;

                    prodDB.CategoryId = editedProduct.CategoryId;

                    prodDB.Category = catDB.Name;
                }
            }
        }
    }
}
