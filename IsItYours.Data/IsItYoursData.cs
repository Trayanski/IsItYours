using System.Data.Entity;
using IsItYours.Data.Contracts;
using IsItYours.Data.Repositories;
using IsItYours.Models;

namespace IsItYours.Data
{
    public class IsItYoursData : IIsItYoursData
    {
        private readonly IIsItYoursContext context;

        public IsItYoursData()
            :this(new IsItYoursContext())
        {
        }

        public IsItYoursData(IIsItYoursContext context)
        {
            this.context = context;
        }

		public Repository<User> Users =>  new Repository<User>(this.context);
        
        public Repository<Item> Items => new Repository<Item>(this.context);

        public IIsItYoursContext Context => this.context;

        public int SaveChanges()
        {
            return this.Context.DbContext.SaveChanges();
        }
    }
}
