using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSafety_Performace.Service
{
     class PrintService
    {
        private object[] _numero = new object[10];
        private int _contar = 0;

        public void AdicionaValor(object valor)
        {
            if (_contar == 10) 
            {
                throw new InvalidOperationException("Valor mairo que  o permitidos.");
            }
            _numero[_contar] = valor;
            _contar++;

        }

        public object PrimeiroValor()
        {
            if (_contar == 0)
            {
                throw new InvalidOperationException("O vetor já está Vazio.");
            }
            return _numero[0];
        }

        public void Imprimir()
        {
            Console.Write("[");
            for (int i = 0; i < _contar - 1; i++)// -1  para ir apenas até o penultimo item
            {
                Console.Write($"{_numero[i]}, ");
            }
            if (_contar > 0)
            {

                Console.Write(_numero[_contar - 1]);
            }
            Console.Write("]");
        }
    }
}
