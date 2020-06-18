using Judy.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Judy.Entity.Blog
{
    /// <summary>
    /// 博客评论表
    /// </summary>
    public class Judy_Blog_Comment : BaseEntity
    {
        /// <summary>
        /// 文章编号
        /// </summary>
        public Guid ArticleId { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        [StringLength(50), Column(TypeName = "nvarchar")]
        public string Content { get; set; }

        /// <summary>
        /// 评论人
        /// </summary>
        public string Lssueder { get; set; }

        /// <summary>
        /// 评论状态
        /// </summary>
        public int NowStatues { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        public int Top { get; set; }

        /// <summary>
        /// 评论编号
        /// </summary>
        public string OpenCommentCode { get; set; }

    }
}
