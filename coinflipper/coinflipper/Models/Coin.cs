using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace coinflipper.Models
{
    public class Coin
    {
        public string LadoEscolhido { get; set; }
        public string LadoSorteado { get; set; }
        
        // Método construtor
        public Coin() { 
            
        }
        // Método jogar a a moeda retorna o lado sorteando como uma string
        public string Jogar()
        {
            LadoSorteado = new Random().Next(2) == 0 ? "Cara" : "Coroa";
            return (LadoSorteado);
            //return new Random().Next(2) == 0 ? "Cara" : "Coroa";
        }
    }
}
