using System;

namespace Condições_de_Checagem
{
    class Program
    {
        static void Main(string[] args)
        {


            /* Nota para resolução de exercicios:
             * O '{0}' é como o '%d' ou o '%f' da linguagem em C!
             * Ai não precisa do '+' para mostrar valores ao printar!
             * 
             * OBS.: Todos os exercicios comentados e separados por chaves.
            */



            //EXERCICIO 1

            {
                //           double numero; // funciona como o float
                //          numero = Convert.ToDouble(Console.ReadLine());  //Le o numero e armazena em número
                //
                //           if (numero > 10)
                //           {
                //               Console.WriteLine(numero);  //printa o número na tela
                //          }
                //          else
                //          {
                //              Console.WriteLine("Não é maior que 10");
                //          }
            }


            //EXERCICIO 2

            {
                //       double numero1, numero2; // receber duas variaveis sem expecificação

                //    numero1 = Convert.ToDouble(Console.ReadLine());
                //    numero2 = Convert.ToDouble(Console.ReadLine());

                //    if (numero1 == numero2)
                //    {
                //        Console.WriteLine("São iguais");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Não são iguais");
                //    }
            }


            //EXERCICIO 3

            {
                //    double numero1, numero2;

                //    numero1 = Convert.ToDouble(Console.ReadLine());
                //    numero2 = Convert.ToDouble(Console.ReadLine());

                //    if (numero1 < numero2)
                //    {
                //        Console.WriteLine(numero2);
                //    }
                //    else
                //    {
                //        Console.WriteLine(numero1);
                //    }

            }


            //EXERCICIO 4

            {
                //double numero1, numero2, numero3;

                //numero1 = Convert.ToDouble(Console.ReadLine());
                //numero2 = Convert.ToDouble(Console.ReadLine());
                //numero3 = Convert.ToDouble(Console.ReadLine());

                //if(numero1 < numero2 ){

                //   if(numero2 > numero3){

                //        Console.WriteLine(numero2);

                //    } if(numero2 < numero3){

                //        Console.WriteLine(numero3);
                //    }

                //}
                //else
                //{
                //    Console.WriteLine(numero1);
                //}

            }


            //EXERCICIO 5

            {
                //double numero;

                //numero = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine("\n\n");

                //switch (numero)
                //{
                //    case 1:
                //        Console.WriteLine("1");
                //        break;

                //    case 2:
                //        Console.WriteLine("2");
                //        break;
                //    case 3:
                //        Console.WriteLine("3");
                //        break;

                //    default:
                //        Console.WriteLine("\nNão computável!");
                //        break;
                //}
            }


            //EXERCICIO 6 - Exemplo de uso do Random

            {

                //int resultado;
                //Random ran = new Random(); // Chamar o Random e dar um nome, no caso é "ram" = new Random. 
                /*resultado = ran.Next(1, 7);*/ // 0, 1 ,2
                                                // o inicio é contado E O FINAL NÃO!
                                                //if (resultado >= 3)
                                                //{
                                                //    Console.WriteLine("Você venceu! " + resultado );
                                                //}
                                                //else
                                                //{
                                                //    Console.WriteLine("Você perdeu... " + resultado);
                                                //}


            }


            //EXERCICIO 7

            {

                //double numero;

                //numero = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("\n\n");

                //if((numero % 2) ==0)
                //{
                //    Console.WriteLine("\tpar");
                //}
                //else
                //{
                //    Console.WriteLine("\timpar");
                //}


            }


            //EXERCICIO 8

            {



                //double valor, final, desconto;

                //valor = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("\n\tO valor original é: ");
                //Console.WriteLine(valor);


                //if (valor > 254.50)
                //{

                //    desconto = 28.0 / 100;
                //    final = valor - (desconto * valor);

                //    Console.WriteLine("\tO valor com desconto é:" + final);
                //}
                //else
                //{
                //    desconto = 21.0 / 100;
                //    final = valor - (desconto * valor);

                //    Console.WriteLine("\tO valor com desconto é:" + final);
                //}

            }


            //EXERCICIO 9

            {

                //double valor, aumento = 0, final = 0;

                //valor = Convert.ToDouble(Console.ReadLine());

                //if (valor <= 600)
                //{
                //    aumento = 30.0 / 100;
                //    final = valor + (aumento * valor);
                //    Console.WriteLine("\n\tSalario com aumento: " + final);
                //}
                //if (valor > 600 && valor <= 1100.00)
                //{
                //    aumento = 25.0 / 100;
                //    final = valor + (aumento * valor);
                //    Console.WriteLine("\n\tSalario com aumento: " + final);

                //}
                //if (valor > 1100 && valor <= 2400.00)
                //{
                //    aumento = 20.0 / 100;
                //    final = valor + (aumento * valor);
                //    Console.WriteLine("\n\tSalario com aumento: " + final);
                //}
                //if (valor > 2400.00 && valor <= 3550.00)
                //{
                //    aumento = 15.0 / 100;
                //    final = valor + (aumento * valor);
                //    Console.WriteLine("\n\tSalario com aumento: " + final);
                //}
                //else
                //{
                //    aumento = 10.0 / 100;
                //    final = valor + (aumento * valor);
                //    Console.WriteLine("\n\tSalario com aumento: " + final);

                //}


            }


            //EXERCICIO 10

            {

                //double des, final = 0.0, compra;
                //string ss;
                //int n, a = 5;

                //Console.WriteLine("\n\tInforme o valor da compra:");
                //compra = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine("\n\tInforme se o cliente tem cartão fidelidade:");
                //ss = Console.ReadLine();

                //Console.WriteLine("\n\tInforme o numero da compra do cliente:");
                //n = Convert.ToInt32(Console.ReadLine());

                //Console.Clear();

                //Console.WriteLine("\n\tO valor original da compra é de: {0} ", compra);

                //final = compra;

                //if (compra > 0.00 && compra <= 200.00)
                //{
                //    final = compra;

                //}
                //else if (compra > 200.00 && compra <= 400.00)
                //{
                //    des = 10.0 / 100;
                //    final = final - (des * final);

                //}
                //else
                //{
                //    des = 20.0 / 100;
                //    final = final - (des * final);
                //    Console.WriteLine("if 3 rodando");

                //}

                //if (ss == "sim")
                //{

                //    des = 15.0 / 100;
                //    final = final - (des * final);

                //}
                //if (n == a)
                //{

                //    des = 10.0 / 100;
                //    final = final - (des * final);

                //}
                //Console.WriteLine("\tO valor com desconto é:" + final);



            }


        }
    }
}
