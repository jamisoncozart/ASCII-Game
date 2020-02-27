namespace Models
{
  public class Player
  {
    private int _x = 1;
    private int _y = 1;
  
    public int getPlayerX()
    {
      return _x;
    }
    public int getPlayerY()
    {
      return _y;
    }

    public void MovePlayer(string direction)
    {
      if(direction == "up")
      {
        _y--;
      }
      else if(direction == "down")
      {
        _y++;
      }
      else if(direction == "left")
      {
        _x--;
      }
      else if(direction == "right")
      {
        _x++;
      }
    }
  }
}