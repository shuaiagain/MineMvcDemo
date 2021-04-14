using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace MMD.Data.Entity
{
    [Table("usr_User")]
    [Description("人员表")]
    public class UserEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Description("人员id")]
        public int UserId { get; set; }

        [StringLength(50)]
        [Required]
        [Description("人员名称")]
        public string UserName { get; set; }

        [Description("性别")]
        public bool? Sex { get; set; }

        [Description("邮箱")]
        public string Email { get; set; }

        [Description("手机号")]
        public string Phone { get; set; }

        [Description("创建时间")]
        public DateTime CreateTime { get; set; }

        [Description("创建人id")]
        public int CreatorId { get; set; }

        [Description("修改时间")]
        public DateTime LastModifyTime { get; set; }

        [Description("修改人id")]
        public DateTime LastModifyId { get; set; }

        [ForeignKey("AccountId")]
        [Description("登录账号")]
        public AccountEntity Account { get; set; }
     
        /// <summary>
        /// 登录账号id
        /// </summary>
        public int? AccountId { get; set; }
    }
}
