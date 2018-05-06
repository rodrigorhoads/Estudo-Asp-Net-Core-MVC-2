using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class ShoppingCart:IEnumerable<Produto>
    {
        public IEnumerable<Produto> Produtos { get; set; }


        public IEnumerator<Produto> GetEnumerator()
        {
            return Produtos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
