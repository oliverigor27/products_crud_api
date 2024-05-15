using Products.Model;

namespace Products.Interfaces;

public interface IProductService
{
    Task<List<ProductsModel>> GetAllProducts();
    Task<object> CreateNewProduct(ProductsModel product);
    Task<int> UpdateProduct(int id, ProductsModel product);
    Task<int> DeleteProduct(int id);
}