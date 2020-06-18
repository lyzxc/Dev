using Judy.Entity.Base;

namespace Judy.Entity.Blog
{
    /// <summary>
    /// 博客链接表
    /// </summary>
    public class Judy_Blog_Link : BaseEntity
    {
        /// <summary>
        /// 链接类型
        /// </summary>
        public string Types { get; set; }

        /// <summary>
        /// 链接名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 链接图片
        /// </summary>
        public string Pic { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// 链接编号
        /// </summary>
        public string OpenLinkCode { get; set; }

    }
}
