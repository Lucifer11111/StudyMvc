using StudyMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudyMvc.DAL
{
    public class AccountInitializer : DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            //base.Seed(context);
            var sysUsers = new List<SysUser>
            {
                new SysUser { UserName="Tom", Password="1",Email="1@1.1" },
                new SysUser { UserName="Jack",Password="2" ,Email="2@2.2" }
            };
            sysUsers.ForEach(s => context.SysUsers.Add(s));
            context.SaveChanges();

            var sysRoles = new List<SysRole>
            {
                new SysRole { RoleName="administrators",RoleDesc="master" },
                new SysRole {RoleName="normal User",RoleDesc="normal" }
            };
            sysRoles.ForEach(s => context.SysRoles.Add(s));
            context.SaveChanges();
        }
    }
}