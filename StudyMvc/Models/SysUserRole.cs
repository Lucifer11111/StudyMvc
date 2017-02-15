using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudyMvc.Models
{
    public class SysUserRole
    {
        [Key]
        public int ID { get; set; }

        public string SysUserID { get; set; }
        public string SysRoleID { get; set; }
        public virtual SysUser SysUser { get; set; }
        public virtual SysRole SysRole { get; set; }
    }
}