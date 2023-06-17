using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Cinema.Model
{
    internal class CinemaContext : DbContext
    {
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Sessao { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Bilhete> Bilhetes { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
    }
}
