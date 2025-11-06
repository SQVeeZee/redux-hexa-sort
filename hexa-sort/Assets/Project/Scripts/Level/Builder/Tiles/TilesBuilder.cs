using UnityEngine;
using VContainer;

namespace Project
{
    public class TilesBuilder
    {
        private readonly TilesFactory _factory;
        private readonly ITilesContext _tileContext;

        [Inject]
        private TilesBuilder(
            TilesFactory factory,
            ITilesContext tileContext)
        {
            _factory = factory;
            _tileContext = tileContext;
        }

        public void BuildTile(TileType tileType, Transform root)
        {
            var tile = _factory.CreateTile(tileType, root);
            _tileContext.AddTile(tile);
        }
    }
}