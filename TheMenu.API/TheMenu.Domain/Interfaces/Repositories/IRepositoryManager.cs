namespace TheMenu.Domain.Interfaces.Repositories
{
    public interface IRepositoryManager
    {
        IProductRepository ProductRepository { get; }
        void Save();
    }
}
