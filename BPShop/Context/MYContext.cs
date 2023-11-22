using BPShop.Enities;
using Microsoft.EntityFrameworkCore;

namespace BPShop.Context
{
	public class MYContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString = "server=localhost;user=root;password=;database=BPDataBase;";
			optionsBuilder.UseMySQL(connectionString);
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}