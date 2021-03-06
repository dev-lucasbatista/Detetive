﻿using Detetive.Business.Entities;
using Detetive.Data.Context.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Detetive.Data.Context
{
    public class DetetiveContext : DbContext
    {
        public DbSet<Arma> Armas { get; set; }
        public DbSet<Local> Locais { get; set; }
        public DbSet<PortaLocal> PortasLocal { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Suspeito> Suspeitos { get; set; }

        // Anotações Jogador
        public DbSet<AnotacaoArma> AnotacaoArmas { get; set; }
        public DbSet<AnotacaoLocal> AnotacaoLocais { get; set; }
        public DbSet<AnotacaoSuspeito> AnotacaoSuspeitos { get; set; }

        // Cartas
        public DbSet<ArmaJogadorSala> ArmasJogadorSala { get; set; }
        public DbSet<LocalJogadorSala> LocaisJogadorSala { get; set; }
        public DbSet<SuspeitoJogadorSala> SuspeitosJogadorSala { get; set; }

        // Jogador
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<JogadorSala> JogadoresSala { get; set; }
        
        public DbSet<Crime> Crimes { get; set; }

        // Chat
        public DbSet<Historico> Historicos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArmaConfig());
            modelBuilder.Configurations.Add(new LocalConfig());
            modelBuilder.Configurations.Add(new SalaConfig());
            modelBuilder.Configurations.Add(new SuspeitoConfig());
            modelBuilder.Configurations.Add(new AnotacaoArmaConfig());
            modelBuilder.Configurations.Add(new AnotacaoLocalConfig());
            modelBuilder.Configurations.Add(new AnotacaoSuspeitoConfig());
            modelBuilder.Configurations.Add(new ArmaJogadorSalaConfig());
            modelBuilder.Configurations.Add(new LocalJogadorSalaConfig());
            modelBuilder.Configurations.Add(new SuspeitoJogadorSalaConfig());
            modelBuilder.Configurations.Add(new JogadorConfig());
            modelBuilder.Configurations.Add(new JogadorSalaConfig());
            modelBuilder.Configurations.Add(new CrimeConfig());
            modelBuilder.Configurations.Add(new PortaLocalConfig());
            modelBuilder.Configurations.Add(new HistoricoConfig());

            Database.SetInitializer<DetetiveContext>(null);
        }
    }
}