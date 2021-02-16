using System;

namespace Uri_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(vetor[0]);
            int horaFinal = int.Parse(vetor[1]);
            int duracao;

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O jogo durou "+duracao+" hora(s)");
        }
    }
}
