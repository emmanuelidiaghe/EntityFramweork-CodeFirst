using System;
using Games.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Games.Data
{
    public class GamesContext : DbContext
    {
        public GamesContext(DbContextOptions options) : base(options) { }

        public DbSet<Game> Games { get; set; }
    }
}