using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Produto> produtos)
        {
            decimal total = 0;
            foreach (Produto prod in produtos)
            {
                total += prod?.Preco ?? 0;
            }
            return total;

        }

        public static IEnumerable<Produto> FiltraPorPreco(this IEnumerable<Produto> produtoEnum,decimal precominimo)
        {
            foreach (Produto prod in produtoEnum)
            {
                if ((prod?.Preco??0)>=precominimo)
                {
                    yield return prod;
                }
            }
        }
    }
}
