using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MehdiWebApp.Infrastructure.Identity
{
    public class CustomUserStore<TUser, TRole, TContext, TKey> : UserStore<TUser, TRole, TContext, TKey>
        where TUser : IdentityUser<TKey>
        where TRole : IdentityRole<TKey>
        where TContext : DbContext
        where TKey : IEquatable<TKey>
    {
        public CustomUserStore(TContext context) : base(context) { }
    }



}
