using System;
using System.Collections.Generic;
using System.Text;

namespace AulasPCDev.Models
{
    public class Filme : Item // FILME + ITEM 
    {
        public int Duracao { get; set; } // DURAÇÃO 
        public int QuantidadeDeOscars { get; set; } // QUANTIDADE DE OSCARS 
    }
}