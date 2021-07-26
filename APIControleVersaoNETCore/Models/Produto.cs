using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIControleVersaoNETCore.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string EndereçoArmazem { get; set; }

        public int Quatidade { get; set; }
    }
}
