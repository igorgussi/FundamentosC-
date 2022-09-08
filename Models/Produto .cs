using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Produto 
    {
        public string  Nome { get; set; }

        public decimal Preco { get; set; }

        public DateTime Validade { get; set; }

        public void ChamaProduto(){
            Console.WriteLine($"Produto: {Nome}\nPreço: {Preco}\nValidade: {Validade.ToString("dd/MM/yyyy")}");
        }
    }
}