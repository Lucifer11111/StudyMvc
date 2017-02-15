using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudyMvc.Models
{
    public class SysUser
    {
        [Key]
        public int ID { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<SysUserRole> SysUserRoles { get; set; }
    }
}