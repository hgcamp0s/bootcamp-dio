using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext
    {
        // Vai receber a conexão pro banco de dados
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        // Migrations - Nada mais é que o mapameanto que o Entity faz das nossas classes, pra poder transformar elas em tabela
        // DbSet -> Vai representar uma tabela no seu BD
        public DbSet<Contato> Contatos { get; set; }
    }
}