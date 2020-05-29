using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Framework
{
	 ///<summary>
	 ///Tmp
	 ///</summary>
	 [Table("Tmp")]	
	 public class Tmp
	 {
	 
		 /// <summary>
        /// 主键ID
        /// </summary>
		[Key]
		[Required]
		public Guid ID { get; set; }
	
		 /// <summary>
        /// IP地址
        /// </summary>
		public string IpAddress { get; set; }
	
		 /// <summary>
        /// 学生Student
        /// </summary>
		public string Student { get; set; }
	
		 /// <summary>
        /// 时间
        /// </summary>
		public DateTime? Time { get; set; }
	 
	 }
}	 
