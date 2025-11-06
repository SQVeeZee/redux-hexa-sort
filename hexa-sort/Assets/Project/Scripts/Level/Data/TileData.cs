using System;
using Newtonsoft.Json;

namespace Project
{
    [Serializable]
    public struct TileData
    {
        [JsonProperty("type")]
        public TileType TileType { get; }
        [JsonProperty("height")]
        public int Height { get; }

        [JsonConstructor]
        public TileData(TileType tileType, int height)
        {
            TileType = tileType;
            Height = height;
        }
    }
}