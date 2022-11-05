namespace TheMenu.Domain.Interfaces.Services
{
    public interface IServiceManager
    {
        IProductService ProductService { get; }
        ICategoryService CategoryService { get; }
    }
}
