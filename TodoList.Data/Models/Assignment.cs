using System.ComponentModel.DataAnnotations;
using TodoList.Data;

namespace ToDoList.Data.Models
{
	public class Assignment
	{
		public Assignment()
		{
			ToDoList = new List<Todo>();
		}
		[Key]
		public int Id { get; set; }
		[Required]
		[MaxLength(DataConstants.AssignmentTitleMaxLength)]
		public string Title { get; set; } = null!;
		[Required]
		[MaxLength(DataConstants.ToDoListMaxLength)]
		public string Description { get; set; } = null!;		
		public DateTime Deadline { get; set; }
		public bool IsCompleted { get; set; }
		public ICollection<Todo> ToDoList { get; set; }
	}
}
