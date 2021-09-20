using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aula_07._06
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Exec 01
            {
                //Obj pes = new Obj();
                //Console.WriteLine("Preencha esta pessoa");
                //pes.nome = Console.ReadLine();
                //pes.idade = int.Parse(Console.ReadLine());
                //pes.cpf = Console.ReadLine();
                //pes.endereco = Console.ReadLine();
                //Console.WriteLine("-----------//-------------");
                //Console.WriteLine(pes.nome);
                //Console.WriteLine(pes.idade);
                //Console.WriteLine(pes.cpf);
                //Console.WriteLine(pes.endereco);
            }


            //Exec 02
            {
                //List<Obj> doginhos = new List<Obj>();

                ////preenche a lista
                //for (int i = 0; i < 3; i++)
                //{
                //    Console.WriteLine("Insira o doginho");
                //    Obj cao = new Obj();
                //    cao.nome = Console.ReadLine();
                //    cao.nomeDoDono = Console.ReadLine();
                //    cao.idade = Convert.ToInt32(Console.ReadLine());
                //    doginhos.Add(cao);
                //}
                //Console.WriteLine("-----------//-----------");

                ////mostrar a lista, apenas cachorros velhos
                //foreach (var item in doginhos)
                //{
                //    if (item.idade > 6)
                //    {
                //        Console.WriteLine(item.nome);
                //        Console.WriteLine(item.nomeDoDono);
                //        Console.WriteLine(item.idade);
                //        Console.WriteLine("-----------//-----------");
                //    }
                //}

            }


            //EX 03

            {

                //Obj mulher = new Obj();
                //Obj homem = new Obj();

                //List<Obj> pes = new List<Obj>();

                //for (int i = 0; i < 5; i++)
                //{
                //    Console.WriteLine("\n\tInsira uma nova pessoa:");
                //    Obj aux = new Obj();
                //    aux.nome = Console.ReadLine();
                //    aux.idade = Convert.ToInt32(Console.ReadLine());
                //    aux.genero = Console.ReadLine();
                //    pes.Add(aux);

                //    if (aux.genero == "m")
                //    {
                //        mulher.nome = aux.nome;
                //        mulher.idade = aux.idade;
                //        mulher.genero = aux.genero;
                //    }
                //    if (aux.genero == "h")
                //    {
                //        homem.nome = aux.nome;
                //        homem.idade = aux.idade;
                //        homem.genero = aux.genero;
                //    }
                //}

                //int aux1 = mulher.idade;
                //int aux2 = homem.idade;

                //foreach (var item in pes)
                //{
                //    if (item.idade > aux1 && item.genero == "m")
                //    {
                //        mulher.nome = item.nome;
                //        mulher.idade = item.idade;
                //        mulher.genero = item.genero;
                //    }
                //    if (item.idade > aux2 && item.genero == "h")
                //    {
                //        homem.nome = item.nome;
                //        homem.idade = item.idade;
                //        homem.genero = item.genero;
                //    }
                //}

                //Console.WriteLine("\n\n.............................\n");

                //Console.WriteLine("Homem:");
                //Console.WriteLine(homem.nome);
                //Console.WriteLine(homem.idade);
                //Console.WriteLine(".............................");
                //Console.WriteLine("Mulher:");
                //Console.WriteLine(mulher.nome);
                //Console.WriteLine(mulher.idade);

            }


            //EX 04

            {

                //int i = 0;
                //List<Obj> zoo = new List<Obj>();

                //Obj x = new Obj();

                //for (i = 0; i < 3; i++)
                //{
                //    Console.WriteLine("\n\tInsira uma nova pessoa:");
                //    Obj aux = new Obj();
                //    aux.nome = Console.ReadLine();
                //    aux.especie = Console.ReadLine();
                //    aux.tempo = Convert.ToInt32(Console.ReadLine());
                //    zoo.Add(aux);
                //}

                //if (zoo[0].tempo > zoo[1].tempo)
                //{
                //    x.nome = zoo[0].nome;
                //    x.especie = zoo[0].especie;
                //    x.tempo = zoo[0].tempo;

                //    zoo[0].nome = zoo[1].nome;
                //    zoo[0].especie = zoo[1].especie;
                //    zoo[0].tempo = zoo[1].tempo;

                //    zoo[1].nome = x.nome;
                //    zoo[1].especie = x.especie;
                //    zoo[1].tempo = x.tempo;


                //}
                //if (zoo[1].tempo > zoo[2].tempo)
                //{
                //    x.nome = zoo[1].nome;
                //    x.especie = zoo[1].especie;
                //    x.tempo = zoo[1].tempo;

                //    zoo[1].nome = zoo[2].nome;
                //    zoo[1].especie = zoo[2].especie;
                //    zoo[1].tempo = zoo[2].tempo;

                //    zoo[2].nome = x.nome;
                //    zoo[2].especie = x.especie;
                //    zoo[2].tempo = x.tempo;
                //}

                //Console.WriteLine("\n\n.............................\n");

                //foreach (var item in zoo)
                //{

                //    Console.WriteLine(item.nome);


                //}
            }


          

        }

    }
}
