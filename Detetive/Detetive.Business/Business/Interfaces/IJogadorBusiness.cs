﻿using Detetive.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detetive.Business.Business.Interfaces
{
    public interface IJogadorBusiness
    {
        Jogador Obter(int idJogador);
        Jogador Adicionar(string dsJogador);
        List<Jogador> Listar(List<int> idJogadores);
    }
}