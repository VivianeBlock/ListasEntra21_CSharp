using System;

namespace Calculadora_Basica
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1 = 0.0, v2 = 0.0;

            char oper, aux;
            string cond;

            Console.WriteLine("\n\tLISTA DE OPERAÇÕES:");
            Console.WriteLine("\n\t soma = +");
            Console.WriteLine("\n\tsubtração = -");
            Console.WriteLine("\n\tmultiplicação = *");
            Console.WriteLine("\n\tdivisão = /");
            Console.WriteLine("\n\tquadrado = ^\n\n");
            Console.WriteLine("\tPara resetar = c\n");
            Console.WriteLine("\tPara finalizar: exit ou close\n");
            Console.WriteLine("\t--------------------\n\n");
            Console.WriteLine("\n\tCALCULADORA INICIALIZADA.\n\n");

            cond = Console.ReadLine();

            if (cond == "exit" || cond == "close")
            {
                Console.WriteLine("\n\tCALCULADORA FINALIZADA\n");

            }
            else

            {

                v1 = Convert.ToDouble(cond);
                oper = Convert.ToChar(Console.ReadLine());
                v2 = Convert.ToDouble(Console.ReadLine());

                while (true)
                {


                    switch (oper)
                    {

                        case '+':

                            v1 += v2;
                            Console.WriteLine("\n\tResultado: {0}", v1);

                            break;
                        case '-':

                            v1 -= v2;
                            Console.WriteLine("\n\tResultado: {0}", v1);

                            break;
                        case '*':

                            v1 *= v2;
                            Console.WriteLine("\n\tResultado: {0}", v1);

                            break;
                        case '/':

                            v1 /= v2;
                            Console.WriteLine("\n\tResultado: {0}", v1);

                            break;
                        case '^':

                            v1 *= v1;
                            Console.WriteLine("\n\tResultado: {0}", v1);

                            break;

                        default:

                            Console.WriteLine("\n\tOperacão não computavel.\n\t Informe novamente:\n");
                            oper = Convert.ToChar(Console.ReadLine());
                            v2 = Convert.ToDouble(Console.ReadLine());
                            break;


                    }
                    cond = Console.ReadLine();
                    if (cond == "exit" || cond == "close")
                    {
                        Console.WriteLine("\n\tCALCULADORA FINALIZADA.");
                        break;
                    }
                    else
                    {

                        aux = Convert.ToChar(cond);
                        if (aux == '-' || aux == '+' || aux == '*' || aux == '/' || aux == '^' && aux != 'c')
                        {

                            oper = aux;
                            v2 = Convert.ToDouble(Console.ReadLine());
                        }
                        else if (aux == 'c')
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t-----------------------");
                            Console.WriteLine("\n\tCALCULADORA REINICIALIZADA\n");
                            v1 = Convert.ToDouble(Console.ReadLine());
                            oper = Convert.ToChar(Console.ReadLine());
                            v2 = Convert.ToDouble(Console.ReadLine());
                        }
                        else
                        {
                            v2 = Convert.ToDouble(cond);
                        }
                    }
                }

            }
        }
    }
}
