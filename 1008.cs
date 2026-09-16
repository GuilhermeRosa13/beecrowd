    using System;
    using System.Globalization;

   
        class Program
        {
            static void Main(string[] args)
            {

            int numeroDoFuncionario, horasTrabalhadas ;
            double valorPorHora, salario;

            numeroDoFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorPorHora;

            Console.WriteLine("NUMBER = " + numeroDoFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F02", CultureInfo.InvariantCulture));




       
            


        }
        }
    