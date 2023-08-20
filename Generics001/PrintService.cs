using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics001
{
    internal class PrintService<T>
    {//variavel interna que podera armazenar 10 numeros inteiros
        private  T[] _values = new T[10];

        private int _count = 0;//variavel responsavel para fazer a contagem dos numeros 

        //criar função agora metodo de adicionar

        public void AddValue (T value)
        {

            if(_count == 10 )
            {
                throw new InvalidOperationException("Print servece já esta cheio !!!");

            }
            //meu vetor chamado: _value na posição _count ira receber o valor 
            //meu _vetor = tem 10 posiçoes de 0 ate 9
            //
            _values[_count] = value;
            _count++;//atualizar a variavel count e necessario
        }

        //metodo para retornar o primeiro elemento do meu projeto (PrintServece)

        public T First()
        {   //programação defensiva ( exceção)
            if (_count == 0)
            {
                throw new InvalidOperationException("Print servece esta vazio !!!");

            }

            return _values[0];
        }
        public void print ()
        {
            Console.Write($" [ ");

            for (int i = 0; i < _count -1;i++) {
                
                //paga cada elemento imprima
                Console.Write(_values[i] + ", " );
            
            }
            //imprimir o ultimo valor 
            if(_count > 0 ) {
                Console.Write(_values[_count -1]);

            }

            Console.WriteLine("]");


        }
    }
}
