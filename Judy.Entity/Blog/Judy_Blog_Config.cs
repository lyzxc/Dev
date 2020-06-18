using Judy.Entity.Base;

namespace Judy.Entity.Blog
{
    /// <summary>
    /// 博客配置表
    /// </summary>
    public class Judy_Blog_Config : BaseEntity
    {
        /// <summary>
        /// 键
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }

    }
}
