using System;

namespace TeduShop.Data.Infastructure
{
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}