using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NZWalks1.API.Data
{
    public class NZWalksAuthDbContext : IdentityDbContext
    {
        public NZWalksAuthDbContext(DbContextOptions<NZWalksAuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "005c2fbb-95b5-4965-9188-caf5fd806554";
            var writerRoleId = "c0263fa4-bd1c-4de7-8be2-99c4eb5ed9f1";

            builder.Entity<IdentityRole>().HasData(
    new IdentityRole
    {
        Id = "005c2fbb-95b5-4965-9188-caf5fd806554",
        ConcurrencyStamp = "005c2fbb-95b5-4965-9188-caf5fd806554",
        Name = "Reader",
        NormalizedName = "READER"
    },
    new IdentityRole
    {
        Id = "c0263fa4-bd1c-4de7-8be2-99c4eb5ed9f1",
        ConcurrencyStamp = "c0263fa4-bd1c-4de7-8be2-99c4eb5ed9f1",
        Name = "Writer",
        NormalizedName = "WRITER"
    }
);
        }
    }
}
