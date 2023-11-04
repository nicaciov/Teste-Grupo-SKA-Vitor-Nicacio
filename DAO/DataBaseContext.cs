using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Teste_Grupo_SKA_Vitor_Nicacio.Models;

namespace Teste_Grupo_SKA_Vitor_Nicacio.DAO
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<BlocoNotas> tabelaBlocoNotas { get; set; }

    }
}
