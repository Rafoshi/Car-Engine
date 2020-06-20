using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorzao
{
    class ControllerMotor : VeloMotor
    {
        public void AumentaConstante()
        {
            for (int i = 0; i < 100; i++)
            {
                AumentaVelocidade(50);
               //Console.WriteLine(VerificaVelocidade());
            }
        }

        public void ReduzConstante()
        {
            for (int i = 0; i < 100; i++)
            {
                ReduzVelocidade(50);
                //Console.WriteLine(VerificaVelocidade());
            }
        }
    }
}
