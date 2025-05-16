using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data.Models;

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
		public DbSet<Assignment> Assignments { get; set; } = null!;
		public DbSet<Todo> ToDos { get; set; } = null!;
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Entity<Todo>()
				.HasOne(t => t.Assignment)
				.WithMany(t => t.ToDoList)
				.HasForeignKey(t => t.AssignmentId);
		}
	}

}
