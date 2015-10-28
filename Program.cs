using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAlunos
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<Aluno> listaAlunos = new List<Aluno>();

            int continuar = 1;
            while (continuar == 1)
            {
                Console.WriteLine("Digite um nome para inserir na lista:");
                listaAlunos.Add(new Aluno {Nome = Console.ReadLine()});

                Console.WriteLine("Inserir um novo aluno? 1-SIM | 2-NÃO");
                continuar = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("A sala de aula possui " + listaAlunos.Count + " alunos!");
            Console.WriteLine("Em quantos grupos deseja dividir a sala?");
            int qtdGrupos = int.Parse(Console.ReadLine());

            if (qtdGrupos > listaAlunos.Count)
            {
                Console.Clear();
                Console.WriteLine("O numero de grupos não deve ser maior que o numero de alunos");
            }
            
            foreach (var vNome in listaAlunos)
            {
                Console.WriteLine(vNome.Nome);
            }



            //List<int> inteiros = new List<int>();
            //List<int> inteiros2 = new List<int>();

            //Random rand = new Random(inteiros.Count);
            //foreach (var inteiro in inteiros)
            //{
            //    var inteiro2 = inteiros[rand.Next()];
            //    inteiros2.Add(inteiro2);
            //}


            Console.ReadKey();
        }
    }
}