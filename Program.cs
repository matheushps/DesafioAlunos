using System;
using System.Collections.Generic;


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
                Console.WriteLine("Digite o nome do aluno para inserir na lista:");
                listaAlunos.Add(new Aluno {Nome = Console.ReadLine()});

                Console.WriteLine("Continuar inserindo novos registros? 1-Sim | 2-Não");
                continuar = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("A sala de aula possui " + listaAlunos.Count + " alunos. Em quantos grupos deseja dividir a sala?");
            int qtdGrupos = int.Parse(Console.ReadLine());

            if (qtdGrupos > listaAlunos.Count)
            {
                Console.WriteLine("O numero de grupos não deve ser maior que o numero de alunos");
            }

            SorteioGrupos novoSorteio = new SorteioGrupos();
            novoSorteio.MisturarGrupos(listaAlunos);

            Grupo novoGrupo = new Grupo();
            novoGrupo.DividirGrupo(listaAlunos, qtdGrupos);

            Console.ReadKey();
        }
    }
}
