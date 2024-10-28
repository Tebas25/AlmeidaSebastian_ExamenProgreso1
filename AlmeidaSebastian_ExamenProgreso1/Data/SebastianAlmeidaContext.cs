using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlmeidaSebastian_ExamenProgreso1.Models;

    public class SebastianAlmeidaContext : DbContext
    {
        public SebastianAlmeidaContext (DbContextOptions<SebastianAlmeidaContext> options)
            : base(options)
        {
        }

        public DbSet<AlmeidaSebastian_ExamenProgreso1.Models.Almeida> Almeida { get; set; } = default!;

public DbSet<AlmeidaSebastian_ExamenProgreso1.Models.Celular> Celular { get; set; } = default!;
    }
