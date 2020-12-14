using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            lado duploA ;
            lado duploB ;
            lado duploC ;
            resultado duploP ;
            resultado duploA ;

            Console. ForegroundColor = ConsoleColor. DarkYellow;
            Console. WriteLine("Digite o Valor de A: " );
            ladoA = duplo. Parse(Console. ReadLine());

            Console. ForegroundColor = ConsoleColor. Azul Escuro;
            Console. WriteLine("Digite o Valor de B: " );
            ladoB = duplo. Parse(Console. ReadLine());

            Console. ForegroundColor = ConsoleColor. DarkMagenta; 
            Console. WriteLine("Digite o Valor de C: " );
            ladoC = duplo. Parse(Console. ReadLine());
            Console. WriteLine(\n" );

            resultP = (ladoA + ladoB + ladoC) / 2;
            resultadoA = Matemática. Sqrt(resultadoP * (resultP - ladoA) * (resultadoP - ladoB) *(resultadoP - ladoC));

            Console. ForegroundColor = ConsoleColor. DarkGreen;
            Console. WriteLine("Semiperímetro = {0}", resultadoP);
            Console. WriteLine("Área = {0}(cm²)", resultadoA);
            Console. WriteLine(\n" );

            Console. WriteLine("Pressione ENTER para sair!" );
            Console. ReadKey();
        }
    }
}