using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TodoList.Data;

namespace ToDoList.Data.Models
{
	public class Todo
	{
		[Key]
		public long Id { get; set; }
		[Required]
		[MaxLength( DataConstants.ToDoListMaxLength)]
		public string Description { get; set; } = null!;
		public bool IsCompleted { get; set; }
		[ForeignKey(nameof(Assignment))]
		public int AssignmentId { get; set; }
		[Required]
		public Assignment Assignment { get; set; } = null!;

	}
}
