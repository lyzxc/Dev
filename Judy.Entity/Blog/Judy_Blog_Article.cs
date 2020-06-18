using Judy.Entity.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Judy.Entity.Blog
{
    /// <summary>
    /// 博客内容表
    /// </summary>
    public class Judy_Blog_Article : BaseEntity
    {
        /// <summary>
        /// 所属栏目
        /// </summary>
        public Guid Column { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        /// <summary>
        /// 发布人
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// 首页展示图片
        /// </summary>
        public string SmallPic { get; set; }

        /// <summary>
        /// 文章状态
        /// </summary>
        public int NowStatues { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        public int Top { get; set; }

        /// <summary>
        /// 浏览权限
        /// </summary>
        public int Power { get; set; }

        /// <summary>
        /// 阅读数量
        /// </summary>
        public int ReadNum { get; set; }

        /// <summary>
        /// 点赞数量
        /// </summary>
        public int PraiseNum { get; set; }

        /// <summary>
        /// 回复数量
        /// </summary>
        public int ReplyNum { get; set; }

        /// <summary>
        /// 文章编号
        /// </summary>
        public string OpenArticleCode { get; set; }
    }
}
