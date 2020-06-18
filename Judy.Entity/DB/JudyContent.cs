using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Judy.Entity.Blog;
using Judy.Entity.User;

namespace Judy.Entity.DB
{
    /// <summary>
    /// 数据库访问上下文
    /// </summary>
    public class JudyContent : DbContext
    {
        #region 构造函数
        /// <summary>
        /// 初始化一个 使用连接名称为dbconnect的数据访问上下文类的新实例
        /// </summary>
        public JudyContent() : base("dbconnect")
        {
            //从不创建数据库
            Database.SetInitializer<JudyContent>(null);
        }

        /// <summary>
        /// 初始化一个 使用指定数据库连接名称或连接串的数据访问上下文类的新实例
        /// </summary>
        /// <param name="nameOrConnectionString"></param>
        public JudyContent(string nameOrConnectionString) : base(nameOrConnectionString)
        {

        }

        #endregion
        
        #region 属性

        public DbSet<Judy_User_UserInfo> UserInfos { get; set; }
        public DbSet<Judy_Blog_Article> articles { get; set; }
        public DbSet<Judy_Blog_Column> columns { get; set; }
        public DbSet<Judy_Blog_Comment> comments { get; set; }
        public DbSet<Judy_Blog_Link> links { get; set; }
        public DbSet<Judy_Blog_Config> configs { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //移除一对多的级联删除约定，想要级联删除可以在entityTypeConfiguration<T>的实现类中进行控制
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //多对多启用级联删除约定，不想级联删除可以在删除前判断关联的数据进行拦截 
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //去掉 将表名设置为实体类型名称的复数版本 的约定(如 对应ClassInfo 在数据库生成 ClassInfos表)
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
