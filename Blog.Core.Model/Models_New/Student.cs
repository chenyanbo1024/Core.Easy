using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Blog.Core.Model.Models
{
	 ///<summary>
	 ///Student
	 ///</summary>
	 [Table("Student")]	
	 public class Student
	 {
	 
		 /// <summary>
        /// ID
        /// </summary>
		[Key]
		[Required]
		public int ID { get; set; }
	
		 /// <summary>
        /// Stu_No
        /// </summary>
		public string Stu_No { get; set; }
	
		 /// <summary>
        /// Class_ID
        /// </summary>
		public int? Class_ID { get; set; }
	
		 /// <summary>
        /// Name
        /// </summary>
		public string Name { get; set; }
	
		 /// <summary>
        /// Gender
        /// </summary>
		public int? Gender { get; set; }
	 
	 }
}	 
