using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMD.Data.Entity
{
    /// <summary>
    /// 登录表
    /// </summary>
    public class AccountEntity
    {
        /// <summary>
        /// 登录账号id
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// 登录名称
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Passwd { get; set; }

        /// <summary>
        /// 人员id
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        public int CreatorId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime LastModifyTime { get; set; }

        /// <summary>
        /// 修改人id
        /// </summary>
        public DateTime LastModifyId { get; set; }
    }
}
