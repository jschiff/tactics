using System;
namespace Com.Jschiff.Tactics.Common.Model.Arena
{
  /**
   * A tile is one square on the terrain.
   */
  public class Tile {
  
    public int Altitude { get; protected set; }
    
    public static Tile nullTile () {
      return null;
    }
    
    public Tile () {
    }
  }
}

