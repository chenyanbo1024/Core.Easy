using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
	 public class Classes
	 {
	 		
		[Key]
		[Required]
		public int ID { get; set; }
			
		public string Name { get; set; }
			
		public int? Grade { get; set; }
	 
	 }
}	 
