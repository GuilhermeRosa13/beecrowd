using System;

class URI {

    static void Main(string[] args) {

        int N = int.Parse(Console.ReadLine());

        Console.WriteLine(N);

        int[] notas = {100, 50, 20, 10, 5, 2, 1};

        foreach (int nota in notas) {

            int quantidade = N / nota;

            Console.WriteLine(quantidade + " nota(s) de R$ " + nota + ",00");

            N = N % nota;

        }

    }

}