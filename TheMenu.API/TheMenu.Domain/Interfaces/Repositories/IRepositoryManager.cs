namespace TheMenu.Domain.Interfaces.Repositories
{
    public interface IRepositoryManager
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        void Save();
    }
}
