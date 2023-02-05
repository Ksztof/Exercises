using Microsoft.EntityFrameworkCore;

namespace IntersysJs.DataBase.DataBaseModels
{
	public class IntersysDb : DbContext
	{
		public IntersysDb()
		{
		}

		public IntersysDb(DbContextOptions<IntersysDb> options) : base(options)
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseNpgsql("User ID =postgres;Password=\"haslo1234\";Server=localhost;Port=5432;Database=Intersys;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			ICollection<string> names = GenerateRandomNames(100);
			int id = 1;

			foreach (var name in names)
			{
				modelBuilder.Entity<UserTable>().HasData(new UserTable
				{
					Id = id++,
					FirstName = name.Split(" ")[0],
					LastName = name.Split(" ")[1]
				});
			}
		}

		private void SeedBaseData(ModelBuilder modelBuilder)
		{
			// dodaje dane podstawowoe
		}

		public virtual DbSet<UserTable> Users { get; set; }



		static ICollection<string> GenerateRandomNames(int numberOfNames)
		{
			string[] firstNames = { "Anna", "Tomasz", "Jan", "Maria", "Katarzyna" };
			string[] lastNames = { "Nowak", "Kowalski", "Wiśniewski", "Wójcik", "Krawczyk" };
			Random random = new Random();

			ICollection<string> names = new List<string>();

			for (int i = 0; i < numberOfNames; i++)
			{
				int firstNameIndex = random.Next(firstNames.Length);
				int lastNameIndex = random.Next(lastNames.Length);

				names.Add(firstNames[firstNameIndex] + " " + lastNames[lastNameIndex]);
			}

			return names;
		}

	}
}
