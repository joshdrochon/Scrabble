using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleProject.Models;
using ScrabbleProject;
using System;

namespace ScrabbleProject.TestTool
{
  [TestClass]
  public class ScrabbleTest
  {
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
      int testCounter = 7;
      Assert.AreEqual(testCounter, testFail.ScrabbleCalc("Ruby"));
    }
  }
}
