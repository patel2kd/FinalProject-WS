using Microsoft.EntityFrameworkCore;

namespace Login_1.Models
{
	public class MemberManagerContext : DbContext
	{
		public MemberManagerContext(DbContextOptions<MemberManagerContext> options)
			: base(options)
		{ }

		public DbSet<Member> Members { get; set; }
	}
}