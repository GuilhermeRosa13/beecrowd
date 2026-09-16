    using System;
    using System.Globalization;

   
        class Program
        {
            static void Main(string[] args)
            {

            double  salarioFixo, vendasEfetuadas , salariofinal;
            string vendedor;
            vendedor = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendasEfetuadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salariofinal = vendasEfetuadas * 15.0 / 100 + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + salariofinal.ToString("F2", CultureInfo.InvariantCulture));
      


          }

        }
    