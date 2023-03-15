using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde.Herenca
{
    public class Veiculo
    {
        public string cor;
        public int quantidadedeRodas;
        public int quantidadedeAssentos;
        public bool TemMotor;

        public string ExibirDados()
        {
            return cor + " " + quantidadedeRodas + " " + quantidadedeRodas;
        }
    }
}
