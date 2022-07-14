using System;
using System.Collections.Generic;
using System.Linq;
using ScrabbleScore;

namespace ScrabbleScore
{
  public class Program
  {
    public static void Main()
    {
      Scrabble newScrabble = new Scrabble();
      Console.WriteLine("Enter a word:");
      string input = Console.ReadLine();

      List<string> words = newScrabble.TwoWords(input);
      for (int i=0; i<words.Count; i++) 
      {
        List<char> letters = newScrabble.StringSplit(words[i]);
        int score = newScrabble.ScoreCount(letters);
        Console.WriteLine(words[i] + " is worth " + score + " points");
      }
    }
  }
}