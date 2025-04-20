﻿using Bookify.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookify.Infrastructure.Configurations;

internal class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("roles");

        builder.HasKey(role => role.Id);

        builder.HasMany(role => role.Users).WithMany(user => user.Roles);

        builder.HasData(Role.Registered);

        builder.HasMany(rp => rp.Permissions).WithMany(p => p.Roles).UsingEntity<RolePermission>();
    }
}
