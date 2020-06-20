using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorzao
{
    class VeloMotor : Motor
    {
        public void AumentaVelocidade(double input)
        {
            if (statusMotor)
            {
                velocidade += input;
            }
            else
            {
                Console.WriteLine("Ligue o motor para que possa aumentar a velocidade.");
            }
        }

        public void ReduzVelocidade(double input)
        {
            if (statusMotor)
            {
                if (input < 0)
                {
                    Console.WriteLine("O motor só pode ficar entre 0 e 50.000 RPM");
                }
                else
                {
                    velocidade -= input;
                }
            }
            else
            {
                Console.WriteLine("Ligue o motor para que possa diminuir a velocidade.");
            }
        }
    }
}
