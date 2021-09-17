namespace MyBlogWeb.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MyBlogWebDbContext dbContext;

        public MyBlogWebDbContext Init()
        {
            return dbContext ?? (dbContext = new MyBlogWebDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}