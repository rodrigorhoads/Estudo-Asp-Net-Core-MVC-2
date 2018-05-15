using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhandoComVisualStudios.Models
{
    public interface IRepository
    {
        IEnumerable<Produto> Produtos { get; }
        void AddProdutos(Produto produto);
    }
}
