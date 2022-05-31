using System;

namespace Ex7_Laborator4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 7 dificultate ridicata
            //Scrieti o functie recursiva care pentru un numar “n” primit ca parametru, va
            //afisa urmatoarea piramida a numerelor:
            //1
            //2 2
            //3 3 3
            //4 4 4 4
            //…
            //n n n …..n

            Console.WriteLine("Introduceti un numar:");
            int numar = int.Parse(Console.ReadLine());

            int start = 1;
            AfisarePiramida(numar, start);
        }
        static int AfisarePiramida(int numar, int start)
        {
            if (start>numar)
            {
                return numar;
            }
            for (int i = 0; i < start; i++)
            {
                Console.Write(start + " ");
            }
            Console.WriteLine();
            AfisarePiramida(numar, start + 1);
            return numar;
        }
    }
}
