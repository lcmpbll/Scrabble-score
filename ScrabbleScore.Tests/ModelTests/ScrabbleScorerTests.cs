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
    public void LetterCheck_CheckForA_int()
    {
      Scrabble newScrabble = new Scrabble();
      string testString = "abc";
      List<char> testList = newScrabble.StringSplit(testString);
      
      Assert.AreEqual(1, newScrabble.LetterCheck(testList));
    }
//     [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
  //}
    // [TestMethod]
    // public void ItemConstructor_CreatesInstanceOfItem_Item()
    // {
    //   Item newItem = new Item();
    //   Assert.AreEqual(typeof(Item), newItem.GetType());
    // }

//     [TestMethod]
//     public void GetDescription_ReturnsDescription_String()
//     {
//       string description = "Walk the dog.";
//       Item newItem = new Item(description);
//       string result = newItem.Description;
//       Assert.AreEqual(description, result);
//     }

//     [TestMethod]
// public void GetDescription_ReturnsDescription_String()
// {
//   //Arrange
//   string description = "Walk the dog.";
//   Item newItem = new Item(description);

//   //Act
//   string result = newItem.Description;

//   //Assert
//   Assert.AreEqual(description, result);
// }

  }
}