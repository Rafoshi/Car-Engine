using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorzao
{
    class UsaMotor : Motor
    {
        static void Main()
        {

            Pergunta();


            /*
            ControllerMotor motor1 = new ControllerMotor();
            ControllerMotor motor2 = new ControllerMotor();
            ControllerMotor motor3 = new ControllerMotor();
            
            Console.WriteLine("\nA velocidade do Motor 1 é de {0} RPM", motor1.velocidade);
            Console.WriteLine("A Voltagem do Motor 1 é de {0} kW ", motor1.voltagem);
            Console.WriteLine("O motor 1 está ligado? :{0}",motor1.statusMotor);

            Console.WriteLine("\nA velocidade do Motor 2 é de {0} RPM", motor2.velocidade);
            Console.WriteLine("A Voltagem do Motor 2 é de {0} kW ", motor2.voltagem);
            Console.WriteLine("O motor 2 está ligado? :{0}", motor2.statusMotor);
            
            Console.WriteLine("\nA velocidade do Motor 3 é de {0} RPM", motor3.velocidade);
            Console.WriteLine("A Voltagem do Motor 3 é de {0} kW ", motor3.voltagem);
            Console.WriteLine("O motor 3 está ligado? :{0}", motor3.statusMotor);*/

            Console.WriteLine("\nTecle enter para sair");
            Console.ReadLine();
        }
        static void Pergunta()
        {
            ControllerMotor motor = new ControllerMotor();
            Console.WriteLine("Deseja ligar o motor? (Y/N)");
            string str = Console.ReadLine();
            string input = str.ToLower();
            if (input == "y")
            {
                motor.LigaMotor();
            }
            else if (input == "n")
            {
                motor.DesligaMotor();
                return;
            }
            else
            {
                Console.WriteLine("Apenas Y ou N são entradas válidas.");
            }
            
            Console.WriteLine("Deseja acelerar o seu motor? (Y/N)");
            string str1 = Console.ReadLine();
            string input1 = str1.ToLower();
            if (input1 == "y")
            {
                motor.AumentaConstante();
                Console.WriteLine("\nA velocidade do Motor 1 é de {0} RPM", motor.velocidade);
                Console.WriteLine("A Voltagem do Motor 1 é de {0} kW ", motor.voltagem);
                Console.WriteLine("O motor 1 está ligado? :{0}", motor.statusMotor);
            }
            else
            {
                Console.WriteLine("\nOperação finalizada, desligando o motor...");
                motor.DesligaMotor();
                return;
            }

            Console.WriteLine("\nDeseja Reduz a aceleração? (Y/N)");
            string str2 = Console.ReadLine();
            string input2 = str2.ToLower();
            if (input2 == "y")
            {
                motor.ReduzConstante();
                Console.WriteLine("\nA velocidade do Motor 1 é de {0} RPM", motor.velocidade);
                Console.WriteLine("A Voltagem do Motor 1 é de {0} kW ", motor.voltagem);
                Console.WriteLine("O motor 1 está ligado? :{0}", motor.statusMotor);

                Console.WriteLine("\nOperação finalizada, desligando o motor...");
                motor.DesligaMotor();

                Console.WriteLine("\nO motor 1 está ligado? :{0}", motor.statusMotor);
            }
            else
            {
                Console.WriteLine("\nOperação finalizada, desligando o motor...");
                motor.DesligaMotor();
            }
        }
    }
}
