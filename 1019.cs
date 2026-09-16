using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int horas = N / 3600;
        int resto = N % 3600;

        int minutos = resto / 60;
        int segundos = resto % 60;

        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}
