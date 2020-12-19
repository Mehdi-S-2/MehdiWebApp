using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MehdiWebApp.Infrastructure.Identity
{
    public class CustomUserStore<TUser, TRole, TContext, TKey> : UserStore<TUser, TRole, TContext, TKey>
        where TUser : IdentityUser<TKey>
        where TRole : IdentityRole<TKey>
        where TContext : DbContext
        where TKey : IEquatable<TKey>
    {
        public CustomUserStore(TContext context) : base(context) { }
        public override Task<string> GetPhoneNumberAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            return Task.FromResult("Override GetPhoneNumberAsync");
        }
    }



}
