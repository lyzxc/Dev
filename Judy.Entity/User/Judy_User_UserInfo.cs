using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Judy.Entity.Base;

namespace Judy.Entity.User
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class Judy_User_UserInfo : BaseEntity
    {
        /// <summary>
        /// 登录用户名
        /// </summary>
        [Required,StringLength(50),Column(TypeName ="varchar")]
        public string LoginName { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        [Required, StringLength(50), Column(TypeName = "varchar")]
        public string PassWord { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string HeadPic { get; set; }

        /// <summary>
        /// 显示昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 账号状态
        /// </summary>
        public int NowStatues { get; set; }

        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime RecentTime { get; set; }

        /// <summary>
        /// 上次登录IP
        /// </summary>
        public string RecentIP { get; set; }

        /// <summary>
        /// 用户权限
        /// </summary>
        public string RoleIDList { get; set; }

        /// <summary>
        /// 全网唯一识别码
        /// </summary>
        [StringLength(32), Column(TypeName = "varchar")]
        public string OpenUserId { get; set; }
    }
}
