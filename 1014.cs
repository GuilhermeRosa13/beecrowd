using System;

class URI {

    static void Main(string[] args) {

        int X = int.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine());

        double consumo = X / Y;

        Console.WriteLine(consumo.ToString("F3") + " km/l");

    }

}