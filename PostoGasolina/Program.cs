using System;

namespace PostoGasolina
{
    class Program
    {
        /// <summary>
        /// O objetivo de programa é saber a preferência de combustível em um posto
        /// O programa lê números até que o 4 seja informado, indicando a sua finalização 
        /// e apuração final.
        /// 
        /// No final ele exibe a quantidade de abastecimentos para cada tipo de combustível
        /// de acordo com o que está abaixo
        /// </summary>
        /// <param name="1">Gasolina</param>
        /// <param name="2">Álcool</param>
        /// <param name="3">Diesel</param>
        /// <param name="4">Fim do processo</param>
        static void Main(string[] args)
        {
            int cod, gasolina=0, alcool=0, diesel=0;
            do
            {
                Console.WriteLine("Opções: 1 - Gasolina, 2 - Álcool, 3 - Diesel, 4 - Apuração final");
                cod = int.Parse(Console.ReadLine());

                switch (cod)
                {
                    case 1:
                        gasolina++;
                        break;
                    case 2:
                        alcool++;
                        break;
                    case 3:
                        diesel++;
                        break;
                }
            } while (cod != 4);

            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
