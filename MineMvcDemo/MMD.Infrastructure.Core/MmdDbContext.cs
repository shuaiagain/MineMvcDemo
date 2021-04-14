using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MMD.Data.Entity;

namespace MMD.Infrastructure.Core
{
    public class MmdDbContext : DbContext
    {
        public MmdDbContext() : base("name=MineMvcDemo")
        {
        }

        #region OnModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region 人员
        /// <summary>
        /// 登录账号
        /// </summary>
        public virtual DbSet<AccountEntity> Accounts { get; set; }

        /// <summary>
        /// 人员
        /// </summary>
        public virtual DbSet<UserEntity> Users { get; set; }
        #endregion
    }
}
