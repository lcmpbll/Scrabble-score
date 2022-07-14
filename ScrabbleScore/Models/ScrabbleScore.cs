using System;
using System.Collections.Generic;

namespace ScrabbleScore
{
  public class Scrabble
  {
    public List<char> StringSplit(string input)
    {
      char[] array = input.ToCharArray();
      List<char> list = new List<char>(array);
      return list;
    }
    public int LetterCheck(char listChar)
    {
      if ("aeiourstln".Contains(listChar))
      {
        return 1;
      }
      else 
      {
        return 0;
      }
    }
  }

}