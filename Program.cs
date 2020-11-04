using System;


    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Aprovado/Reprovado");

        //Ler a primeira nota
        Console.WriteLine("Digite a primeira nota:");
        decimal nota1 = Convert.ToDecimal(Console.ReadLine());

        //Ler a segunda nota
        Console.WriteLine("Digite a segunda nota:");
        decimal nota2 = Convert.ToDecimal(Console.ReadLine());

        //Calcular a média
        decimal media = (nota1 + nota2) / 2;

        //Verificar se ele passou ou não (para passar, media >= 5, caso contrário reprovado

        if(media >= 5)
        {
            Console.WriteLine("Aprovado");
            Console.WriteLine($"Media = {media}");
        }

        else
        {
            Console.WriteLine("Reprovado");
            Console.WriteLine($"Media = {media}");
        }
    }
    }
