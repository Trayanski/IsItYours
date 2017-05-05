using System.Data.Entity;
using IsItYours.Data.Contracts;
using IsItYours.Models;
using IsItYours.Models.EntityModels;
using Microsoft.AspNet.Identity.EntityFramework;

namespace IsItYours.Data
{
	public class IsItYoursContext : IdentityDbContext<ApplicationUser>, IIsItYoursContext
	{
		public IsItYoursContext()
			: base("name=IsItYoursContext")
		{
		}

		public static IsItYoursContext Create()
		{
			return new IsItYoursContext();
		}

		public IDbSet<User> Users { get; set; }
		public IDbSet<Item> Items { get; set; }
		public DbContext DbContext => this;
		public new IDbSet<T> Set<T>() where T : class
		{
			return base.Set<T>();
		}
	}

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}