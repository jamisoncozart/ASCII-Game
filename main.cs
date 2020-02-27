using System;
using Models;

public class Program
{
  public static void Main()
  {
    Console.Clear();
    Game newGame = new Game();
    Player newPlayer = new Player();
    newGame.CreateGame();
    int[][] gameBoard = newGame.GetGame();

    for (int i = 0; ; i++)
    {
      Console.SetCursorPosition(Console.WindowLeft, Console.WindowTop);
      Console.Write(GetGameBoardString(gameBoard));
    }
  }

  public static string GetGameBoardString(int[][] game)
  {
    string gameBoardString = "";
    for(int i = 0; i < game.Length; i++)
    {
      gameBoardString += (String.Join("", game[i]) + "\n");
    }
    return gameBoardString;
  }
}