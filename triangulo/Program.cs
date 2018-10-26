using System;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            //string texto;
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Informe o lado A: ");
            //triangulo.ladoA = Int32.Parse(Console.ReadLine());
            triangulo.defineValorLadoA(Int32.Parse(Console.ReadLine()));

            /*Console.WriteLine("Informe o lado B: ");
            //triangulo.ladoB = Int32.Parse(Console.ReadLine());
            triangulo.defineValorLadoB(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Informe o lado C: ");
            //triangulo.ladoC = Int32.Parse(Console.ReadLine());
            triangulo.defineValorLadoC(Int32.Parse(Console.ReadLine()));*/

            Console.WriteLine("LadoA: " + triangulo.pegaValorLadoA() + "\n");
            /*Console.WriteLine("LadoB: " + triangulo.ladoB + "\n");
            Console.WriteLine("LadoC: " + triangulo.ladoC + "\n");*/

        }
    }
}
