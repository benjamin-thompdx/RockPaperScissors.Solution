using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
using System;
namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void RandomNumber_RadomNumberLessThan4_Int()
    {
      Game newGame = new Game();

      int result = newGame.RandomNumber();

      Assert.IsTrue((result < 4) && (result > 0), "result is less than 4 and greater than 0");
    }

    [TestMethod]
    public void ComputerTurn_RandomResult_String()
    {
      Game newGame = new Game();
      
      newGame.RandomNumber();
      string computerResult = newGame.ComputerTurn();

      Assert.IsTrue((computerResult == "rock") || (computerResult == "paper") ||(computerResult == "scissors"));
    }

    [TestMethod]
    public void GameResults_WhoWinsGame_String()
    {
      Game newGame = new Game();

      newGame.RandomNumber();
      newGame.ComputerTurn();
      string userResult = newGame.GameResults("rock");

      Assert.IsTrue((userResult == "YOU WIN!") || (userResult == "YOU LOSE!") ||(userResult == "DRAW"));
    }
  }
}