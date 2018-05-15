using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TrabalhandoComVisualStudios.Models;

namespace TrabalhandoComVisualStudios.Tests
{
    public class ProdutoTesteDado:IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { GetPrecosAbaixo50() };
            yield return new object[] { GetPrecosAcima50 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private IEnumerable<Produto> GetPrecosAbaixo50()
        {
            decimal[] precos = new decimal[]
            {
                275M,48.95M,19.50M,24.95M
            };

            for (int i=0;i<precos.Length;i++)
            {
                yield return new Produto { Nome=$"P{i+1}",Preco=precos[i]};
            }
        }

        private Produto[] GetPrecosAcima50 => new Produto[]
        {
                new Produto { Nome = "P1", Preco=5 },
                new Produto { Nome = "P2", Preco =48.95M },
                new Produto { Nome = "P3", Preco = 19.50M },
                new Produto { Nome = "P4", Preco = 24.95M }
        };

    }
}
