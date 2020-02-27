using System;
using Models;

public class Program
{
  public static Game newGame = new Game();
  public static Player newPlayer = new Player();

  public static void Main()
  {
    Console.Clear();
    newGame.CreateGame();
    int[][] gameBoard = newGame.GetGame();

    for (int i = 0; ; i++)
    {
      Console.SetCursorPosition(Console.WindowLeft, Console.WindowTop);
      Console.Write(GetGameBoardString(gameBoard));
    }
  }

  public static string GetGameBoardString(int[][] gameBoard)
  {
    //add player to board
    int playerX = newPlayer.getPlayerX();
    int playerY = newPlayer.getPlayerY();
    gameBoard[playerX][playerY] = 2;
    //create board string
    string gameBoardString = "";
    for(int i = 0; i < gameBoard.Length; i++)
    {
      gameBoardString += (String.Join("", gameBoard[i]) + "\n");
    }
    return gameBoardString;
  }

  public static void movePlayerController()
  {
    //move player based on key strokes
  }
}