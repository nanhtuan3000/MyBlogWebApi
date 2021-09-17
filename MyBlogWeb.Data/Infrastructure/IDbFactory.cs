using System;

namespace MyBlogWeb.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        MyBlogWebDbContext Init();
    }
}