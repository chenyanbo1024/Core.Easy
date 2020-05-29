using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Framework
{
	 ///<summary>
	 ///Classes
	 ///</summary>
	 [Table("Classes")]	
	 public class Classes
	 {
	 
		 /// <summary>
        /// ID
        /// </summary>
		[Key]
		[Required]
		public int ID { get; set; }
	
		 /// <summary>
        /// Name
        /// </summary>
		public string Name { get; set; }
	
		 /// <summary>
        /// Grade
        /// </summary>
		public int? Grade { get; set; }
	 
	 }
}	 
