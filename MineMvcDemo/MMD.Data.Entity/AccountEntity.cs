using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMD.Data.Entity
{
    [Description("登录表")]
    [Table("usr_Account")]
    public class AccountEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("登录账号id")]
        public int AccountId { get; set; }

        [Required]
        [StringLength(50)]
        [Description("登录名称")]
        public string AccountName { get; set; }

        [Required]
        [StringLength(50)]
        [Description("密码")]
        public string Passwd { get; set; }

        [Description("创建时间")]
        public DateTime CreateTime { get; set; }

        [Description("创建人id")]
        public int CreatorId { get; set; }

        [Description("修改时间")]
        public DateTime LastModifyTime { get; set; }

        [Description("修改人id")]
        public DateTime LastModifyId { get; set; }

        [Description("人员信息")]
        public UserEntity User { get; set; }
    }
}
