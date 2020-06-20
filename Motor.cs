using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorzao
{
    abstract class Motor
    {
        public bool statusMotor { get; set; }
        public double voltagem = 130;
        private double _velocidade;
        public double velocidade
        {
            get
            {
                return _velocidade;
            }
            protected set
            {
                if (value < 0)
                {
                    _velocidade = 0;
                }
                else if (value > 50000)
                {
                    _velocidade = 50000;
                }
                else
                {
                    _velocidade = value;
                }
            }
        }
        
        public void LigaMotor()
        {
            statusMotor = true;
        }
        public void DesligaMotor()
        {
            statusMotor = false;
        }
        public double VerificaVelocidade()
        {
            return velocidade;
        }
    }
}
