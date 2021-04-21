using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MMD.Data.Entity.User
{
    [Description("角色表")]
    [Table("usr_Role")]
    public class RoleEntity
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [Description("角色")]
        public string RoleName { get; set; }

        [Description("创建时间")]
        public DateTime CreateTime { get; set; }

        [Description("创建人id")]
        public int CreatorId { get; set; }

        [Description("修改时间")]
        public DateTime LastModifyTime { get; set; }

        [Description("修改人id")]
        public DateTime LastModifyId { get; set; }
    }
}
