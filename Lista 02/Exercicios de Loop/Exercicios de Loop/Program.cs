using System;

namespace Exercicios_de_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCICIO 1

            {
                //int i;

                //for(i=1;i<=10;i++)
                //{
                //    Console.WriteLine("\t{0}\n", i);
                //}


            }

            //EXERCICIO 2

            {

                //int i;

                //for (i = 0; i <= 23; i++)
                //{

                //    if ((i % 2) == 0)
                //    {
                //        Console.WriteLine("\t{0}\n",i);
                //    }

                //}

            }


            //EXERCICIO 3

            {

                //int i, n;

                //Console.WriteLine("\n\tInforme um número: ");
                //n = Convert.ToInt32(Console.ReadLine());

                //for (i = n; i >= 0; i--)
                //{
                //    Console.WriteLine("\n\t{0}",i);
                //}




            }

            //EXERCICIO 4

            {

                //int i, n;

                //Console.WriteLine("\n\tInforme um número: ");
                //n = Convert.ToInt32(Console.ReadLine());

                //if (n > 0)
                //{
                //    for (i = n; i >= 0; i--)
                //    {
                //        Console.WriteLine("\n\t{0}", i);
                //    }

                //}
                //else
                //{
                //    for (i = 0; i >= n; i--)
                //    {
                //        Console.WriteLine("\n\t{0}", i);
                //    }
                //}


            }

            //EXERCICIO 5 

            {

                //double numero;
                //string entrada;
                //while (true)
                //{
                //    Console.WriteLine("insira um numero");
                //    Console.WriteLine("insira exit para sair");
                //    //numero = Convert.ToDouble(Console.ReadLine());
                //    entrada = Console.ReadLine();
                //    if (entrada == "exit")
                //    {
                //        break;
                //    }
                //    numero = Convert.ToDouble(entrada);
                //    if (numero > 24)
                //    {
                //        Console.WriteLine(numero * 2);
                //    }
                //    else if (numero > 0)
                //    {
                //        Console.WriteLine(numero);
                //    }
                //    else
                //    {
                //        Console.WriteLine("insira novamente");
                //    }
                //}





            }


            //EXERCICIO 6

            {
                //string nome, end, cpf;


                //do
                //{
                //    Console.WriteLine("\n\tInforme o nome do aluno(a):\n");
                //    nome = Console.ReadLine();
                //    Console.WriteLine("\n\tInforme o endereço:\n");
                //    end = Console.ReadLine();
                //    Console.WriteLine("\n\tInforme o cpf:\n");
                //    cpf = Convert.ToInt32(Console.ReadLine());

                //    Console.WriteLine("\n\t----------------------");
                //    Console.WriteLine("\tDados do aluno: {0}\n",nome);                                    
                //    Console.WriteLine("\n\tEndereço:{0}\n",end);                  
                //    Console.WriteLine("\n\tCPF:{0}\n",cpf);

                //    Console.WriteLine("\n\t----------------------");
                //    Console.WriteLine("Dedeja cadastrar outro aluno(a)?\n\tDigite:\n\t1 paea sim;\n\t2 para não.", nome);
                //    cpf = Convert.ToInt32(Console.ReadLine());
                //} while (cpf == 1);



            }

            //EXERCICIO 7

            {

                //int dado, valor = 0;

                //for(int i = 0; i <= 30; i++)
                //{
                //    Random ran = new Random();
                //    dado = ran.Next(1, 7);

                //    if (dado >= 3)
                //    {
                //        valor = valor + 10;
                //        //Console.WriteLine("\n\tdado {0}: {0}", dado,valor);
                //    }
                //    else
                //    {
                //        valor = valor - 15;
                //      //  Console.WriteLine("\n\tdado {0}: {0}", dado, valor);
                //    }
                //}

                //if(valor >= 0)
                //{
                //    Console.WriteLine("\n\tVocê ganhou: {0}!", valor);
                //}
                //else
                //{
                //    Console.WriteLine("\n\tVocê perdeu: {0}  :(", valor);
                //}









            }

            //EXERCICIO 8

            {

                //double Q = 4.50, M = 5.00, F = 4.00, Psnt = 5.50, P = 3.75, compra = 0.0, aux = 0.0;
                //int cont_q = 0, cont_m = 0, contador = 0, x = 1, n;
                //string cond, que;

                //Console.WriteLine("\n\tLISTA DE PRODUTOS:\n");
                //Console.WriteLine("\tQueijo = 1\n\tMacarrão = 2\n\tFeijão = 3\n\tPresunto = 4\n\tPão = 5\n");
                //Console.WriteLine("\n\tPara finalizar a compra digite: fim ou acabou\n");
                //Console.WriteLine("\n\t---------------------\n");
                //Console.WriteLine("\n\tCompra iniciada.\n\n");
                //while (x == 1)
                //{

                //    cond = Console.ReadLine();

                //    if (cond == "fim" || cond == "acabou")
                //    {
                //        Console.WriteLine("\n\tCompra finalizada.\n");

                //        if (contador > 7)
                //        {
                //            compra = compra - (compra * 0.1);
                //        }
                //        if (cont_q > 3)
                //        {
                //            aux = cont_q * Q;
                //            aux = aux - (aux * 0.1);
                //            compra += aux;

                //        }
                //        else
                //        {
                //            aux = cont_q * Q;
                //            compra += aux;
                //        }

                //        if (cont_m > 3)
                //        {
                //            aux = cont_m * M;
                //            aux = aux - (aux * 0.1);
                //            compra += aux;

                //        }
                //        else
                //        {
                //            aux = cont_m * M;
                //            compra += aux;
                //        }

                //        Console.WriteLine("\n\tO valor final da compra é de: R$ {0}", compra);

                //        break;
                //    }
                //    else
                //    {
                //        n = Convert.ToInt32(cond);

                //        switch (n)
                //        {
                //            case 1:
                //                cont_q++;


                //                break;
                //            case 2:
                //                cont_m++;

                //                break;
                //            case 3:
                //                compra += F;

                //                break;
                //            case 4:
                //                compra +=Psnt;

                //                break;
                //            case 5:
                //                compra += P; // += é o mesmo que no caso ( compra = compra + P; )

                //                break;

                //        }

                //        contador++;

                //    }







                //}



            }
        }
    }
}
