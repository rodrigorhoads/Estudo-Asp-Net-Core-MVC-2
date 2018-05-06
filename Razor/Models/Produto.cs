﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public int ProdutoId    {            get;set;        }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }
    }
}
