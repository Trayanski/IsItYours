using IsItYours.Data.Repositories;
using IsItYours.Models;

namespace IsItYours.Data.Contracts
{
    public interface IIsItYoursData
    {
        Repository<User> Users { get; }

        Repository<Item> Items { get; }

        IIsItYoursContext Context { get; }

        int SaveChanges();
    }
}
