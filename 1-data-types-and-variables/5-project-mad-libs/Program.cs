using System;
namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program will ask the user for a series of inputs, and then print out a story based on those inputs.
            Author: H4ck3rTr4d3r
            */

            // Let the user know that the program is starting:
            Console.WriteLine("Vamos escrever uma historia maluca?");

            // Define user input and variables:
            Console.WriteLine("Digite um nome:");
            string name = Console.ReadLine();
            Console.WriteLine("Digite um primeiro adjetivo (ex: feio, bonito, alto, magro): ");
            string adj1 = Console.ReadLine();
            Console.WriteLine("Digite um segundo adjetivo: ");
            string adj2 = Console.ReadLine();
            Console.WriteLine("E um terceiro adjetivo: ");
            string adj3 = Console.ReadLine();
            Console.WriteLine("Digite um verbo(ex: pular, nadar, andar, comer): ");
            string verb = Console.ReadLine();
            Console.WriteLine("Digite um substantivo(menino, menina, carro, barco): ");
            string noun = Console.ReadLine();
            Console.WriteLine("E um segundo substantivo: ");
            string noun2 = Console.ReadLine();

            // Ask the user to input one of each of the following:
            Console.WriteLine("Agora digite: \n 1) Um animal: ");
            string animal = Console.ReadLine();
            Console.WriteLine("2) Uma comida: ");
            string food = Console.ReadLine();
            Console.WriteLine("3) Uma fruita: ");
            string fruit = Console.ReadLine();
            Console.WriteLine("4) Um superheroi: ");
            string superHero = Console.ReadLine();
            Console.WriteLine("5) Um Pais: ");
            string country = Console.ReadLine();
            Console.WriteLine("6) Um doce: ");
            string dessert = Console.ReadLine();
            Console.WriteLine("7) Um ano: ");
            string year = Console.ReadLine();

            // The template for the story
            string story = $"Nessa manha {name} acordou sentindo-se {adj1}. 'Sera um dia {adj2} !' Do lado de fora, um monte de {animal} estavam protestando para que tivesse {food} no mercado. Eles comecaram a {verb} ao ritmo do {noun}, que fez todas as {fruit} muito {adj3}. Preocupado, {name} enviou uma mensagem para o {superHero}, que levou {name} para {country} e deixou {name} dentro de um {dessert} congelado. {name} acordou no ano {year}, em um mundo onde {noun2} mandava no mundo.";

            // Print the story
            Console.WriteLine(story);
        }
    }
}



