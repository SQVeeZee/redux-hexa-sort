using UnityEngine;

namespace Project
{
    [CreateAssetMenu(menuName = "Configs/Board/Tiles asset config", fileName = "tiles_asset_config", order = 0)]
    public class TileAssetConfig : ScriptableObject
    {
        [SerializeField]
        private TileAssetData[] _assetData;

        public TileView GetCellPrefabByType(TileType cellType)
        {
            foreach (var assetData in _assetData)
            {
                if (assetData.Type == cellType)
                {
                    return assetData.TileView;
                }
            }
            throw new System.Exception($"Cell type {cellType} not found in asset config");
        }
    }
}