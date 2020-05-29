using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Blog.Core.Model.Models
{
	 ///<summary>
	 ///Role
	 ///</summary>
	 [Table("Role")]	
	 public class Role
	 {
	 
		 /// <summary>
        /// id
        /// </summary>
		[Key]
		[Required]
		public int id { get; set; }
	
		 /// <summary>
        /// role_name
        /// </summary>
		[Required]
		public string role_name { get; set; }
	
		 /// <summary>
        /// role_desc
        /// </summary>
		public string role_desc { get; set; }
	 
	 }
}	 
