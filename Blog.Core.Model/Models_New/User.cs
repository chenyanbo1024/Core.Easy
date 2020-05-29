using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Blog.Core.Model.Models
{
	 ///<summary>
	 ///User
	 ///</summary>
	 [Table("User")]	
	 public class User
	 {
	 
		 /// <summary>
        /// id
        /// </summary>
		[Key]
		[Required]
		public int id { get; set; }
	
		 /// <summary>
        /// 姓名
        /// </summary>
		[Required]
		public string name { get; set; }
	
		 /// <summary>
        /// salt
        /// </summary>
		[Required]
		public string salt { get; set; }
	
		 /// <summary>
        /// password
        /// </summary>
		[Required]
		public string password { get; set; }
	
		 /// <summary>
        /// 用户头像地址
        /// </summary>
		public string avatarUrl { get; set; }
	
		 /// <summary>
        /// 性别：0-男，1-女
        /// </summary>
		[Required]
		public int gender { get; set; }
	
		 /// <summary>
        /// telephone
        /// </summary>
		public int? telephone { get; set; }
	
		 /// <summary>
        /// address
        /// </summary>
		public string address { get; set; }
	
		 /// <summary>
        /// birth
        /// </summary>
		public DateTime? birth { get; set; }
	
		 /// <summary>
        /// register_time
        /// </summary>
		[Required]
		public DateTime register_time { get; set; }
	
		 /// <summary>
        /// 是否登录：0 - 未登录，1 - 登录
        /// </summary>
		[Required]
		public int is_Login { get; set; }
	
		 /// <summary>
        /// email
        /// </summary>
		public string email { get; set; }
	
		 /// <summary>
        /// 用户状态：0 - 可用，1 - 不可用
        /// </summary>
		[Required]
		public int user_status { get; set; }
	
		 /// <summary>
        /// remark
        /// </summary>
		public string remark { get; set; }
	
		 /// <summary>
        /// ppp
        /// </summary>
		public int? ppp { get; set; }
	 
	 }
}	 
