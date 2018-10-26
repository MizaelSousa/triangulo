using System;
namespace triangulo
{
    public class Triangulo
    {
        private int ladoA;
        private int ladoB;
        private int ladoC;

        //criando um metodo//
        public void defineValorLadoA(int valorDaTelaLadoA)
        {
            ladoA = valorDaTelaLadoA;
        }

        public string pegaValorLadoA()
        {
            return " VALOR " + ladoA.ToString();
        }

        public Triangulo()
        {
        
        }
    }
}
