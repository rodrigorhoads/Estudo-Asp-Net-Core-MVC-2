using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Produto
    {
         public Produto(bool stock=true){
            NoEstoque=stock;
         }

        public string Nome { get; set; }
        public decimal? Preco { get; set; }
        public Produto Related { get; set; }
        public string Categoria { get; set; } = "Esportes Aquaticos";
        //public bool NoEstoque { get; } = true;
        public bool NoEstoque { get; }


        public static Produto[] GetProdutos()
        {
            Produto kayak = new Produto()
            {
                Nome="Kayak",
                Preco =275M,
                Categoria="Water Craft"
            };

            Produto coleteSalvaVidas = new Produto(false)
            {
                Nome="ColeteSalvaVidas",Preco=48.49M
            };

            kayak.Related = coleteSalvaVidas;

            return new Produto[] { coleteSalvaVidas,kayak,null};
        }
       
    }
}
