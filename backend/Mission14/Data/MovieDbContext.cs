﻿using Microsoft.EntityFrameworkCore;

namespace Mission14.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options) : base(options) { }

        public DbSet<MovieInfo> Movies { get; set; }

    }
}
