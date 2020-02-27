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
    bool paused = false;
    while (true)
    {
      if (Console.KeyAvailable)
      {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.RightArrow) newPlayer.MovePlayer("right");
        else if (keyInfo.Key == ConsoleKey.LeftArrow) newPlayer.MovePlayer("left");
        else break;
      }
      Console.SetCursorPosition(Console.WindowLeft, Console.WindowTop);
      Console.Write(GetGameBoardString(gameBoard)); 
    }
    // for (int i = 0; ; i++)
    // {
    //   Console.SetCursorPosition(Console.WindowLeft, Console.WindowTop);
    //   Console.Write(GetGameBoardString(gameBoard));
    // }
  }

  public static string GetGameBoardString(int[][] gameBoard)
  {
    //add player to board
    newGame.CreateGame();
    int playerX = newPlayer.getPlayerX();
    int playerY = newPlayer.getPlayerY();
    gameBoard[playerY][playerX] = 2;
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