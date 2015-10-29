using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAlunos
{
    public class Grupo
    {
        private int _quantidadeGrupo;
        public int QuantidadeGrupo
        {

            get
            {
                return this._quantidadeGrupo;
            }

            set
            {
                this._quantidadeGrupo = value > 0 ? value : 0;

            }
        }

            public void DividirGrupos()
            {
                if (QuantidadeGrupo % 2 == 1)
                {

                }

            }
        }
    }

