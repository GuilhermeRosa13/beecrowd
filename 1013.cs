using System;

class URI {

    static void Main(string[] args) {

        string[] valores = Console.ReadLine().Split(' ');

        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int c = int.Parse(valores[2]);

        int maior = Math.Max(a, Math.Max(b, c));

        Console.WriteLine(maior + " eh o maior");

    }

}