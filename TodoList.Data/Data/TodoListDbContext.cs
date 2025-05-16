using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TodoList.Data
{
    public class TodoListDbContext : IdentityDbContext
    {
		public TodoListDbContext(DbContextOptions<TodoListDbContext> options)
            : base(options)
        {
			if (Database.IsRelational())
			{
				Database.Migrate();
			}
			else
			{
				Database.EnsureCreated();
			}
		}
	}
}
