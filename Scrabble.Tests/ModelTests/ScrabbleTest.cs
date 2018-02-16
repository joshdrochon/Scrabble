using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleProject.Models;
using ScrabbleProject;
using System;

namespace ScrabbleProject.TestTool
{
  [TestClass]
  public class ScrabbleTest : IDisposable
  {
    public void Dispose()
    {
      Scrabble.reset();
    }

    [TestMethod]
    public void TestCalc_Pass()
    {
      Scrabble testPass = new Scrabble();
      int testCounter = 14;
      Assert.AreEqual(testCounter, testPass.ScrabbleCalc("Python"));
    }

    [TestMethod]
    public void TestCalc_Fail()
    {
      Scrabble testFail = new Scrabble();
      int testCounter = 9;
      Assert.AreEqual(testCounter, testFail.ScrabbleCalc("Ruby"));
    }

    [TestMethod]
    public void TestCounter_Reset()
    {
      int expectedResult = 0;
      int actualResult = Scrabble.reset();
      Assert.AreEqual(expectedResult, actualResult);
    }
  }
}
