using System;
using Newtonsoft.Json;

namespace Project
{
    [Serializable]
    public struct TowerData
    {
        [JsonProperty("tiles")]
        public TileData[] Tiles { get; }

        [JsonConstructor]
        public TowerData(TileData[] tiles) => Tiles = tiles;
    }
}