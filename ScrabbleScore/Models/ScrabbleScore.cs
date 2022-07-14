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
    public bool LetterCheck(List<char> list)
    {
      return list.Contains('a');
    }
  }

}