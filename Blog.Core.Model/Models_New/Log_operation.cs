using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Blog.Core.Model.Models
{
	 ///<summary>
	 ///Log_operation
	 ///</summary>
	 [Table("Log_operation")]	
	 public class Log_operation
	 {
	 
		 /// <summary>
        /// id
        /// </summary>
		[Key]
		[Required]
		public int id { get; set; }
	
		 /// <summary>
        /// 操作对象ID，对应User表ID
        /// </summary>
		[Required]
		public int operation_id { get; set; }
	
		 /// <summary>
        /// 操作类型：0 - 未知，1 - 登录，2 - 编辑，3 - 删除，4 - 添加
        /// </summary>
		[Required]
		public int operation_type { get; set; }
	
		 /// <summary>
        /// operation_ip
        /// </summary>
		[Required]
		public string operation_ip { get; set; }
	
		 /// <summary>
        /// operation_msg
        /// </summary>
		public string operation_msg { get; set; }
	
		 /// <summary>
        /// operation_time
        /// </summary>
		[Required]
		public DateTime operation_time { get; set; }
	
		 /// <summary>
        /// remark
        /// </summary>
		public string remark { get; set; }
	 
	 }
}	 
