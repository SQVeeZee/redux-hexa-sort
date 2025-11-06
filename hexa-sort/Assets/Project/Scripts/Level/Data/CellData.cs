using Newtonsoft.Json;
using UnityEngine;

namespace Project
{
    [JsonObject("cell")]
    public struct CellData
    {
        [JsonProperty("type")]
        public CellType CellType { get; }
        [JsonProperty("tower")]
        public TowerData TowerData { get; }
        [JsonProperty("pos")]
        public PositionData Position { get; }

        [JsonConstructor]
        public CellData(CellType cellType, TowerData towerData, PositionData position)
        {
            CellType = cellType;
            TowerData = towerData;
            Position = position;
        }
    }
}