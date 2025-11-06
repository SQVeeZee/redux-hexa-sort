using Newtonsoft.Json;

namespace Project
{
    [JsonObject("board")]
    public struct BoardData
    {
        [JsonProperty("cells")]
        public CellData[] Cells { get; }

        [JsonConstructor]
        public BoardData(CellData[] cells) => Cells = cells;
    }
}