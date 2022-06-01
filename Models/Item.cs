using AulasPCDev.Respository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulasPCDev.Models
{
    public class Item // ITEM
    {
        public int Id { get; set; } // ID
        public int Quantidade { get; set; } // QUANTIDADE
        public int Valor { get; set; } // VALOR
        public string Titulo { get; set; } // TÍTULO
        public string Descricao { get; set; } // DESCRIÇÃO 
        public Item()
        {
            List<Item> itens = Armazenamento.Biblioteca; // REFERENCIA BIBLOIOGRAFICA
            int quantidadeDeItens = itens.Count;
            Id = quantidadeDeItens++; 
        }
    }
}