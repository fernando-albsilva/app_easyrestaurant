﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Produto
    {
        private string id_produto; 
        private string nome_produto; 
        private decimal valor; 
        private decimal custo; 
        private decimal quantidade;

        //public Produto(string id_produto, string nome, decimal valor, decimal custo, string descricao)
        //{
        //    this.Id_produto = id_produto;
        //    this.Nome = nome;
        //    this.Valor = valor;
        //    this.Custo = custo;
        //    this.Descricao = descricao;
        //}

        public Produto() { }

        public string Id_produto { get => id_produto; set => id_produto = value; }
        public string Nome { get => nome_produto; set => nome_produto = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public decimal Custo { get => custo; set => custo = value; }
        public decimal Quantidade { get => quantidade; set => quantidade = value; }


    }
}