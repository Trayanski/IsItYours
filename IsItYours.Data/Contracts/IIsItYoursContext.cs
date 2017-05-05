using System.Data.Entity;
using IsItYours.Models;

namespace IsItYours.Data.Contracts
{
    public interface IIsItYoursContext
    {
        IDbSet<User> Users { get; }

        IDbSet<Item> Items { get; }

        DbContext DbContext { get; }

        int SaveChanges();
        IDbSet<T> Set<T>()
           where T : class;

    }
}
