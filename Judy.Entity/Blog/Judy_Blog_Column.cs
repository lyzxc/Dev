using Judy.Entity.Base;
using System;

namespace Judy.Entity.Blog
{
    /// <summary>
    /// 博客栏目表
    /// </summary>
    public class Judy_Blog_Column : BaseEntity
    {
        /// <summary>
        /// 栏目名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 父栏目编号
        /// </summary>
        public Guid PID { get; set; }

        /// <summary>
        /// 栏目介绍
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 栏目图片
        /// </summary>
        public string SmallPic { get; set; }

        /// <summary>
        /// 栏目显示类型(文字，图片，图片+文字)
        /// </summary>
        public int PicType { get; set; }

        /// <summary>
        /// 栏目跳转类型(内容型，内链型，外链型)
        /// </summary>
        public int LinkType { get; set; }

        /// <summary>
        /// 跳转地址
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// 访问权限(所有人都能访问，登录用户才能访问)
        /// </summary>
        public int Power { get; set; }

        /// <summary>
        /// 排列顺序
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// 栏目状态
        /// </summary>
        public int NowStatues { get; set; }

        /// <summary>
        /// 栏目层级
        /// </summary>
        public string Depts { get; set; }

        /// <summary>
        /// 栏目编号
        /// </summary>
        public string OpenColumnCode { get; set; }
    }
}
