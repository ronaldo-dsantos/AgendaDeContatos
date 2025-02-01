﻿using AgendaDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaDeContatos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Contato> Contatos { get; set; }
    }
}
