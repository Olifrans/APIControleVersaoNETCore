using APIControleVersaoNETCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIControleVersaoNETCore.Data
{
    public class APIControleVersaoContextDB : DbContext
    {
        public APIControleVersaoContextDB(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
