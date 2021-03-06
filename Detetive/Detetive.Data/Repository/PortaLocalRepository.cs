﻿using System;
using System.Collections.Generic;
using System.Linq;
using Detetive.Business.Data.Interfaces;
using Detetive.Business.Entities;
using Detetive.Data.Repository.Base;

namespace Detetive.Data.Repository
{
    public class PortaLocalRepository : BaseRepository, IPortaLocalRepository
    {
        public PortaLocalRepository() : base()
        {

        }
        public List<PortaLocal> Listar()
        {
            return this.Context.PortasLocal.AsNoTracking().Where(_ => _.Ativo).ToList();
        }

        public List<PortaLocal> Listar(int idLocal)
        {
            return this.Context.PortasLocal.AsNoTracking().Where(_ => _.IdLocal == idLocal && _.Ativo).ToList();
        }

        public PortaLocal Obter(int coordenadaLinha, int coordenadaColuna)
        {
            return this.Context.PortasLocal.AsNoTracking().FirstOrDefault(_ => _.CoordenadaLinha == coordenadaLinha && 
                                                                                _.CoordenadaColuna == coordenadaColuna && _.Ativo);
        }
    }
}