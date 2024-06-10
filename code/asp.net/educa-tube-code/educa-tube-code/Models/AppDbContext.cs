﻿using Microsoft.EntityFrameworkCore;


namespace educa_tube_code.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Nota> Notas { get; set; }

        public DbSet<Video> Videos { get; set; }
        public DbSet<Pomodoro> Pomodoros { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Cometario> Comentarios { get; set; }

    }
}
