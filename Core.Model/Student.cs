using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
	 public class Student
	 {
	 		
		[Key]
		[Required]
		public int ID { get; set; }
			
		public string Stu_No { get; set; }
			
		public int? Class_ID { get; set; }
			
		public string Name { get; set; }
			
		public int? Gender { get; set; }
	 
	 }
}	 
