using System;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public int CompOutput { get; set; }
    public string ComputerMove { get; set; }

    public Game ()
    {
      CompOutput = 0;
      ComputerMove = "";
      
    
    }

    public void SetComputerMove(string computerTest)
    {
      ComputerMove = computerTest;
    }

    public int RandomNumber()
    
    {
      Random random = new Random();
      CompOutput = random.Next(1,4);
      return CompOutput;
    }
    
    public string ComputerTurn()
    {
      if (CompOutput == 1)
      {
        ComputerMove = "rock";
        return "rock";
      }
      else if (CompOutput == 2)
      {
        ComputerMove = "paper";
        return "paper";
      }
      else if (CompOutput == 3)
      {
        ComputerMove = "scissors";
        return "scissors";
      }
      else 
      {
        return "error";
      }
    }
    
    public string GameResults(string userInput)
    {
      if ((userInput == "rock") && (ComputerMove == "scissors"))
      {
        return "YOU WIN!";
      }
      else if ((userInput == "rock") && (ComputerMove == "paper"))
      {
        return "YOU LOSE!";
      }
      else if ((userInput == "rock") && (ComputerMove == "rock"))
      {
        return "DRAW";
      }
      else if ((userInput == "paper") && (ComputerMove == "scissors"))
      {
        return "YOU LOSE!";
      }
      else if ((userInput == "paper") && (ComputerMove == "paper"))
      {
        return "DRAW";
      }
      else if ((userInput == "paper") && (ComputerMove == "rock"))
      {
        return "YOU WIN!";
      }
      else if ((userInput == "scissors") && (ComputerMove == "scissors"))
      {
        return "DRAW";
      }
      else if ((userInput == "scissors") && (ComputerMove == "paper"))
      {
        return "YOU WIN!";
      }
      else if ((userInput == "scissors") && (ComputerMove == "rock"))
      {
        return "YOU LOSE!";
      }
      else
      {
        return "error";
      }
    }
  }
}
