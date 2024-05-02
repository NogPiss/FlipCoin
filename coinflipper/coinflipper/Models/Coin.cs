using Android.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace coinflipper.Models
{

    public class Coin() {
        public string Lado { get; set; }
        public int LadoEscolhido { get; set; }
    }
    public Coin()
    {

    }
    public Jogar()
    {
        Lado = (new Random().Next(2) == 0) ? "Cara" : "Coroa";
        return Lado;
    }

}
