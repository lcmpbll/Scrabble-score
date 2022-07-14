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
      else
      {
        return 0;
      }
    }
  }
}