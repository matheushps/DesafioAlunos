using System;
using System.Collections.Generic;

namespace DesafioAlunos
{
    public class SorteioGrupos
    {
        public void MisturarGrupos(List<Aluno> obj)
        {
            Random random = new Random();
            Aluno aluno;
            int valor;

            for (int i = 0; i < obj.Count; i++)
            {
                valor = random.Next(obj.Count);
                aluno = obj[i];
                obj[i] = obj[valor];
                obj[valor] = aluno;

            }
        }
    }
}
