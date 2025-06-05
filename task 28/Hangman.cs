using System;
using System.Collections.Generic;
using System.Linq;

namespace HangmanGame
{
    public class Hangman
    {
        private string word;
        private char[] state;
        public int ra { get; private set; } = 6;
        public List<char> ul { get; private set; } = new();

        public void StartNewGame(string word)
        {
            this.word = word.ToUpper();
            state = new string('_', word.Length).ToCharArray();
            ra = 6;
            ul.Clear();
        }

        public bool TryGuessLetter(char letter)
        {
            letter = char.ToUpper(letter);
            if (ul.Contains(letter)) return false;

            ul.Add(letter);
            bool hit = false;

            for (int i = 0; i < word.Length; i++)
                if (word[i] == letter)
                {
                    state[i] = letter;
                    hit = true;
                }

            if (!hit) ra--;
            return hit;
        }

        public string CurrentWordState => new string(state);
        public bool isw => !CurrentWordState.Contains('_');
        public bool isgover => isw || ra == 0;
    }
}

