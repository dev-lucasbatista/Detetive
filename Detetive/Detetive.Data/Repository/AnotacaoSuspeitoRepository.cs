﻿using Detetive.Business.Data.Interfaces;
using Detetive.Business.Entities;
using Detetive.Data.Context;
using Detetive.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detetive.Data.Repository
{
    public class AnotacaoSuspeitoRepository : BaseRepository, IAnotacaoSuspeitoRepository
    {
        public AnotacaoSuspeitoRepository() : base()
        {
        }

        public AnotacaoSuspeito Adicionar(AnotacaoSuspeito anotacao)
        {
            if (anotacao != default)
            {
                this.Context.AnotacaoSuspeitos.Add(anotacao);
                this.Context.SaveChanges();
            }

            return anotacao;
        }

        public List<AnotacaoSuspeito> Listar(int idJogadorSala)
        {
            return this.Context.AnotacaoSuspeitos.AsNoTracking().Where(_ => _.IdJogadorSala == idJogadorSala && _.Ativo).ToList();
        }

        public AnotacaoSuspeito Alterar(int idSuspeito, int idJogadorSala, bool valor)
        {
            var anotacao = this.Context.AnotacaoSuspeitos.Single(_ => _.IdJogadorSala == idJogadorSala && _.IdSuspeito == idSuspeito);

            anotacao.Sinalar(valor);
            this.Context.SaveChanges();

            return anotacao;
        }

        public List<AnotacaoSuspeito> Adicionar(List<AnotacaoSuspeito> anotacoes)
        {
            if (anotacoes != null && anotacoes.Any())
            {
                this.Context.AnotacaoSuspeitos.AddRange(anotacoes);
                this.Context.SaveChanges();
            }

            return anotacoes;
        }
    }
}