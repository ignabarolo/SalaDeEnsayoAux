﻿using Microsoft.EntityFrameworkCore;

namespace SalasDeEnsayo.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<saladeensayo> saladeensayo { get; set; }
        DbSet<tipodesala> tipodesala { get; set; }
        DbSet<instrumento> instrumento { get; set; }
        DbSet<saladeensayoequipamiento> saladeensayoequipamiento { get; set; }

        public string GetVersion();
        public int SaveChanges();

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}