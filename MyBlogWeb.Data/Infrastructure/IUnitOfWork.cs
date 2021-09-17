namespace MyBlogWeb.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}