using System;
using Models;

public class Program
{
  public static void Main()
  {
    Game newGame = new Game();
    newGame.CreateGame();
    int[][] gameBoard = newGame.GetGame();
    string gameBoardString = "";
    for(int i = 0; i < gameBoard.Length; i++)
    {
      gameBoardString += (String.Join("", gameBoard[i]) + "\n");
    }
    Console.WriteLine(gameBoardString);
  }
}