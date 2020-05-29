using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Blog.Core.Model.Models
{
	 ///<summary>
	 ///O_User_Role
	 ///</summary>
	 [Table("O_User_Role")]	
	 public class O_User_Role
	 {
	 
		 /// <summary>
        /// id
        /// </summary>
		[Key]
		[Required]
		public int id { get; set; }
	
		 /// <summary>
        /// User_ID
        /// </summary>
		[Required]
		public int User_ID { get; set; }
	
		 /// <summary>
        /// Role_ID
        /// </summary>
		[Required]
		public int Role_ID { get; set; }
	 
	 }
}	 
