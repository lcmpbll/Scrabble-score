using System;
using System.Collections.Generic;

namespace ScrabbleScore
{
  public class Scrabble
  {
    public List<char> StringSplit(string input)
    {
      char[] array = input.ToLower().ToCharArray();
      List<char> list = new List<char>(array);
      return list;
    }
    
    public int LetterCheck(char listChar)
    {
      if ("aeiourstln".Contains(listChar))
      {
        return 1;
      }
      else if ("dg".Contains(listChar))
      {
        return 2;
      } 
      else if ("bcmp".Contains(listChar))
      {
        return 3;
      }
      else if ("fhvwy".Contains(listChar))
      {
        return 4;
      }
      else if ("k".Contains(listChar))
      {
        return 5;
      }
      else if ("jx".Contains(listChar))
      {
        return 8;
      }
      else if ("qz".Contains(listChar))
      {
        return 10;
      }
      else
      {
        return 0;
      }
    }

    public int ScoreCount (List<char> word)
    {
      int score = 0;
      for (int i=0; i<word.Count; i++) 
      {
        score += LetterCheck(word[i]);
      }
      return score;
    }

    public List<string> TwoWords (string input)
    {
      string[] oneArray = input.Split(", ", ",", " ");
      List<string> oneList = new List<string>(oneArray);
      return oneList;
    }
  }
}