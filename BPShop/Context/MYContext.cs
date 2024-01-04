using BPShop.Enities;
using Microsoft.EntityFrameworkCore;

namespace BPShop.Context
{
	public class MYContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
#if DEBUG
			string connectionString = "server=localhost;user=root;password=;database=BPDataBase;";
#else
            string connectionString = "Server=srv-wpleskdb01.ps.kz;Port=3306;Database=bpflower_db;User Id=bpflower_user;Password=20S2@d01Dude; ";
#endif

			optionsBuilder.UseMySQL(connectionString);
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}