using System;
using Newtonsoft.Json;

namespace Project
{
    [Serializable]
    public class LevelData
    {
        [JsonProperty("board")]
        public BoardData BoardData { get; }

        [JsonConstructor]
        public LevelData(BoardData boardData) => BoardData = boardData;
    }
}