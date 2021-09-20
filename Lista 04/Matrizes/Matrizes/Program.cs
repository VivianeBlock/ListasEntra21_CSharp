using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*                       LEMBRETE: 
                   matriz.Length = PERCORRE AS LINHAS.
            matriz[i].Length = PERCORRE AS COLUNAS DA LINHA I.     */

            //FORMAS PARA DECLARAR E PERCORRER:

            {


                //int[][] matriz = new int[4][]   // aqui tem que declarar a matriz já com o numero de linhas que ela terá...
                //for (int i = 0; i < matriz.Length; i++)
                //{
                //    matriz[i] = new int[4];     //aqui criamos um for para adicionar as colunas na matriz. (no caso 4)
                //}

                //// fazendo agora um for para percorrer a matriz e armazenar os valores:

                //for (int i = 0; i <matriz.Length; i++)      //esse for percorre todas as linhas com o matriz.Length
                //{
                //    for (int j = 0; j < matriz[i].Length; j++)   //esse for percorre todas as colunas da linha i com o: matriz[i].Length
                //    {

                //        Console.WriteLine("\n\tInforme o valor[{0}][{0}]: ");
                //        matriz[i][j] = Convert.ToInt32(Console.ReadLine());

                //    }



                //}




                // OUTRA FORMA DE DECLARAR:

                //int x = 5, y = 5;
                //int[,] diagonal = new int[x, y]; // quando isso acontece deve-se preencher os dois campos da ultima chave com a variavel que tem o valor desejado.

                //for (int i = 0; i < x; i++)
                //{
                //    for (int j = 0; j < y; j++)
                //    {


                //    }
                //}




            }


            //COPIANDO MATRIX:

            {

                // Essa forma de copia só é valida se a matriz em si - a que está sendo copiada - não estiver comentada
                // O que é bem na cara... Mas não custa nada lembrar...

                //int[][] matriz = new int[4][]   // aqui tem que declarar a matriz já com o numero de linhas que ela terá...
                // for (int i = 0; i < matriz.Length; i++)
                // {
                //    matriz[i] = new int[4];     //aqui criamos um for para adicionar as colunas na matriz. (no caso 4)
                // }


                //int[][] = MatrizCop = matriz;
                //int[][] = matrizCopia = new int[1][];

            }



            /*------------------------------------------------------------*/




            //EXERCICIO 1

            {

                //int x = 5, y = 5;
                //int[,] diagonal = new int[x, y]; // quando isso acontece deve-se preencher os dois campos da ultima chave com a variavel que tem o valor desejado.

                //for (int i = 0; i < x; i++)
                //{
                //    for (int j = 0; j < y; j++)
                //    {
                //        if (i == j)
                //        {
                //            diagonal[i, j] = 1;
                //        }
                //        else
                //        {
                //            diagonal[i, j] = 0;
                //        }

                //    }

                //}

                ////printando na tela:

                //for (int i = 0; i < x; i++)
                //{
                //    for (int j = 0; j < y; j++)
                //    {
                //        Console.Write(diagonal[i, j] + " "); // colocar write em vez do WriteLine, faz com que ele não pule uma linha.

                //    }

                //    Console.WriteLine(); // vai pular uma linha
                //}



            }



            //EXERCICIO 2

            {
                //int x;
                //int[][] matriz = new int[2][];   
                // for (int i = 0; i < matriz.Length; i++)
                // {
                //    matriz[i] = new int[2];  
                // }

                //for (int i = 0; i < matriz.Length; i++)
                //{
                //    for (int j = 0; j < matriz[i].Length; j++)
                //    {
                //        Console.WriteLine("Informe o valor da posição[{0}][{0}]:", i,j);
                //        matriz[i][j] = Convert.ToInt32(Console.ReadLine());

                //    }

                //}

                //Console.WriteLine("Informe o valor para a busca:");
                //x = Convert.ToInt32(Console.ReadLine());

                //for (int i = 0; i < matriz.Length; i++)
                //{
                //    for (int j = 0; j < matriz[i].Length; j++)
                //    {
                //        if(x == matriz[i][j])
                //        {
                //            Console.WriteLine("Valor {0} encontrado na posição: [{0}][{0}]",x, i,j);
                //        }

                //    }

                //}




            }


            //EXERCICIO 3

            {

                //int[][] matriz = new int[4][];

                //for (int i = 0; i < matriz.Length; i++)
                //{
                //    matriz[i] = new int[4];
                //}

                //int[][] matriz2 = matriz;
                //int[][] matriz3 = matriz;

                //for (int i = 0; i < matriz.Length; i++)
                //{
                //    for (int j = 0; j < matriz[i].Length; j++)
                //    {
                //        Console.WriteLine("Informe o valor "+i+" "+j+ ":");
                //        matriz[i][j] = Convert.ToInt32(Console.ReadLine());
                //    }

                //}

                //Console.WriteLine("\t\tMATRIZ 2:\n");

                //for (int i = 0; i < matriz2.Length; i++)
                //{
                //    for (int j = 0; j < matriz2[i].Length; j++)
                //    {
                //        Console.WriteLine("Informe o valor " + i + " " + j + ":");
                //        matriz2[i][j] = Convert.ToInt32(Console.ReadLine());
                //    }

                //}

                //Console.WriteLine(" ");

                //for (int i = 0; i < matriz3.Length; i++)
                //{
                //    for (int j = 0; j < matriz3[i].Length; j++)
                //    {
                //       if(matriz[i][j] > matriz2[i][j])
                //       {

                //            matriz3[i][j] = matriz[i][j];

                //        }
                //        else
                //        {
                //            matriz3[i][j] = matriz2[i][j];
                //        }

                //        Console.Write("\t{0} ", matriz3[i][j]);
                //    }

                //    Console.WriteLine(" ");

                //}



            }


            //EXERCICIO 4

            {

                //int[][] A = new int[10][]; // Passar para uma matriz 10X10

                //for (int i = 0; i < A.Length; i++)
                //{
                //    A[i] = new int[10]; 
                //}

                //for (int i = 0; i < A.Length; i++)
                //{
                //    for (int j = 0; j < A[i].Length; j++)
                //    {
                //        Console.WriteLine("\tInforme o valor da posição "+i+" "+j+":");
                //        A[i][j] = Convert.ToInt32(Console.ReadLine());



                //    }

                //}




                //for (int i = 0; i < A.Length; i++)
                //{
                //    for (int j = 0; j < A[i].Length; j++)
                //    {
                //        if (i < j)
                //        {
                //            A[i][j] = (2 * i) + (7 * j) - 2;
                //        }
                //        else if (i == j)
                //        {
                //            A[i][j] = (3 * i) - 1;
                //        }
                //        else
                //        {
                //            A[i][j] = (4 * i) - (5 * j) + 1;

                //        }

                //        Console.Write("\t{0}", A[i][j]);
                //    }

                //    Console.WriteLine();
                //}









            }


            //EXERCICIO 5

            {
                //int soma = 0;

                //int[][] A = new int[3][]; 


                //for (int i = 0; i < A.Length; i++)
                //{
                //    A[i] = new int[3];
                //}


                //for (int i = 0; i < A.Length; i++)
                //{
                //    for (int j = 0; j < A[i].Length; j++)
                //    {
                //        Console.WriteLine("\tInforme o valor da posição " + i + " " + j + ":");
                //        A[i][j] = Convert.ToInt32(Console.ReadLine());
                //        if (i < j)
                //        {
                //            soma += A[i][j];

                //        }
                //    }

                //}


                //for (int i = 0; i < A.Length; i++)
                //{
                //    for (int j = 0; j < A[i].Length; j++)
                //    {

                //        Console.Write("\t{0}", A[i][j]);
                //    }

                //    Console.WriteLine();
                //}

                //Console.WriteLine("\n\tAsoma acima da diagonal principal é: {0}", soma);




            }


            //EXERCICIO 6

            {

                //int soma = 0;

                //int[][] A = new int[3][];


                //for (int i = 0; i < A.Length; i++)
                //{
                //    A[i] = new int[3];
                //}


                //for (int i = 0; i < A.Length; i++)
                //{
                //    for (int j = 0; j < A[i].Length; j++)
                //    {
                //        Console.WriteLine("\tInforme o valor da posição " + i + " " + j + ":");
                //        A[i][j] = Convert.ToInt32(Console.ReadLine());

                //        if (i>j)
                //        {
                //            soma += A[i][j];

                //        }
                //    }

                //}


                //for (int i = 0; i < A.Length; i++)
                //{
                //    for (int j = 0; j < A[i].Length; j++)
                //    {

                //        Console.Write("\t{0}", A[i][j]);
                //    }

                //    Console.WriteLine();
                //}

                //Console.WriteLine("\n\tAsoma acima da diagonal principal é: {0}", soma);



            }


        }
    }
}
