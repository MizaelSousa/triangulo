using System;

namespace triangulo
{
    class Program
    {

        static void Main(string[] args)
        {
            int ladoA;
            int ladoB;
            int ladoC;

            string texto;

            /*
             * esse mesmo comando abaixo pode ser feito da seguinte forma
             * Console.WriteLine("Digite qualquer coisa...");
             * texto = Console.ReadLine();
             * Console.WriteLine("Foi digitado isso aqui: " texto);
            */

            Console.WriteLine("Digite um valor para o lado A: ");
            ladoA = Int32.Parse(Console.ReadLine());
            texto = "lado A: " + ladoA;
            //Console.WriteLine("Valor da variavel texto: " + texto);

            Console.WriteLine("Digite um valor para o lado B: ");
            ladoB = Int32.Parse(Console.ReadLine());
            texto += "\nlado B: " + ladoB;
            //Console.WriteLine("Valor da variavel texto: " + texto);

            Console.WriteLine("Digite um valor para o lado C: ");
            ladoC = Int32.Parse(Console.ReadLine());
            texto += "\nlado C: " + ladoC;
            //Console.WriteLine("Valor da variavel texto: " + texto);

            Console.WriteLine(texto);


        }
    }
}
