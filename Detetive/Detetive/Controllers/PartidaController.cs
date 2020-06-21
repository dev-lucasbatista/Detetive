﻿using AutoMapper;
using Detetive.Business.Business.Interfaces;
using Detetive.Business.Entities;
using Detetive.ViewModel;
using Detetive.ViewModel.Anotacao;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Detetive.Controllers
{
    public class PartidaController : Controller
    {
        private readonly ILocalBusiness _localBusiness;
        private readonly IJogadorSalaBusiness _jogadorSalaBusiness;
        private readonly IMovimentacaoBusiness _movimentacaoBusiness;
        private readonly IAnotacaoArmaBusiness _anotacaoArmaBusiness;
        private readonly IAnotacaoLocalBusiness _anotacaoLocalBusiness;
        private readonly IAnotacaoSuspeitoBusiness _anotacaoSuspeitoBusiness;

        public PartidaController(ILocalBusiness localBusiness,
                                 IJogadorSalaBusiness jogadorSalaBusiness,
                                 IMovimentacaoBusiness movimentacaoBusiness,
                                 IAnotacaoArmaBusiness anotacaoArmaBusiness,
                                 IAnotacaoLocalBusiness anotacaoLocalBusiness,
                                 IAnotacaoSuspeitoBusiness anotacaoSuspeitoBusiness)
        {
            _localBusiness = localBusiness;
            _jogadorSalaBusiness = jogadorSalaBusiness;
            _movimentacaoBusiness = movimentacaoBusiness;
            _anotacaoArmaBusiness = anotacaoArmaBusiness;
            _anotacaoLocalBusiness = anotacaoLocalBusiness;
            _anotacaoSuspeitoBusiness = anotacaoSuspeitoBusiness;
        }

        public ActionResult Manter()
        {
            return View();
        }

        public ActionResult Jogar(/*int idSala*/)
        {
            /// TO DO
            /// Deve retornar o ID_JOGADOR do jogador principal
            ViewBag.ID_JOGADOR_SALA = 1;

            var jogadoresSala = _jogadorSalaBusiness.Listar(1007);
            ViewBag.JogadoresSuspeitos = Mapper.Map<List<JogadorSala>, List<JogadorSuspeitoViewModel>>(jogadoresSala);

            var locais = _localBusiness.Listar();
            ViewBag.Locais = Mapper.Map<List<Local>, List<LocalViewModel>>(locais);

            // idJogadorSala
            this.CarregarAnotacoes(11);

            return View();
        }

        /// <summary>Valida o movimento do jogador no tabuleiro.</summary>
        /// <param name="idJogadorSala" type="int">ID do JoggadorSala.</param>
        /// <param name="linha" type="int">Número da linha.</param>
        /// <param name="coluna" type="int">Número da coluna.</param>
        /// <returns type="Void"></returns>
        public string Mover(int idJogadorSala, int linha, int coluna)
        {
            return JsonConvert.SerializeObject(_movimentacaoBusiness.MoverJogador(idJogadorSala, linha, coluna));
        }


        /// <summary>
        /// Obtem a posição atual de cada jogador da sala
        /// </summary>
        /// <returns>Retorna uma lista com ID-JOGADOR_SALA e a sua posição atual</returns>
        public string GetPosicaoAtual(/*int idSala*/)
        {
            int idSala = 1007;
            var jogadoresSala = _jogadorSalaBusiness.Listar(idSala);

            if (jogadoresSala == null || !jogadoresSala.Any())
                return String.Empty;

            /// Em caso de dúvida olhar o objeto de retorno em ~/Scripts/Views/Partida/Jogar.js
            return JsonConvert.SerializeObject("");
        }

        public string MapearTabuleiro()
        {
            /// TO DO
            /// Deve retornar um objeto conforme o utilizado no javascript Scripts/Views/Partida/Jogar.js linha 220 a 342

            return JsonConvert.SerializeObject("");
        }

        [HttpGet]
        public ActionResult ModalPalpite()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult ModalAcusar()
        {
            return PartialView();
        }

        /// <summary>
        /// Valida o palpite
        /// </summary>
        /// <param name="idJogadorSala"></param>
        /// <param name="idArma"></param>
        /// <param name="idLocal"></param>
        /// <returns></returns>
        public string Palpite(int idJogadorSala, int idArma, int idLocal)
        {
            /// Valida o palpite

            return JsonConvert.SerializeObject("");
        }

        public string Acusar(int idJogadorSala, int idArma, int idLocal)
        {
            /// Valida o palpite

            return JsonConvert.SerializeObject("");
        }

        private void CarregarAnotacoes(int idJogadorSala)
        {
            ViewBag.AnotacaoArma = Mapper.Map<List<AnotacaoArma>, List<AnotacaoArmaViewModel>>(_anotacaoArmaBusiness.Listar(idJogadorSala));
            ViewBag.AnotacaoLocal = Mapper.Map<List<AnotacaoLocal>, List<AnotacaoLocalViewModel>>(_anotacaoLocalBusiness.Listar(idJogadorSala));
            ViewBag.AnotacaoSuspeito = Mapper.Map<List<AnotacaoSuspeito>, List<AnotacaoSuspeitoViewModel>>(_anotacaoSuspeitoBusiness.Listar(idJogadorSala));
        }
    }
}
