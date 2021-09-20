using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO 1 

            {
                //int[] nome_vetor = new int[2];   // declarando o vetor.
                //Console.WriteLine("\n\tInforme dois valores:\n");
                //nome_vetor[0] = int.Parse(Console.ReadLine());
                //nome_vetor[1] = Convert.ToInt32(Console.ReadLine());
                //if(nome_vetor [0] > nome_vetor[1])
                //{
                //    Console.WriteLine("\n\t{0}", nome_vetor[0]);
                //}
                //else
                //{
                //    Console.WriteLine("\n\t{0}", nome_vetor[1]);
                //}

            }

            //EXERCICIO 2 

            {

                //double[] v = new double[3];   // declarando o vetor.
                //double media = 0.0;
                //int i;

                //Console.WriteLine("\n\tInforme dois valores:\n");

                //for( i = 0; i>3; i++)
                //{

                //   v[i] = Convert.ToDouble(Console.ReadLine());

                //    media += v[i];
                //}

                //media /= v[i];

                //Console.WriteLine("\n\tA media das notas inseridas é: {0}", media);

            }

            //EXERCICIO 3

            {


                //    int[] v = new int[5];   // declarando o vetor.
                //    int soma= 0, i;



                //    for (i = 0; i < 5; i++)
                //    {
                //        Console.WriteLine("\n\tInforme o valor {0}:\n", i);
                //        v[i] = Convert.ToInt32(Console.ReadLine());

                //        soma += v[i];

                //    }

                //    Console.WriteLine("\n\tA soma dos valores informado é: {0}", soma);


                //}








            }


            //EXERCICIO 4


            {
                //string[] nome_a = new string[5];
                //int[] idade = new int[3];
                //double[] cpf = new int[12];
                //int i, x;
                //string aux;



                //Console.WriteLine("\n\t->LISTA DE ALUNOS JÁ CADASTRADOS:\n\t(Ou posições livres pra cadastro)");

                //for (i = 0; i < 4; i++)
                //{
                //    Console.WriteLine("\n\t{0}: {0}\n", i);
                //}

                //while (true)
                //{

                //    Console.WriteLine("\n\t-------------------");
                //    Console.WriteLine("\n\tDeseja cadastrar um novo aluno?\n");
                //    Console.WriteLine("\tSe sim, informe a posição;\n");
                //    Console.WriteLine("\tSe deseja encerrar o programa: exit;\n");

                //    aux = Console.ReadLine();

                //    if (aux == "exit")
                //    {
                //        Console.WriteLine("\n\t--------------------");
                //        Console.WriteLine("\n\tPrograma encerrado.");
                //        Console.WriteLine("\n\tAlunos cadastrados:\n");

                //        for (i = 0; i < nome_a.Length; i++)
                //        {
                //            Console.WriteLine("\n\t{0}:\n", i);
                //            Console.WriteLine("\n\t\t{0}", nome_a[i]);
                //            Console.WriteLine("\n\t\t{0}", idade[i]);
                //            Console.WriteLine("\n\t\t{0}", cpf[i]);
                //        }
                //        break;

                //    }
                //    else
                //    {
                //        Console.Clear();

                //        x = Convert.ToInt32(aux);

                //        Console.WriteLine("\n\tInforme o nome do aluno:");
                //        nome_a[x] = Console.ReadLine();

                //        Console.WriteLine("\n\tInforme a idade do aluno:");
                //        idade[x] = Convert.ToInt32(Console.ReadLine());

                //        Console.WriteLine("\n\tInforme o CPF do aluno:");
                //        cpf[x] = Convert.ToDouble(Console.ReadLine());

                //        Console.WriteLine("\n\tCADASTRO FINALIZADO.");
                //        Console.WriteLine("\n\tLista de alunos atualizada:");

                //        for (i = 0; i < 3; i++)
                //        {
                //            Console.WriteLine("\n\t{0}:\n", i + 1);
                //            Console.WriteLine("\n\t\t{0}\n", nome_a[i]);
                //            Console.WriteLine("\n\t\t{0}\n", idade[i]);
                //            Console.WriteLine("\n\t\t{0}\n", cpf[i]);
                //        }

                //    }

                //}


            }


            //EXERCICIO 5

            {

                //string[] vagas = new string[10];
                //double[] hora = new double[10];
                //int i;
                //double h2;
                //string cond, aux;
                //for (i = 0; i < 10; i++)
                //{

                //    vagas[i] = "livre";
                //    hora[i] = 0;
                //}

                //Console.WriteLine("\n\tSISTEMA INICIADO:\n\n");
                //Console.WriteLine("\n\tO cliente esta entrando ou saindo?");
                //cond = Console.ReadLine();


                //do
                //{


                //    if (cond == "entrando")
                //    {
                //        i = 0;

                //        do
                //        {


                //            if (vagas[i] == "livre")
                //            {

                //                Console.WriteLine("\n\tInforme a placa: ");
                //                vagas[i] = Console.ReadLine();

                //                Console.WriteLine("\n\tInforme o horario de entrada:\n");
                //                hora[i] = Convert.ToDouble(Console.ReadLine());

                //            }
                //            else
                //            {
                //                i += 1;
                //            }

                //        } while (vagas[i] != "livre");

                //    }

                //        if(cond == "saindo")
                //        {
                //            Console.WriteLine("\n\tInforme a placa do carro que está saindo:");
                //            aux = Console.ReadLine();
                //            i = 0;
                //            do
                //            {
                //                if(aux == vagas[i])
                //                {
                //                    Console.WriteLine("\n\tQual o horario de saida do caro?");
                //                    h2 = Convert.ToDouble(Console.ReadLine());                                    
                //                    hora[i] = h2 - hora[i] * 3.50;
                //                    vagas[i] = "livre";
                //                    Console.WriteLine("\n\tO carro deve pagar: R$ {0}", hora[i]);

                //                }
                //            } while (aux != vagas[i]);

                //        hora[i] = 0;
                //        vagas[i] = "livre";
                //        }


                //    Console.WriteLine("\n\tDeseja repetir o processo?\n");
                //        aux = Console.ReadLine();

                //    if(aux == "não")
                //    {
                //        break;
                //    }
                //    else
                //    {
                //        Console.Clear();
                //        Console.WriteLine("\n\tO cliente esta entrando ou saindo?");
                //        cond = Console.ReadLine();
                //    }


                //} while (true);



            }



            //EXERCICIO 1 lista 2

            {

                //int[] V1 = new int[5];
                //int[] V2 = new int[5];
                //int[] V3 = new int[5];
                //int aux;

                //Console.WriteLine("\n\tVETOR 1:\n\n");

                //for (int i = 0; i > 5; i++)
                //{
                //    Console.WriteLine("\n\tInforme o valor da posição V1[{0}]", i);
                //    aux = Convert.ToInt32(Console.ReadLine());
                //    V1[i] = aux;

                //}

                //Console.WriteLine("\n\t--------------------------\n");
                //Console.WriteLine("\n\tVETOR 1:\n\n");

                //for (int i = 0; i > 5; i++)
                //{
                //    Console.WriteLine("\n\tInforme o valor da posição V2[{0}]", i);
                //    aux = Convert.ToInt32(Console.ReadLine());
                //    V2[i] = aux;

                //}

                //Console.WriteLine("\n\t--------------------------\n");
                //Console.WriteLine("\n\tResultado da soma dos vetores:\n\n");

                //for (int i = 0; i < 5; i++)
                //{

                //    V3[i] = V1[i] + V2 [i];
                //    Console.WriteLine("\n\tV[{0}]: {0}", i, V3[i]);
                //}




            }


            //EXERCICIO 2 lista 2

            {


                //int[] prod = new int[5] { 10, 1, 5, 4, 35 };   // verto dos produtos
                //int[] carrinho = new int[10];
                //int cont = 0, valor = 0, n;
                //string cond;

                //Console.WriteLine("\n\tLISTA DE PRODUTOS:\n");
                //Console.WriteLine("\tCuca = 1\n\tPão = 2\n\tPastel = 3\n\tCoxinha = 4\n\tBolo = 5\n");
                //Console.WriteLine("\n\tPara finalizar a compra digite: fim ou acabou\n");
                //Console.WriteLine("\n\tPara obter o valor atual da compra digite: valor\n");
                //Console.WriteLine("\n\t---------------------\n");
                //Console.WriteLine("\n\tCompra iniciada.\n\n");

                //while (cont <= 10)
                //{

                //    cond = Console.ReadLine();

                //    if (cond == "fim" || cond == "acabou")
                //    {
                //        Console.WriteLine("\n\tCompra finalizada.\n");
                //        Console.WriteLine("\n\tO valor a ser pago é de: {0}", valor);

                //        break;
                //    }
                //    else if (cond =="valor")
                //    {

                //        Console.WriteLine("\n\tO valor a ser pago é de: {0}", valor);

                //    }
                //    else
                //    {
                //        n = Convert.ToInt32(cond);

                //        switch (n)
                //        {
                //            case 1:

                //                valor += carrinho[0];


                //                break;
                //            case 2:

                //                valor += carrinho[1];

                //                break;
                //            case 3:

                //                valor += carrinho[2];

                //                break;
                //            case 4:

                //                valor += carrinho[3];

                //                break;
                //            case 5:
                //                valor += carrinho[4];

                //                break;
                //            default:
                //                Console.WriteLine("\n\tO produto não está catalogado.\n\tInforme outro produto\n");

                //                break;
                //        }

                //        cont++;




                //    }



                //}
            }


            //EXERCICIO 3 lista 2

            {


                //char[] letras = new char[22] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v' };
                //char[] senha = new char[10];
                //string x;
                //int i, j = 0, cont = 0;
                //char aux;


                //Console.WriteLine("\n\tInforme a senha de no maximo 10 caracteres:\n");

                //x = Console.ReadLine();

                //for (i = 0; i < x.Length; i++)
                //{
                //    aux = x[i];

                //    do
                //    {

                //        if (aux == letras[j])
                //        {
                //            aux = letras[j + 3];
                //            cont = 1;
                //        }
                //        else
                //        {
                //            j++;

                //        }

                //    } while (cont != 1);

                //    senha[i] = aux;

                //    // caso queira deixar o programa mais compacto, apenas liberar essa linha e apagar o proximo for
                //    // Console.WriteLine("{0}", senha[i]); 

                //    cont = 0;
                //    j = 0;
                //}

                //Console.WriteLine("\n\tA senha com a criptografia de Cesar:\n");

                //for (i = 0; i < x.Length; i++)
                //{
                //    Console.WriteLine("\t\t{0}", senha[i]);

                //}


            }


            //EXERCICIO 4 lista 2

            {


                //char[] letras = new char[22] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v' };
                //char[] senha = new char[10];
                //string x;
                //int i, j = 0, cont = 0;
                //char aux;


                //Console.WriteLine("\n\tInforme a senha criptografada:\n");

                //x = Console.ReadLine();

                //for (i = 0; i < x.Length; i++)
                //{
                //    aux = x[i];

                //    do
                //    {

                //        if (aux == letras[j])
                //        {
                //            aux = letras[j - 3];
                //            cont = 1;
                //        }
                //        else
                //        {
                //            j++;

                //        }

                //    } while (cont != 1);

                //    senha[i] = aux;

                //    // caso queira deixar o programa mais compacto, apenas liberar essa linha e apagar o proximo for
                //    // Console.WriteLine("{0}", senha[i]); 

                //    cont = 0;
                //    j = 0;
                //}

                //Console.WriteLine("\n\tA senha descriptografada:\n");

                //for (i = 0; i < x.Length; i++)
                //{
                //    Console.WriteLine("\t\t{0}", senha[i]);

                //}





            }

            //EXERCICIO 1 lista 3

            {
                //int i;
                //int[] v = new int[5];

                //for (i = 0; i < 5; i++)
                //{
                //    Console.WriteLine("\n\tInforme o valor {0}: ",i);
                //    v[i] = Convert.ToInt32(Console.ReadLine());
                //}

                //Array.Sort(v);

                //for(i = 4; i >= 0; i--)
                //{
                //    Console.WriteLine("\n\t{0}", v[i]);
                //}


            }


            //EXERCICIO 2 lista 3

            {

                //string[] user = new string[5];
                //string[] senha = new string[5];
                //int cond, i, j;
                //string del;

                //while (true)
                //{



                //    for (i = 1; i < 5; i++)
                //    {
                //        user[i] = "vazio";
                //        senha[i] = "vazio";


                //    }

                //    Console.WriteLine("\n\tInforme o user:");
                //    user[0] = Console.ReadLine();

                //    Console.WriteLine("\n\tSENHA:");
                //    senha[0] = Console.ReadLine();



                //    if (user[0] == "Admin" && senha[0] == "@proway")
                //    {
                //        Console.WriteLine("\tPara criar novo User: 1\n\tPara deletar um User: 2\n\tPara LogOut: 3\n");
                //        cond = Convert.ToInt32(Console.ReadLine());
                //        Console.Clear();
                //        Console.WriteLine("\n--------------------\n");

                //        do
                //        {

                //            if (cond == 1 && user[0] == "Admin" && senha[0] == "@proway")
                //            {
                //                Console.WriteLine("\tOPÇÃO SELECIONADA: Criar um novo User.\n\n\tLISTA DE USER'S ATUAIS:");

                //                for (i = 1; i < 5; i++)
                //                {
                //                    Console.WriteLine("\n\t-----------  {0}  --------------\n", i);
                //                    Console.WriteLine("\n\t\tUser: {0}", user[i]);


                //                }

                //                Console.WriteLine("\n\tEm qual posição deseja criar um novo user?");
                //                cond = Convert.ToInt32(Console.ReadLine());

                //                Console.WriteLine("\n\tNome do novo user:");
                //                user[cond] = Console.ReadLine();
                //                Console.WriteLine("\n\tInforme a senha para o user {0}", user[cond]);
                //                senha[cond] = Console.ReadLine();

                //                Console.WriteLine("\n\tNOVO USUARIO SALVO COM SUCESSO!");
                //                Console.WriteLine("\n\tLista de usuarios atualizada:");
                //                for (i = 1; i < 5; i++)
                //                {
                //                    Console.WriteLine("\n\t-----------  {0}  --------------\n", i);
                //                    Console.WriteLine("\n\t\tUser: {0}", user[i]);


                //                }

                //                Console.WriteLine("\n\tDIGITE:");
                //                Console.WriteLine("\n\t1 - Para cadastrar um novo user");
                //                Console.WriteLine("\n\t2 - Para deletar um user");
                //                Console.WriteLine("\n\t3 - Para LogOut.");
                //                cond = Convert.ToInt32(Console.ReadLine());
                //            }

                //            else if (cond == 2 && user[0] == "Admin" && senha[0] == "@proway")
                //            {
                //                Console.WriteLine("\tOPÇÃO SELECIONADA: Deletar um User.\n\n\tLISTA DE USER'S ATUAIS:");

                //                for (i = 1; i < 5; i++)
                //                {
                //                    Console.WriteLine("\n\t-----------  {0}  --------------\n", i);
                //                    Console.WriteLine("\n\t\tUser: {0}", user[i]);
                //                }

                //                Console.WriteLine("\n\tQual o user a ser deletado?");
                //                del = Console.ReadLine();

                //                j = 0;

                //                for (i = 1; i < 5; i++)
                //                {
                //                    if (del == user[j])
                //                    {
                //                        user[i] = "vazio";
                //                        senha[i] = "vazio";
                //                    }
                //                    else
                //                    {
                //                        j++;
                //                    }

                //                }

                //                Console.WriteLine("\n\tUSUARIO {0} DELETADO COM SUCESSO!\n", del);
                //                Console.WriteLine("\n\tLISTA DE USERS ATUAIS:");

                //                for (i = 1; i < 5; i++)
                //                {
                //                    Console.WriteLine("\n\t-----------  {0}  --------------\n", i);
                //                    Console.WriteLine("\n\t\tUser: {0}", user[i]);
                //                }

                //                Console.WriteLine("\n\tDIGITE:");
                //                Console.WriteLine("\n\t1 - Para cadastrar um novo user");
                //                Console.WriteLine("\n\t2 - Para deletar um user");
                //                Console.WriteLine("\n\t3 - Para LogOut.");
                //                cond = Convert.ToInt32(Console.ReadLine());



                //            }
                //            else if (cond == 3 && user[0] == "Admin" && senha[0] == "@proway")
                //            {
                //                Console.Clear();
                //                Console.WriteLine("\n\tLOGOUT REALIZADO!\n");
                //                Console.WriteLine("\n\tEscolha um novo usuario:\n\n");

                //                for (i = 1; i < 5; i++)
                //                {

                //                    Console.WriteLine("\n\t\tUser: {0}", user[i]);
                //                }


                //                Console.WriteLine("\n\n\tInforme o user:");
                //                user[0] = Console.ReadLine();

                //                Console.WriteLine("\n\n\tSENHA:");
                //                senha[0] = Console.ReadLine();


                //                Console.WriteLine("\n\tDIGITE:");
                //                Console.WriteLine("\n\t1 - Para cadastrar um novo user");
                //                Console.WriteLine("\n\t2 - Para deletar um user");
                //                Console.WriteLine("\n\t3 - Para LogOut.");
                //                cond = Convert.ToInt32(Console.ReadLine());
                //            }


                //        } while (cond != 3);



                //    }
                //    else
                //    {
                //        Console.WriteLine("\n\tLOGIN EFETUADO COM SUCESSO!\n\n\t");
                //    }

                //}

            }
        }
    }
}
