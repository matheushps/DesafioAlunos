using System;
using System.Collections.Generic;

namespace DesafioAlunos
{
    public class Grupo
    {
        public void DividirGrupo(List<Aluno> listaAlunos, int qtdGrupo)
        {
            double alunos = listaAlunos.Count / qtdGrupo;
            alunos = Math.Ceiling(alunos);

            int contador = 0;
            int grupo = 1;

            foreach (var pessoas in listaAlunos)
            {
                if (contador > alunos)
                {
                    contador = 0;
                    grupo++;
                }
                pessoas.Id = grupo;

                Console.WriteLine("{0}   Grupo {1} ", pessoas.Nome.PadRight(10, ' '), pessoas.Id);
                contador++;
            }
        }
    }
}
