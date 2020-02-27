namespace Models
{
  public class Game
  {
    private int[][] _game = new int[6][];

    public void CreateGame()
    {
      _game[0] = new int[] { 1,1,1,1,1,1 };
      _game[1] = new int[] { 1,0,0,0,0,1 };
      _game[2] = new int[] { 1,0,0,0,0,1 };
      _game[3] = new int[] { 1,0,0,0,0,1 };
      _game[4] = new int[] { 1,0,0,0,0,1 };
      _game[5] = new int[] { 1,1,1,1,1,1 };
    }

    public int[][] GetGame()
    {
      return _game;
    }
  }
}