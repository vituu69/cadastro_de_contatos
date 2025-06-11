using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cursos.Models;
using Microsoft.EntityFrameworkCore;


namespace Cursos.Data;

public class BancoContext : DbContext
{
    public BancoContext(DbContextOptions<BancoContext> options) : base(options)
    {
    }
    
    public DbSet<ContatoModels> Contatos { get; set; }
}