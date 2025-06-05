using System;
using HangmanGame;

class Program
{
    static void Main()
    {
        Hangman game = new();
        game.StartNewGame("spfpdsp");

        while (!game.isgover)
        {
            Console.Clear();
            Console.WriteLine("word: " + game.CurrentWordState);
            Console.WriteLine("let: " + string.Join(", ", game.ul));
            Console.WriteLine("att: " + game.ra);
            Console.Write("enter let: ");
            var input = Console.ReadKey().KeyChar;
            game.TryGuessLetter(input);
        }

        Console.Clear();
        Console.WriteLine(game.isw ? "win" : "loser");
        Console.WriteLine("yo word: " + game.CurrentWordState);
    }
}

