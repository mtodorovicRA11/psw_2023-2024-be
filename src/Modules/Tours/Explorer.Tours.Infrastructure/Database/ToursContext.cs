﻿using Explorer.Tours.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Explorer.Tours.Infrastructure.Database;

public class ToursContext : DbContext
{
    public ToursContext(DbContextOptions<ToursContext> options) : base(options) {}
    public DbSet<Equipment> Equipment { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("tours");
    }
}