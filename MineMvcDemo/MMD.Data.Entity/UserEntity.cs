using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMD.Data.Entity
{
    public class UserEntity
    {
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public bool Sex { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

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
