using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using ScrabbleScore;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void StringSplit_SplitStringIntoList_List()
    {
      Scrabble newScrabble = new Scrabble();
      string testString = "abc";
      List<char> testList = newScrabble.StringSplit(testString);
      List<char> expected = new List<char>(){'a','b','c'};

      CollectionAssert.AreEqual(expected, testList);
    }
    [TestMethod]
    public void LetterCheck_CheckForOnePoint_int()
    {
      Scrabble newScrabble = new Scrabble();
      string testString = "aeiourstln";
      List<char> testList = newScrabble.StringSplit(testString);
      
      for (int i=0; i<testString.Length; i++) {
        Assert.AreEqual(1, newScrabble.LetterCheck(testList[i]));
      }
    }
    [TestMethod]
    public void LetterCheck_CheckForTwoPoints_int()
    {
      Scrabble newScrabble = new Scrabble();
      string testString = "dg";
      List<char> testList = newScrabble.StringSplit(testString);
      
      for (int i=0; i<testString.Length; i++) {
        Assert.AreEqual(2, newScrabble.LetterCheck(testList[i]));
      }
    }
    [TestMethod]
    public void LetterCheck_CheckForThreePoints_int()
    {
      Scrabble newScrabble = new Scrabble();
      string testString = "bcmp";
      List<char> testList = newScrabble.StringSplit(testString);
      
      for (int i=0; i<testString.Length; i++) {
        Assert.AreEqual(3, newScrabble.LetterCheck(testList[i]));
      }
    }
    [TestMethod]
    public void LetterCheck_CheckForFourPoints_int()
    {
      Scrabble newScrabble = new Scrabble();
      string testString = "fhvwy";
      List<char> testList = newScrabble.StringSplit(testString);
      
      for (int i=0; i<testString.Length; i++) {
        Assert.AreEqual(4, newScrabble.LetterCheck(testList[i]));
      }
    }
    [TestMethod]
    public void LetterCheck_CheckForFivePoints_int()
    {
      Scrabble newScrabble = new Scrabble();
      string testString = "k";
      List<char> testList = newScrabble.StringSplit(testString);
      
      for (int i=0; i<testString.Length; i++) {
        Assert.AreEqual(5, newScrabble.LetterCheck(testList[i]));
      }
    }
    [TestMethod]
    public void LetterCheck_CheckForEightPoints_int()
    {
      Scrabble newScrabble = new Scrabble();
      string testString = "jx";
      List<char> testList = newScrabble.StringSplit(testString);
      
      for (int i=0; i<testString.Length; i++) {
        Assert.AreEqual(8, newScrabble.LetterCheck(testList[i]));
      }
    }
    [TestMethod]
    public void LetterCheck_CheckForTenPoints_int()
    {
      Scrabble newScrabble = new Scrabble();
      string testString = "qz";
      List<char> testList = newScrabble.StringSplit(testString);
      
      for (int i=0; i<testString.Length; i++) {
        Assert.AreEqual(10, newScrabble.LetterCheck(testList[i]));
      }
    }



  }
}