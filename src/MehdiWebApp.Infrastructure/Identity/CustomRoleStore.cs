using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MehdiWebApp.Infrastructure.Identity
{
    public class CustomRoleStore<TRole, TContext, TKey, TUserRole, TRoleClaim>: RoleStore<TRole, TContext, TKey, TUserRole, TRoleClaim>
        where TRole : IdentityRole<TKey>
        where TKey : IEquatable<TKey>
        where TContext : DbContext
        where TUserRole : IdentityUserRole<TKey>, new()
        where TRoleClaim : IdentityRoleClaim<TKey>, new()
    {
        public CustomRoleStore(TContext context, IdentityErrorDescriber describer = null) : base(context, describer) { }
    }
}
