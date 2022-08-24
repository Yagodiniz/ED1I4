using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade das aulas de 17/08/2022 e 19/08/2022
{
    class Venda
    {
        private static int qtd;
        private static double valor;

        #region Getter & Setters

        public int Qtd { get => qtd; set => qtd = value; }
        public double Valor { get => valor; set => valor = value; }

        #endregion

        public double valorMedio()
        {
            return valor / qtd;
        }
    }
}
