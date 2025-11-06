using Project.Extension;
using UnityEngine;
using VContainer;

namespace Project
{
    public class TilesFactory : MonoFactory<TileView>
    {
        private readonly TileAssetConfig _config;

        [Inject]
        private TilesFactory(TileAssetConfig tileAssetConfig) => _config = tileAssetConfig;

        public TileView CreateTile(TileType tileType, Transform root)
        {
            var prefab = _config.GetCellPrefabByType(tileType);
            return Create(prefab, root);
        }
    }
}