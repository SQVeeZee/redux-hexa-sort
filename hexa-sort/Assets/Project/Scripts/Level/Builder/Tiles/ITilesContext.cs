using System.Collections.Generic;

namespace Project
{
    public interface ITilesContext
    {
        List<TileView> Tiles { get; }
        void AddTile(TileView tileView);
        void RemoveTile(TileView tileView);
    }
}